using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_pension {
    class Program {
        static void Main(string[] args) {

            const int pensionsAlder = 65;   // Age of pension. This makes it easier to edit in case of any changes

            //      Intro
            Console.WriteLine("=== Välkommen ===");
            Console.WriteLine("Här kan du få reda på hur många år som är kvar tills du kan gå i pension.");
            Console.WriteLine();


            //      Input
            Console.WriteLine("Först behöver vi erat namn. När ni har skrivit det nedan, tryck på [ENTER] för att bekräfta.");
            Console.Write("Föramn och efternamn: ");
            string namn = Console.ReadLine();   // Saves the user's name to be used later
            Console.WriteLine();

            Console.WriteLine("Nu behöver vi veta eran ålder. När ni har skrivit det nedan, tryck på [ENTER] för att bekräfta.");
            Console.Write("Ålder: ");
            int alder = Convert.ToInt32(Console.ReadLine());    // Converts and saves the user's age to an integer
            Console.WriteLine();


            //      Output
            if (alder >= 65) {  // 65years and older.
                Console.WriteLine("Tack så mycket {0}. Ni kan gå i pension nu.", namn);
            }
            else if (alder >= 55 && alder < 65) {   // 55years and older up to 65
                Console.WriteLine("Tack så mycket {0}. Ni går snart i pension då det är {1}år kvar.", namn, pensionsAlder - alder);
            }
            else if (alder <= 20) {     // Younger than 20.
                Console.WriteLine("Tack så mycket {0}. Ni har långt kvar tills ni går i pension då det är {1}år kvar.", namn, pensionsAlder - alder);
            }
            else {  // Between 21 and 54years old.
                Console.WriteLine("Tack så mycket {0}. Ni har {1}år kvar tills pension.", namn, pensionsAlder - alder);
            }

            Console.ReadLine();     // To prevent the console to close after the program is done. 
        }
    }
}
