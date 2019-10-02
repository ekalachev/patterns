using System;

namespace DesignPatterns.TemplateMethod
{
    class Chess : Game
    {
        public Chess() : base(2)
        {
        }

        protected override bool HaveWinner => turn == maxTurns;

        protected override int WinningPlayer => currentPlayer;

        protected override void Start()
        {
            Console.WriteLine($"Starting a game of chess with {numberOfPlayers} players.");
        }

        protected override void TakeTurn()
        {
            Console.WriteLine($"Turn {turn++} taken by player {currentPlayer}.");
            currentPlayer = (currentPlayer + 1) % numberOfPlayers;
        }

        private int turn = 1;
        private int maxTurns = 10;
    }
}
