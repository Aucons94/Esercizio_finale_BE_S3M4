using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Esercizio_finaleS3M4
{
  
    public partial class Carrello
    {
        private Carrello carrello;

        // Lista dei prodotti presenti nel carrello.
        public List<Prodotto> Prodotti { get; } = new List<Prodotto>();

        /*
         * Summary: Permette di aggiungere un prodotto al carrello.
         * Parameters: Prodotto 
         * Return: La funzione non ritorna nulla
        */
        public void AggiungiProdotto(Prodotto prodotto)
        {Prodotti.Add(prodotto);}

        /*
         * Summary: Rimuove un prodotto dal carrello.
         * Parameters: Prodotto 
         * Return: La funzione non ritorna nulla
        */
        public void RimuoviProdotto(Prodotto prodotto)
        {Prodotti.Remove(prodotto);}

      
        /*
         * Summary: Calcola il totale del carrello sommando i prezzi di tutti i prodotti.
         * Parameters: Nessuno 
         * Return: La funzione ritorna il totale dei prezzi dei prodotti presenti nel carrello
        */
        public decimal CalcolaTotale()
        {return Prodotti.Sum(prodotto => prodotto.Prezzo);}

        /*
         * Summary: Svuota il carrello, rimuovendo tutti i prodotti.
         * Parameters: Nessuno 
         * Return: La funzione non ritorna nulla
        */
        public void SvuotaProdotti()
        { Prodotti.Clear();}
    }
}