using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CandyHierarchy
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

    public class ChocolateSweet : Chocolate
    {
        public string Name = "Chocolate Sweet";
        public ChocolateSweet(int weight)
        {
            Weight = weight;
        }
    }
    
   
    public class MarmaladeSweets : Marmalade
    {
        public string Name = " Marmalade Sweet";
        public MarmaladeSweets(int weight)
        {
            Weight = weight;
        }
    }


    public class BiscuitSweets : Biscuit
    {
        public string Name = " Biscuit Sweet";
        public BiscuitSweets(int weight)
        {
            Weight = weight;
        }

    }
       
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            object[] Bags = new object[3];
            for (int i = 0; i < 3; i++)
            {
                var Chokoloko = new ChocolateSweet(r.Next(300));
                var Marmeladio = new MarmaladeSweets(r.Next(300));
                var Biscutio = new BiscuitSweets(r.Next(300));

                
                Sweets[] OneBag = new Sweets[3] { Chokoloko, Marmeladio, Biscutio };

                for (int k = 0; k < OneBag.Length; k++)
                {
                    for (int j = 1; j < OneBag.Length; j++)
                    {

                        Console.WriteLine(OneBag[j].Name);


                        if (OneBag[j - 1].Weight < OneBag[j].Weight)

                        (OneBag[j - 1], OneBag[j]) = (OneBag[j], OneBag[j - 1]);
                    }
                }

                for (int j  = 0; j  < OneBag.Length; j ++)
                {
                    if (OneBag[j].Weight == Chokoloko.Weight)
                    {
                        Console.WriteLine(Chokoloko.Name + $"{Chokoloko.Weight}");
                    }
                    else if (OneBag[j].Weight == Marmeladio.Weight)
                    {
                        Console.WriteLine(Marmeladio.Name + $"{Marmeladio.Weight}");
                    }
                    else
                    {
                        Console.WriteLine(Biscutio.Name + $"{Biscutio.Weight}");
                    }
                }
                Console.WriteLine("====================");
                Bags[i] = OneBag;

            }
        }
    }
}
