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

        public string ReturnNome()
        {
            return nome;
        }

        public int ReturnPrezzo()
        {
            return prezzo;
        }
    }


    //prodotto con builder senza paramentri..?
    public class Prodotto2
    {
        private string nome;
        private int prezzo;

        public Prodotto2()
        {
            string nome = "test";
            int prezzo = 44;

            this.nome = nome;
            this.prezzo = prezzo;
        }

        public string ReturnNome()
        {
            return nome;
        }

        public int ReturnPrezzo()
        {
            return prezzo;
        }
    }
}
