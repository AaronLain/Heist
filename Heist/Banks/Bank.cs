using System;
using System.Collections.Generic;
using System.Text;

namespace Heist.Banks
{
    class Bank
    {
        public int BankDifficulty { get; set; }

        private readonly Random _random = new Random();

        public Bank(int diff)
        {
            BankDifficulty = diff;

            generateLuck();
        }

        public void generateLuck()
        {
            int rand = _random.Next(-10, 10);

            BankDifficulty += rand;
        }
    }
}
