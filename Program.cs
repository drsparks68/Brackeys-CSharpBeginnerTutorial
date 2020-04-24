using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Brackeys
{
    class MainClass
    {
        interface IItem
        {
            string name { get; set; }
            int goldValue { get; set; }

            void Equip();
            void Sell();
        }

        class Sword : IItem
        {
            public string name { get; set; }
            public int goldValue { get; set; }

            public Sword (string _name)
            {
                name = _name;
                goldValue = 100;
            }

            public void Equip()
            {
                Console.WriteLine(name + " is equipped.");
            }

            public void Sell()
            {
                Console.WriteLine(name + " sold for an amazing " + goldValue + " doll-hairs.");
            }

        }
        public static void Main(string[] args)
        {
            Sword sword = new Sword("Sword of destiny");
            sword.Equip();
            sword.Sell();
            Console.ReadKey();
        }
    }
}
