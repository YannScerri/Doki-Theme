using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {   
                string userChoice;

                string[] waifus = new string[] { "Sayori", "Natsuki", "Yuri", "Monika" };


                Console.WriteLine("Voulez vous une Waifu ? \n" +
                                  "Alors laissez le hasard décider\n" +
                                  "Oui ou Non");

                userChoice = Console.ReadLine().ToUpper();

                Random r = new Random();
                switch (userChoice)
                {
                    case "OUI":
                        for (int i = 0; i < 1; i++)
                        {
                            Console.WriteLine("Voilà donc votre magnifique waifu :");
                            Console.WriteLine(waifus[r.Next(waifus.Length)]);
                        }
                        break;

                    case "NON":
                        Console.WriteLine("et bah mange tes morts");
                        break;

                    default:
                        Console.WriteLine("bah choisis non ?");
                        break;
                }
                Console.WriteLine("");

                Console.ReadLine();
            }while (true);
        }
    }
}
