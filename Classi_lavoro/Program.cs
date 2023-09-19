using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classi_lavoro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("inserisci prezzo: ");
            int prezzo = int.Parse(Console.ReadLine());


           
            Prodotto oggetto = new Prodotto(nome, prezzo);
            Console.WriteLine("Nome prodotto: " + oggetto.ReturnNome() + "\nPrezzo prodotto: " + oggetto.ReturnPrezzo());


            Console.WriteLine("\n\nSenza parametri:\n");

            Prodotto oggetto1 = new Prodotto();
            Console.WriteLine("Nome prodotto: " + oggetto1.ReturnNome() + "\nPrezzo prodotto: " + oggetto1.ReturnPrezzo());
        }

    }

    //prodotto con builder con paramentri
    public class Prodotto
    {
        private string nome;
        private int prezzo;

        public Prodotto(string nome, int prezzo)
        {
            this.nome = nome;
            this.prezzo = prezzo;
        }

        public Prodotto()
        {
            this.nome = "none";
            this.prezzo = 0;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public int GetPrezzo()
        {
            return prezzo;
        }

        public void SetPrezzo(int prezzo)
        {
            this.prezzo = prezzo;
        }
    }
}
