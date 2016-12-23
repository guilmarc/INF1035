using System;
using System.Collections.Generic;

namespace Core.Model
{
    public class Turn
    {
        public int Position { get; set; }

        public Monster DefendingMonster { get; set; }
        public Monster AttackingMonster { get; set; }

        public Player currentPlayer;
        public Player currentOpponent;
        public Usable usable;
        public Combat combat;

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

        public string DoTurn
        {
            get
            {
                string resultat="";

                //tour du joueur
                usable.Consume(currentPlayer, currentOpponent);
                
                foreach (var scope in usable.Scopes)
                {
                    resultat = (combat.Tour + ":: " + currentPlayer.ActiveTrainer.ActiveMonster.NickName + " uses " + usable + " on " +
                                      ((scope.Target == Scope.ScopeTarget.Self)
                                          ? currentPlayer.ActiveTrainer.ActiveMonster.NickName
                                          : currentOpponent.ActiveTrainer.ActiveMonster.Template.Name)+"\n");
                }
                if (currentOpponent.ActiveTrainer.ActiveMonster.Caracteristics[0].Actual < 0)
                {
                    currentOpponent.ActiveTrainer.ActiveMonster.Caracteristics[0].Actual = 0;
                    resultat += currentOpponent.ActiveTrainer.ActiveMonster.Template.Name + " defeated! \n";
                    combat.Tour++;
                    return resultat;
                }

                combat.Tour++;

                //tour de l'adversaire
                currentOpponent.PickUsable(currentPlayer).Consume(currentOpponent, currentPlayer);

                foreach (var scope in usable.Scopes)
                {
                    resultat += (combat.Tour + ":: " + currentOpponent.ActiveTrainer.ActiveMonster.Template.Name + " uses " + usable + " on " +
                                      ((scope.Target == Scope.ScopeTarget.Self)
                                          ? currentOpponent.ActiveTrainer.ActiveMonster.Template.Name
                                          : currentPlayer.ActiveTrainer.ActiveMonster.NickName) + "\n");
                }
                if (currentPlayer.ActiveTrainer.ActiveMonster.Caracteristics[0].Actual < 0)
                {
                    currentPlayer.ActiveTrainer.ActiveMonster.Caracteristics[0].Actual = 0;
                    resultat += currentPlayer.ActiveTrainer.ActiveMonster.NickName + " defeated! \n";
                    combat.Tour++;
                    return resultat;
                }
                combat.Tour++;
                return resultat;
            }

        }
    }
}
