using System;
using System.Collections.Generic;
using Core.Events;

namespace Core.Model
{
    /// <summary>
    /// Classe responsable de cahcun des round de combat
    /// </summary>
    public class Turn
    {
        /// <summary>
        /// Événement personnalisé déclenché lorsqu'un monstre meurt
        /// </summary>
        public event EventHandler<MonsterDefeadedEventArgs> MonsterDefeated;

        /// <summary>
        /// Position dans le round
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Monstre qui se défend
        /// </summary>
        public Monster DefendingMonster { get; set; }

        /// <summary>
        /// Monstre qui attqaque
        /// </summary>
        public Monster AttackingMonster { get; set; }

        /// <summary>
        /// Variables privées
        /// </summary>
        private Player _currentPlayer;
        private Player _currentOpponent;
        private Usable _usable;
        private Combat _combat;
        private string _result = "";

        /// <summary>
        /// Constructeur par défaut nécessaire à la sérialisation
        /// </summary>
        public Turn() { }

        /// <summary>
        /// Constructeur instanciant un round d'attaque humain
        /// </summary>
        /// <param name="currentPlayer"></param>
        /// <param name="currentOpponent"></param>
        /// <param name="usable"></param>
        /// <param name="combat"></param>
        public Turn(Player currentPlayer, Player currentOpponent, Usable usable, Combat combat)
        {
            this._currentPlayer = currentPlayer;
            this._currentOpponent = currentOpponent;
            this._usable = usable;
            this._combat = combat;
        }

        /// <summary>
        /// Constructeur instsanciant un round de défence humain
        /// </summary>
        /// <param name="currentPlayer"></param>
        /// <param name="currentOpponent"></param>
        /// <param name="combat"></param>
        public Turn(Player currentPlayer, Player currentOpponent, Combat combat) : this(currentPlayer, currentOpponent, null, combat)
        {
        }

        /// <summary>
        /// Exécution du round avec résultat
        /// </summary>
        /// <returns></returns>
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
            
            //Exécution de l'attaque du joueur robot
            var AIUsable = _currentOpponent.PickUsable(_currentPlayer);
            RunAttackWithUsable(_currentOpponent, _currentPlayer, AIUsable);

            return _result;
        }

        //Exécution d'une défense
        private void RunDefense(Player actualPlayer)
        {
            //Une défense donne 2x de regénération d'énergie
            actualPlayer.ActiveTrainer.ActiveMonsters.Energize();
            actualPlayer.ActiveTrainer.ActiveMonsters.Energize();
            _combat.Tour++;

            _result += actualPlayer.ActiveTrainer.ActiveMonster.NickName + " is defending\n";
        }

        /// <summary>
        /// Exécution d'une attaque
        /// </summary>
        /// <param name="actualPlayer"></param>
        /// <param name="actualOpponent"></param>
        /// <param name="selectedUsable"></param>
        private void RunAttackWithUsable(Player actualPlayer, Player actualOpponent, Usable selectedUsable)
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
    
        /// <summary>
        /// Méthode lancée lorsqu'un monstres meurt
        /// </summary>
        /// <param name="defeatedMonsterPlayer"></param>
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
