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

        private Player _currentPlayer;
        private Player _currentOpponent;
        private Usable _usable;
        //private Usable _opponentUsable;
        //private Usable _ongoingUsable;
        private Combat _combat;

        private string _result = "";

        public List<Action> Actions { get; set; }
        public static int Tour { get; set; } = 1;

        public Turn() { }
        public Turn(Player currentPlayer, Player currentOpponent, Usable usable, Combat combat)
        {
            this._currentPlayer = currentPlayer;
            this._currentOpponent = currentOpponent;
            this._usable = usable;
            this._combat = combat;
        }

        public Turn(Player currentPlayer, Player currentOpponent, Combat combat) : this(currentPlayer, currentOpponent, null, combat)
        {
        }


        public string Run()
        {
            //Exécution de l'attaque du joueur humain
            if (this._usable != null)
            {
                RunAttackWithUsable(_currentPlayer, _currentOpponent, this._usable);
            }
            else
            {
                //Mode défensif
                RunDefense(_currentPlayer);
            }
            
            //Exécution de l'attaque ju joueur robot
            var AIUsable = _currentOpponent.PickUsable(_currentPlayer);
            RunAttackWithUsable(_currentOpponent, _currentPlayer, AIUsable);

            return _result;
        }

        public void RunDefense(Player actualPlayer)
        {
            //Une défense donne 2x de regénération d'énergie
            actualPlayer.ActiveTrainer.ActiveMonsters.Energize();
            actualPlayer.ActiveTrainer.ActiveMonsters.Energize();
            _combat.Tour++;

            _result += actualPlayer.ActiveTrainer.ActiveMonster.NickName + " is defending\n";
        }

        public void RunAttackWithUsable(Player actualPlayer, Player actualOpponent, Usable selectedUsable)
        {
            //Si on tente d'utiliser un Usable sans avoir assez d'énergie, on perd son tour..
            if (!actualPlayer.ActiveTrainer.ActiveMonster.CanUseUsable(selectedUsable))
            {
                _result += actualPlayer.ActiveTrainer.ActiveMonster.NickName +
                            " don t have enough energy to use " + selectedUsable + "\n";
                return ;
            }

            selectedUsable.Consume(actualPlayer, actualOpponent);

            foreach (var scope in selectedUsable.Scopes)
            {
                _result += (_combat.Tour + ":: " + actualPlayer.ActiveTrainer.ActiveMonster.NickName + " uses " + selectedUsable + " on " +
                                  ((scope.Target == Scope.ScopeTarget.Self)
                                      ? actualPlayer.ActiveTrainer.ActiveMonster.NickName
                                      : actualOpponent.ActiveTrainer.ActiveMonster.NickName) + "\n");
            }

            actualPlayer.ActiveTrainer.ActiveMonsters.Energize();
            _combat.Tour++;

            if (!actualPlayer.ActiveTrainer.ActiveMonster.IsAlive)
            {
                this.OnMonsterDefeated(actualPlayer);
            }
        }
    
        private void OnMonsterDefeated(Player defeatedMonsterPlayer)
        {
            if (MonsterDefeated != null)
            {
                var args = new MonsterDefeadedEventArgs(defeatedMonsterPlayer);
                MonsterDefeated(this, args);
            }
        }

    }

}
