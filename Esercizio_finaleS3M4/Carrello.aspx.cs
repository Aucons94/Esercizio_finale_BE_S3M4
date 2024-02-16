using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Esercizio_finaleS3M4
{
    public partial class Carrello : System.Web.UI.Page
    {
        /*
         * Summary: Carica la pagina e popola il carrello con i prodotti, se non è una postback.
         * Parameters: L'evento di innesco è il caricamento della pagina
         * Return: La funzione non ritorna nulla
        */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                carrello = Session["Carrello"] as Carrello;

                // Se il carrello esiste, popola il repeater dei prodotti nel carrello

                if (carrello != null)
                {
                    CarrelloRepeater.DataSource = carrello.Prodotti;
                    CarrelloRepeater.DataBind();
                    TotaleLabel.Text = carrello.CalcolaTotale().ToString("0.00");
                }
            }
        }

        /*
         * Summary: Aggiorna il repeater dei prodotti e il totale del carrello
         * Parameters: Il carrello
         * Return: La funzione non ritorna nulla
        */
        private void AggiornaCarrello(Carrello carrello)
        {
            CarrelloRepeater.DataSource = carrello.Prodotti;
            CarrelloRepeater.DataBind();
            TotaleLabel.Text = carrello.CalcolaTotale().ToString("0.00");
            Session["Carrello"] = carrello;
            ((SiteMaster)this.Master).AggiornaNumeroElementiCarrello();
        }

        /*
         * Summary: Svuota completamente il carrello
         * Parameters: L'evento di innesco è il click sul bottone svuota carrello
         * Return: La funzione non ritorna nulla
        */
        protected void SvuotaCarrello_Click(object sender, EventArgs e)
        {
            Session["Carrello"] = null;
            ((SiteMaster)this.Master).AggiornaNumeroElementiCarrello();
            Response.Redirect("Carrello.aspx");
        }
        /*
         * Summary: Gestisce l'eliminazione di un prodotto dal carrello
         * Parameters: L'evento di innesco è il click sul bottone Rimuovi 
         * Return: La funzione non ritorna nulla
        */
        protected void EliminaProdotto(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                int productIdToRemove = Convert.ToInt32(e.CommandArgument);
                Carrello carrello = Session["Carrello"] as Carrello;

                // Se il carrello esiste, cerca il prodotto da rimuovere 

                if (carrello != null)
                {
                    Prodotto prodottoDaRimuovere = carrello.Prodotti.FirstOrDefault(p => p.IdProdotto == productIdToRemove);

                    if (prodottoDaRimuovere != null)
                    {
                        carrello.RimuoviProdotto(prodottoDaRimuovere);
                        AggiornaCarrello(carrello);
                    }
                }
            }
        }
    }
}