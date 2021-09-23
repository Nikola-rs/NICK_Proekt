using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICK_Proekt
{
    public class RandomNumber
    {
        public readonly Random _random = new Random();
        public int random_number { get; set; }
        public RandomNumber()
        {
            random_number = _random.Next(1, 4);
        }

    }
}
