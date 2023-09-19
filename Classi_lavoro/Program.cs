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
            //prendo nome e prezzo dall'utente
            Console.WriteLine("inserisci nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("inserisci prezzo: ");
            int prezzo = int.Parse(Console.ReadLine());


           
            //stampo gli oggetti con e senza paramentri
            Prodotto oggetto = new Prodotto(nome, prezzo);
            Console.WriteLine("Nome prodotto: " + oggetto.GetNome() + "\nPrezzo prodotto: " + oggetto.GetPrezzo());


            Console.WriteLine("\n\nSenza parametri:\n");

            Prodotto oggetto1 = new Prodotto();
            Console.WriteLine("Nome prodotto: " + oggetto1.GetNome() + "\nPrezzo prodotto: " + oggetto1.GetPrezzo());
        }

    }

    //prodotto con builder con paramentri
    public class Prodotto
    {
        private string nome;
        private int prezzo;

        public Prodotto(string nome, int prezzo)
        {
            if(prezzo > 0)
            {
                this.prezzo= prezzo;
            }
            else
            {
                this.prezzo = 0;
            }

            this.nome = nome;

            
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
            if (prezzo > 0)
            {
                this.prezzo = prezzo;
            }
            else
            {
                this.prezzo = 0;
            }
        }
    }
}
