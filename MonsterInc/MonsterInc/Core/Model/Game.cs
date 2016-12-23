using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Core.Model
{
    [Serializable]
    public class Game
	{

        public static event EventHandler GameCompleted;

	    public string Name { get; set; } = "NewGame";
	    public DateTime StartTime { get; set; } = DateTime.Now;
        public DateTime EndTime { get; set; }
	    public Player HumanPlayer { get; set; }

	    /*
        public TimeSpan GameTime
        {
            get
            {
                //return (EndTime. ?? DateTime.Now) - StartTime
                return null;
            }
        }
        */
		//public Player Player { get; set; }

		//public List<Combat> Combats { get; set; }

	    public Game() {}

	    public Game(int opponentsCount = 2)
	    {
	        //Génération d'une Game de simulation
	    }

	    public Game(Player HumanPlayer, int opponentsCount = 1)
	    {
	        this.HumanPlayer = HumanPlayer;
	    }

	    public void Run()
	    {
	        do
	        {
                //Demander le niveau de difficulté à l'utilisateur
	            var difficulty = Universe.Difficulties[0];
                Console.WriteLine("Début d'un nouveau combat au niveau de difficulté " + difficulty);

                var combat = new Combat(this, Universe.Difficulties[0]);
	            combat.Run();

	            //Réinitialise les caractéristiques des monstres encore en vie
	            var count = HumanPlayer.ActiveTrainer.ActiveMonsters.Reset();
                //count Monsters ont été réinitialités


                //On crée un nouveau Combat tant qu'on a encore un Monstre Actif
            } while (HumanPlayer.ActiveTrainer.ActiveMonsters.Count > 0);

            //ICI LE JOUEUR HUMAIN EST MORT
	    }

		public void Save()
		{
		    Save(this.Name + "_" + StartTime.ToString("yyyyMMddHHmmss"));
		}

        public void Save(string gameName)
        {
            var filePath = Constants.SavedGamePath + gameName + Constants.SavedGameFileExtension;
            Utils.Serializer.Binary.WriteToBinaryFile(filePath, this);
            //Utils.Serializer.Xml.WriteToXmlFile(filePath, this);
        }
	}
}