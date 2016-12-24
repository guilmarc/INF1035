using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Core.Model
{
    /// <summary>
    /// Classe principale de gestion d'une partie
    /// </summary>
    [Serializable]
    public class Game
	{

        public static event EventHandler GameCompleted;

	    public string Name { get; set; } = null;
	    public DateTime StartTime { get; set; } = DateTime.Now;

        /// <summary>
        /// Heure de fin de la partie
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Association d'une joueur humain
        /// </summary>
        public Player HumanPlayer { get; set; }

	    
        /// <summary>
        /// Constructeur vide nécessaire à la sérialisation
        /// </summary>
	    public Game() {}

        /// <summary>
        /// Créateur servant à générer une partie simulée avec un nombre illimité d'adversaires
        /// </summary>
        /// <param name="opponentsCount"></param>
	    public Game(int opponentsCount = 2)
	    {
	        //Génération d'une Game de simulation
            //TODO: Sera complété après la remise car hors des demandes de ce travail pratique
	    }

        /// <summary>
        /// Constructeur obligtoire pour une partie avec un humain
        /// </summary>
        /// <param name="HumanPlayer"></param>
        /// <param name="opponentsCount"></param>
	    public Game(Player HumanPlayer, int opponentsCount = 1)
	    {
	        this.HumanPlayer = HumanPlayer;
	    }

        /// <summary>
        /// Exécution de la partie.  Cette méthode ca plus loin que les exigences du travail pratique
        /// Elle sera doc complétée après la remise, le code étant fonctionnel dans le UI
        /// </summary>
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

        /// <summary>
        /// Sauvegarde la partie avec le nom par défaut
        /// </summary>
		public void Save()
		{
		    Save(this.Name ?? StartTime.ToString("yyyyMMddHHmmss"));
		}

        /// <summary>
        /// Sauvegarde la partie dans un fichier binaire
        /// </summary>
        /// <param name="gameName">Nom de la partie</param>
        public void Save(string gameName)
        {
            this.Name = gameName;
            var filePath = Constants.SavedGamePath + this.Name + Constants.SavedGameFileExtension;
            Utils.Serializer.Binary.WriteToBinaryFile(filePath, this);
        }
	}
}