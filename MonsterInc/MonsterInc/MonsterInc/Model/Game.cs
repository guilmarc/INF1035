using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Core.Model
{
	public class Game
	{
		public string Name { get; set; }
	    public DateTime StartTime { get; private set; } = DateTime.Now;
        public DateTime EndTime { get; private set; }

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

		public List<Combat> Combats { get; set; }

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
	        var combat = new Combat(this, Universe.Difficulties[0]);
	        combat.Run();
	    }

		public void Save()
		{
			
		}

		public void Load()
		{
			
		}
	}
}
