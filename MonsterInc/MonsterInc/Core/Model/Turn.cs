using System;
using System.Collections.Generic;
using Core.Events;

namespace Core.Model
{
    public class Turn
    {
        public event EventHandler<MonsterDefeadedEventArgs> MonsterDefeated;

        public int Position { get; set; }

        public Monster DefendingMonster { get; set; }
        public Monster AttackingMonster { get; set; }

        public Player currentPlayer;
        public Player currentOpponent;
        public Usable usable;
        public Usable opponentUsable;
        private Usable ongoingUsable;
        public Combat combat;

        string resultat = "";

        public List<Action> Actions { get; set; }
        public static int Tour { get; set; } = 1;


        public Turn() { }
        public Turn(Player currentPlayer, Player currentOpponent, Usable usable, Combat combat)
        {
            this.currentPlayer = currentPlayer;
            this.currentOpponent = currentOpponent;
            this.usable = usable;
            this.combat = combat;
        }

        public Turn(Player currentPlayer, Player currentOpponent, Combat combat) : this(currentPlayer, currentOpponent, null, combat)
        {
        }

        public string RunTurn()
        {
            RunAttackWithUsable(null, null, null);
            RunAttackWithUsable(null, null, null);

            return null;
        }

        public string RunAttackWithUsable(Player actualPlayer, Player actualOpponent, Usable selectedUsable)
        {
            if (!actualPlayer.ActiveTrainer.ActiveMonster.CanUseUsable(selectedUsable))
            {
                resultat += actualPlayer.ActiveTrainer.ActiveMonster.NickName +
                            " don t have enough energy to use " + selectedUsable + "\n";
                return resultat;
            }

            selectedUsable.Consume(actualPlayer, actualOpponent);

            foreach (var scope in selectedUsable.Scopes)
            {
                resultat = (combat.Tour + ":: " + actualPlayer.ActiveTrainer.ActiveMonster.NickName + " uses " + selectedUsable + " on " +
                                  ((scope.Target == Scope.ScopeTarget.Self)
                                      ? actualPlayer.ActiveTrainer.ActiveMonster.NickName
                                      : actualOpponent.ActiveTrainer.ActiveMonster.NickName) + "\n");
            }


            currentOpponent.ActiveTrainer.ActiveMonsters.Energize();
            combat.Tour++;

            if (!currentOpponent.ActiveTrainer.ActiveMonster.isAlive)
            {
                this.OnMonsterDefeated(currentOpponent.ActiveTrainer.ActiveMonster);
            }

            return resultat;
        }
    

        public string DoTurn()
        {
            
            //tour du joueur
            ongoingUsable = usable;
            if (!currentPlayer.ActiveTrainer.ActiveMonster.CanUseUsable(ongoingUsable))
            {
                resultat += currentPlayer.ActiveTrainer.ActiveMonster.NickName +
                            " don t have enough energy to use " + usable + "\n";
                return resultat;
            }
            usable.Consume(currentPlayer, currentOpponent);

            foreach (var scope in usable.Scopes)
            {
                resultat = (combat.Tour + ":: " + currentPlayer.ActiveTrainer.ActiveMonster.NickName + " uses " + usable + " on " +
                                  ((scope.Target == Scope.ScopeTarget.Self)
                                      ? currentPlayer.ActiveTrainer.ActiveMonster.NickName
                                      : currentOpponent.ActiveTrainer.ActiveMonster.Template.Name) + "\n");
            }


            currentOpponent.ActiveTrainer.ActiveMonsters.Energize();
            combat.Tour++;

            if (!currentOpponent.ActiveTrainer.ActiveMonster.isAlive)
            {
                this.OnMonsterDefeated(currentOpponent.ActiveTrainer.ActiveMonster);
            }

            return resultat;
        }

        public string DoEnemyTurn()
        {
            opponentUsable = currentOpponent.PickUsable(currentPlayer);
            ongoingUsable = opponentUsable;
            if (!currentOpponent.ActiveTrainer.ActiveMonster.CanUseUsable(opponentUsable))
            {
                resultat += currentOpponent.ActiveTrainer.ActiveMonster.Template.Name +
                            " don t have enough energy to use " + opponentUsable + "\n";
                return resultat;
            }

            opponentUsable.Consume(currentOpponent, currentPlayer);

            foreach (var scope in usable.Scopes)
            {

                resultat += (combat.Tour + ":: " + currentOpponent.ActiveTrainer.ActiveMonster.Template.Name + " uses " + opponentUsable + " on " +
                    ((scope.Target == Scope.ScopeTarget.Self)
                    ? currentOpponent.ActiveTrainer.ActiveMonster.Template.Name
                    : currentPlayer.ActiveTrainer.ActiveMonster.NickName) + "\n");
            }

            currentPlayer.ActiveTrainer.ActiveMonsters.Energize();
            combat.Tour++;

            if (!currentPlayer.ActiveTrainer.ActiveMonster.isAlive)
            {
                this.OnMonsterDefeated(currentPlayer.ActiveTrainer.ActiveMonster);
            }

            return resultat;
        }


        private void OnMonsterDefeated(Monster defeatedMonster)
        {
            if (MonsterDefeated != null)
            {
                var args = new MonsterDefeadedEventArgs(defeatedMonster);
                MonsterDefeated(this, args);
            }
        }

    }

}
