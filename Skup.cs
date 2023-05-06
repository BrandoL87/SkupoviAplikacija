using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skupovi
{
    public class Skup
    {
       //niz je tipa int? da bi omogucili i null vrednosti, jer bi u
       //suprotnom podrayumevane vrednosti na preostalim mestima u nizu bile 0.
        public int?[] niz = new int?[100] ;

        //prazan konstruktor
        public Skup()
        {

        }
        //konstruktor sa parametrom 
        public Skup(int?[] niz)
        {
            this.niz = niz;
        }
        //ucitavanje elemenata skupa preko ulaza, sve dok korisnik 
        //ne unese neki drugi karakter
        public void ucitajSkup()
        {
            
            Console.WriteLine($"Za prekid unosa unesite bilo koji karakter.");
            int m;
            int i = 0;
            bool uslov = true;

            while(uslov)
            {
               string? s = Console.ReadLine();
                bool condition = int.TryParse(s, out m);

                if(condition)
                {
                    niz[i] = m;
                    i++;
                }
                else
                {
                    uslov = false;
                }
            }

            this.niz = niz.Distinct().ToArray() ;
        }
        

        
        //implementacija preseka skupova preko LINQ-a
        //biramo samo one elemente koji se javljaju u oba skupa i redjamo ih po velicini
        //koristimo konstruktor sa parametrom za izlaznu vrednost
        public Skup Presek(Skup B)
        {
            return new Skup(niz.Where(i => B.niz.Contains(i)).OrderBy(i => i).ToArray());
        }
        //unija dva skupa, elementi su poredjani po velicini
        public Skup Unija(Skup B) {
            return new Skup(niz.Union(B.niz).OrderBy(i => i).ToArray());
        }
        //razlika dva skupa
        public Skup Razlika(Skup B)
        {
            return  new Skup(niz.Where(i => !B.niz.Contains(i)).OrderBy(i => i).ToArray());
        }
        //ispis rezultujuceg skupa u odgovarajucem formatu, koristeci matematicki zapis 
        //za skupove
        public override string ToString()
        {
            string s = "{";
            foreach (var i in this.niz)
            {
                if(i!= null)
                s += i + ",";
            }

            s = s.Remove(s.Length - 1);
            s += "}";
            return s;
        }
        //duzinu skupa odredjujemo prebrojavajuci ne-null vrednosti niza
        public int duzinaSkupa()
        {
            return niz.Count(i => i!= null);
        }
    }
}
