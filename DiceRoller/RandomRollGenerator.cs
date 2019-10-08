using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiceRoller
{
    public class RandomRollGenerator
    {
        public int Roll(Die die)
        {
            var random = new Random();

            var roll = random.Next(die.AmountOfSides + 1);

            return roll;
        }

    }
}