using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Bejegyzes b = new Bejegyzes("" , "");
            Console.WriteLine("Megváltozott a kiíratás");
            b.setTartalom(Console.ReadLine());
            Console.WriteLine(b.kiir());

            List<Bejegyzes>bejegyzesek = new List<Bejegyzes>();
            bejegyzesek.Add(new Bejegyzes("sajt", "toltottkaposzta"));
            bejegyzesek.Add(new Bejegyzes("Béla", "trabant"));
            int darab;
            Console.WriteLine("Kérem adja meg, hogy hány bejegyzés legyen: ");

            while(!(int.TryParse(Console.ReadLine(),out darab)))
            {
                Console.WriteLine("Nem számot adtál meg.");
            }
           for(int i = 1; i < darab; i++)
            {

                Console.WriteLine("");
                bejegyzesek.Add(new Bejegyzes(Console.ReadLine(), Console.ReadLine()));
            }
            int szam = 20 * bejegyzesek.Count;
            Random r = new Random();
            foreach(var i in bejegyzesek)
            {
                i.setLikeok(r.Next(1, szam));
            }
           
            foreach(var i in bejegyzesek)
            {
                Console.WriteLine(i.kiir());
            }

            int max = 0;
            foreach (var i in bejegyzesek)
            {
                if(i.getLikeok() > max)
                {
                    max = i.getLikeok();
                }
            }

          
            Console.WriteLine("Like-ok száma: " + max);
            Boolean letezikolyan = false;
            foreach(var i in bejegyzesek)
            {
                if(i.getLikeok() > 35)
                {
                    letezikolyan = true;
                }
            }
            if (letezikolyan)
            {
                Console.WriteLine("Létezik 35-nél nagyobb számú like-ot kapott bejegyzés.");

            }
            else {
                Console.WriteLine("Nincs 35-nél nagyobb számú like-ot kapott bejegyzés.");
            }
            int tizenotnelkevesebb = 0;
            foreach(var i in bejegyzesek){
                if(i.getLikeok() < 15)
                {
                    tizenotnelkevesebb++;
                }
            }
            Console.WriteLine(tizenotnelkevesebb + " darab 15 like-nál kevesebbet kapó bejegyzés van. ");

            bejegyzesek.Sort(delegate (Bejegyzes x, Bejegyzes y)
            {
               return y.getLikeok().CompareTo(x.getLikeok());
            });

            Console.WriteLine("Lista elemek csökkenőbe");
            foreach (var i in bejegyzesek)
            {
                Console.WriteLine(i.kiir());
            }

            Console.ReadKey();
        }
    }
}
