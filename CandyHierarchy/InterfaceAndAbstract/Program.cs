using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfaceAndAbstract
{
    class Program
    {
        public interface SweetsInterface
        {
            void ShowName();
        }

        public interface WeightInterface
        {
            void ShowWeight();
        }
        public interface TypeInterface
        {
            void ShowType();
        }


        public abstract class Sweets : SweetsInterface, WeightInterface, TypeInterface
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public string Type { get; set; }


            public void ShowType()
            {
                Console.WriteLine(Type);
            }
            public void ShowName()
            {
                Console.WriteLine(Name);
            }

            public void ShowWeight()
            {
                Console.WriteLine(Weight);
            }

        }

        public abstract class Chocolate : Sweets
        {
            public string Type = "Chocolate";


        }

        public abstract class Marmalade : Sweets
        {
            public string Type = "Marmalade";

        }

        public abstract class Biscuit : Sweets
        {
            public string Type = "Biscuit";

        }
    }
}
