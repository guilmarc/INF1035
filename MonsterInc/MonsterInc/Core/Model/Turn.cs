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

        public Turn(Player currentPlayer, Player currentOpponent, Combat combat)
        {
            this.currentPlayer = currentPlayer;
            this.currentOpponent = currentOpponent;
            this.combat = combat;
        }

        public string DoTurn()
        {
            
            //tour du joueur
            ongoingUsable = usable;
            if (!HasEnougthEnergy)
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
                resultat += currentOpponent.ActiveTrainer.ActiveMonster.Template.Name + " defeated! \n";
                combat.Tour++;

                return resultat;
            }

           
            return resultat;
        }

        public string DoEnemyTurn()
        {
            opponentUsable = currentOpponent.PickUsable(currentPlayer);
            ongoingUsable = opponentUsable;
            if (!HasEnoughtEnergyEnemy)
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

            if (!currentPlayer.ActiveTrainer.ActiveMonster.isAlive)
            {
                this.OnMonsterDefeated(currentPlayer.ActiveTrainer.ActiveMonster);
                resultat += currentPlayer.ActiveTrainer.ActiveMonster.Template.Name + " defeated! \n";
                combat.Tour++;

                return resultat;
            }



            if (currentPlayer.ActiveTrainer.ActiveMonster.Caracteristics[0].Actual < 0)
            {
                currentPlayer.ActiveTrainer.ActiveMonster.Caracteristics[0].Actual = 0;
                resultat += currentPlayer.ActiveTrainer.ActiveMonster.NickName + " defeated! \n";
                combat.Tour++;
                return resultat;
            }
            currentPlayer.ActiveTrainer.ActiveMonsters.Energize();
            combat.Tour++;
            return resultat;
        }


        public bool HasEnougthEnergy
        {
            get
            {
                if (ongoingUsable is Skill)
                {
                    var skill = (Skill)ongoingUsable;
                    if (currentPlayer.ActiveTrainer.ActiveMonster.Caracteristics[1].Actual < skill.EnergyPointCost)
                    {
                        return false;
                    }
                }

                return true;
            }
        }


        public bool HasEnoughtEnergyEnemy
        {
            get
            {
                if (ongoingUsable is Skill)
                {
                    var skill = (Skill)ongoingUsable;
                    if (currentOpponent.ActiveTrainer.ActiveMonster.Caracteristics[1].Actual < skill.EnergyPointCost)
                    {
                        return false;
                    }
                }

                return true;
            }
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
