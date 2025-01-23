using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace übung_test_stringverarbeitung_IP_Adresse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int abbruch = 0;
            int iplaenge = 0;
            int oktet2test = 0;
            int oktet3test = 0;
            int oktet4test = 0;
            int fehler = 0;
            string menü = "";
            string ipadresse = "";
            string oktet2 = "";
            string oktet3 = "";
            string oktet4 = "";
            bool oktet1 = false;

            while (abbruch == 0)
            {

                Console.Clear();
                Console.WriteLine("IP-Adressenübung Nils Bröker 23.01.2025");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Prüft eine eingegebene IP Adresse nach folgenden Kreterien: Oktet1: 192  Oktet2: 168 & 169   Oktet3: 0-255   Oktet4: 100-200");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Menü");
                Console.WriteLine("---------------------");
                Console.WriteLine("a) IP eingeben");
                Console.WriteLine("b) IP überprüfen");
                Console.WriteLine("c) Programmende");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Bitte wählen sie ein Menüpunkt a,b oder c aus!");
                menü = Console.ReadLine();

                if (menü == "a")
                {
                    Console.Clear();
                    Console.WriteLine("IP eingeben");
                    Console.WriteLine("------------------");
                    Console.WriteLine("Prüft eine eingegebene IP Adresse nach folgenden Kreterien: Oktet1: 192  Oktet2: 168 & 169   Oktet3: 0-255   Oktet4: 100-200");
                    Console.WriteLine();
                    Console.WriteLine("Bitte geben sie eine IP Adresse mit 4 Oktetts ein z.B: 192.168.178.101");
                    Console.WriteLine();
                    ipadresse = Console.ReadLine();
                    iplaenge = ipadresse.Length;
                    if (iplaenge == 15)
                    {
                        Console.WriteLine("Eingabe valide   weiter mit beliebiger Taste");
                    }
                    else
                    {
                      Console.WriteLine("Falsche Eingabe!   weiter mit beliebiger Taste");
                    }
                }

                else if (menü == "b")
                {
                    fehler = 0;
                    Console.Clear();
                    Console.WriteLine("IP überprüfen");
                    Console.WriteLine("------------------");
                    Console.WriteLine();
                    Console.WriteLine("Prüft eine eingegebene IP Adresse nach folgenden Kreterien: Oktet1: 192  Oktet2: 168 & 169   Oktet3: 0-255   Oktet4: 100-200");
                    Console.WriteLine();

                    oktet1 = ipadresse.StartsWith("192");

                    if (oktet1 == true)
                    {
                        Console.WriteLine("Oktet 1: OK");
                    }
                    else
                    {
                        Console.WriteLine("Oktet 1: NOT OK");
                        fehler++;
                    }

                    oktet2 = ipadresse.Substring(4, 3);
                    oktet2test = String.Compare(oktet2, "168") + String.Compare(oktet2, "169");


                    if (oktet2test == 1 || oktet2test == -1)
                    {
                        Console.WriteLine("Oktet 2: OK");
                    }
                    else
                    {
                        Console.WriteLine("Oktet 2: NOT OK");
                        fehler++;
                    }

                    oktet3 = ipadresse.Substring(8, 3);
                    oktet3test = String.Compare(oktet3, "256") + String.Compare(oktet3, "-1");

                    if (oktet3test == 0)
                    {
                        Console.WriteLine("Oktet 3: OK");
                    }
                    else
                    {
                        Console.WriteLine("Oktet 3: NOT OK");
                        fehler++;
                    }

                    oktet4 = ipadresse.Substring(12,3);
                    oktet4test = String.Compare(oktet4, "201") + String.Compare(oktet4, "099");
    
                    if (oktet4test == 0)
                    {
                        Console.WriteLine("Oktet 4: OK");
                    }
                    else
                    {
                        Console.WriteLine("Oktet 4: NOT OK");
                        fehler++;
                    }

                    Console.WriteLine("Die überprüfte IP Adresse: {0} hat {1} fehler!", ipadresse, fehler);
                    Console.WriteLine();
                    Console.WriteLine("Weiter mit beliebiger Taste");

                }

                else if (menü == "c")
                {
                    Console.Clear();
                    Console.WriteLine("Programmende");
                    abbruch = 1;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("ungültige Eingabe zürück mit beliebiger Taste");
                    
                }

                Console.ReadLine();

            }

        }
    }
}
