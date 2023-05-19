using System;
using System.Collections.Generic;


namespace SamePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            ISet<Player> setPlayer = new HashSet<Player>();~

            setOfPlayers.Add(new Player() { 
                Name = "Ana", Type = PlayerType.Tank });
            setOfPlayers.Add(new Player() { 
                Name = "Paulo", Type = PlayerType.Slayer });
            setOfPlayers.Add(new Player() { 
                Name = "Ana", Type = PlayerType.Tank });
        
            foreach(Player p in setPlayer)
            {
                Console.WriteLine($"{p.Name} is a {p.Type}.");
            }
        }
    }
}
