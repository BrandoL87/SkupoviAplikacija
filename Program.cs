

using Skupovi;

namespace SkupoviAplikacija
{
     class Program
    {
        static void Main(string[] args)
        {
/*
            Skup a = new Skup();
            a.niz = new int[] { 3, 5, 6, 7, 9, 10 };

            Skup b = new Skup();
            b.niz = new int[] { 8, 9, 10, 11 };

            Skup c = a.Presek(b);
            Skup d = a.Unija(b);
            Skup e = a.Razlika(b);

            foreach(int i in c.niz)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            foreach(var i in d.niz)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            foreach(var i in e.niz)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(c.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(e.ToString());

            Console.WriteLine();

            //Skup n = new Skup();
           // n.ucitajSkup();

            
*/
            Console.WriteLine("**** Dobrodosli u aplikaciju Skupovi *** \n");


            while (true)
            {
                Console.WriteLine("\n Unesite odgovarajucu opciju.");
                Console.WriteLine("Unesite '1' za presek skupova.");
                Console.WriteLine("Unesite '2' za uniju skupova .");
                Console.WriteLine("Unesite '3' za razliku skupova.");
                Console.WriteLine("Unesite '4' za duzinu skupova.");
                Console.WriteLine("Unesite '.' za kraj.");
               

                //Korisnik bira operaciju koju zeli da izvrsava
                string? opcija = Console.ReadLine();

                //Korisnik je izabrao da napusti aplikaciju
                if (opcija == ".")
                    break;

                

                switch (opcija)
                {
                    case("1"): {
                            //unosimo elemente dva skupa i odredjujemo njihov presek
                            
                            Console.WriteLine("Unesite elemente skupa A:");
                            Skup A = new Skup();
                            A.ucitajSkup();
                            Console.WriteLine("Unesite elemente skupa B:");
                            Skup B = new Skup();
                            B.ucitajSkup();
                            Console.WriteLine($"A = {A.ToString()}");
                            Console.WriteLine($"B = {B.ToString()}");
                            Console.WriteLine($"Presek skupova je: {A.Presek(B).ToString()}");

                            break;
                        }
                    case ("2"):
                        {
                            //unosimo elemente dva skupa i odredjujemo njihovu uniju
                            
                            Console.WriteLine("Unesite elemente skupa A:");
                            Skup A = new Skup();
                            A.ucitajSkup();
                            Console.WriteLine("Unesite elemente skupa B:");
                            Skup B = new Skup();
                            B.ucitajSkup();
                            Console.WriteLine($"A = {A.ToString()}");
                            Console.WriteLine($"B = {B.ToString()}");
                            Console.WriteLine($"Unija skupova je: {A.Unija(B).ToString()}");

                            break;
                        }

                    case ("3"):
                        {
                            //unosimo elemente dva skupa i odredjujemo njihovu razliku
                            
                            Console.WriteLine("Unesite elemente skupa A:");
                            Skup A = new Skup();
                            A.ucitajSkup();
                            Console.WriteLine("Unesite elemente skupa B:");
                            Skup B = new Skup();
                            B.ucitajSkup();
                            Console.WriteLine($"A = {A.ToString()}");
                            Console.WriteLine($"B = {B.ToString()}");
                            Console.WriteLine($" Razlika skupova je: {A.Razlika(B).ToString()}");

                            break;
                        }
                    case ("4"):
                        {
                            //odredjujemo broj elemenata skupa
                           
                            Console.WriteLine("Unesite elemente skupa A:");
                            Skup A = new Skup();
                            A.ucitajSkup();
                            Console.WriteLine("Unesite elemente skupa B:");
                            Skup B = new Skup();
                            B.ucitajSkup();
                            Console.WriteLine($"Duzina skupa A je: {A.duzinaSkupa()}");
                            Console.WriteLine($"Duzina skupa B je: {B.duzinaSkupa()}");
                            break;
                        }

                    default:
                        {
                            //Korisnik nije ispravno uneo opciju iz menija
                            Console.WriteLine("\n Niste uneli odgovarajucu opciju!!!");
                            break;
                        }


                }
            }

        }
    }
}