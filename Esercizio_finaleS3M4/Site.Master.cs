using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Esercizio_finaleS3M4
{
    public partial class SiteMaster : MasterPage
    {
        /*
         * Summary: Avvia la funzione AggiornaNumeroElementiCarrello
         * Parameters: L'evento di innesco è il caricamento della pagina
         * Return: La funzione non ritorna nulla
        */
        protected void Page_Load(object sender, EventArgs e)
        {
            AggiornaNumeroElementiCarrello();
        }

        /*
         * Summary: Aggiorna il numero interno allo span numeroElementi che si trova in Site.Master
         * Parameters: L'evento di innesco sono le altre funzioni che aggiungono o rimuovono elementi dal carrello
         * Return: La funzione non ritorna nulla
        */
        public void AggiornaNumeroElementiCarrello()
        {
            int numeroElementiCarrello = 0;
            Carrello carrello = Session["Carrello"] as Carrello;
            if (carrello != null)
            {
                List<Prodotto> listaProdotti = carrello.Prodotti;
                if (listaProdotti != null)
                {
                    numeroElementiCarrello = listaProdotti.Count;
                }
            }
            numeroElementi.InnerText = numeroElementiCarrello.ToString();
        }
    }
}