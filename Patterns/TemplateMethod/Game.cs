using System;

namespace DesignPatterns.TemplateMethod
{
    abstract class Game
    {
        protected int currentPlayer;
        protected readonly int numberOfPlayers;

        public Game(int numberOfPlayers)
        {
            this.numberOfPlayers = numberOfPlayers;
        }

        protected abstract void Start();
        protected abstract void TakeTurn();
        protected abstract bool HaveWinner { get; }
        protected abstract int WinningPlayer { get; }

        // Template method
        public void Run()
        {
            Start();

            while (!HaveWinner)
            {
                TakeTurn();
            }

            Console.WriteLine($"Player {WinningPlayer} wins.");
        }
    }


}
