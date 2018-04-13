using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_pension {
    class Program {
        static void Main(string[] args) {

            //      DEFINING DATA
            const int pensionsAlder = 65;   // Age of pension. This makes it easier to edit in case of changes
            int alder = 0;  // This will become the person's age once it's enterd
            string namn = "inget namn än";  // This will become the persons name once it's enterd

            //      INTRO
            Console.WriteLine("=== Välkommen ===");
            Console.WriteLine("Här kan du få reda på hur många år som är kvar tills du kan gå i pension.");
            Console.WriteLine();


            //      INPUT
            Console.WriteLine("Först behöver vi erat namn. När ni har skrivit det nedan, tryck på [ENTER] för att bekräfta.");
            Console.Write("Föramn och efternamn: ");
            namn = Console.ReadLine();   // Saves the user's name to be used later
            Console.WriteLine();

                Console.WriteLine("Nu behöver vi veta eran ålder. När ni har skrivit det nedan, tryck på [ENTER] för att bekräfta.");
            do {
                Console.Write("Ålder: ");
                try {
                    alder = Convert.ToInt32(Console.ReadLine());    // Converts and saves the user's age to an integer
                }
                catch(FormatException) {
                    Console.WriteLine("Var vänlig och skriv endast siffror (0-9) när ni anger eran ålder.");
                }
            } while(alder == 0);

            Console.WriteLine();


            //      OUTPUT
            if (alder >= 65) {  // 65years and older
                Console.WriteLine("Tack så mycket {0}. Ni kan gå i pension nu.", namn);
            }
            else if (alder >= 55 && alder < 65) {   // 55years and older up to 65
                Console.WriteLine("Tack så mycket {0}. Ni går snart i pension då det är {1}år kvar.", namn, pensionsAlder - alder);
            }
            else if (alder <= 20) {     // Younger than 20
                Console.WriteLine("Tack så mycket {0}. Ni har långt kvar tills ni går i pension då det är {1}år kvar.", namn, pensionsAlder - alder);
            }
            else {  // Between 21 and 54years old
                Console.WriteLine("Tack så mycket {0}. Ni har {1}år kvar tills pension.", namn, pensionsAlder - alder);
            }

            Console.ReadLine();
        }
    }
}
