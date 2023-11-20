using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioClassi1
{
    internal class Program
    {
        // creo la nuova classe prodotto
        public class Prodotto
        {
            // attributi

            protected string _nome;
            protected double _prezzo;

            // COSTRUTTORI

            // costruttore senza parametri
            public Prodotto()
            {
                _prezzo = 2;
                _nome = "pupazzo";
            }

            // funzione che legge il nome ed il prezzo
            public void Stampa()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nCLASSE SENZA PARAMETRI");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Il nome del prodotto è: {_nome}, il prezzo è {_prezzo.ToString()}");
            }
        }

        public class Prodotto2
        {
            // attributi

            protected string _nome;
            protected double _prezzo;

            // COSTRUTTORI

            // costruttore con parametri
            public Prodotto2(string nome, double prezzo)
            {
                _prezzo = prezzo;
                _nome = nome;
            }

            // funzione che legge il nome ed il prezzo
            public void Stampa2()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nCLASSE CON PARAMETRI");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Il nome del prodotto è: {_nome}, il prezzo è {_prezzo.ToString()}");
            }
        }
        static void Main(string[] args)
        {
            // nome prodotto

            Console.WriteLine("Inserisci il nome del prodotto");
            string nome = Console.ReadLine();

            // prezzo prodotto

            Console.WriteLine("Inserisci il prezzo del prodotto");
            double prezzo = Convert.ToInt16(Console.ReadLine());

            Prodotto p = new Prodotto();
            p.Stampa();

            Prodotto2 p2 = new Prodotto2(nome, prezzo);
            p2.Stampa2();
        }
    }
}
