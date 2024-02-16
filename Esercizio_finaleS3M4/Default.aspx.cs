using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Esercizio_finaleS3M4
{
    public partial class _Default : System.Web.UI.Page
    {

        /*
           * Summary: Carica la pagina e popola il repeater dei prodotti se non è una postback.
           * Parameters: L'evento di innesco è il caricamento della pagina
           * Return: Nessun valore restituito.
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Prodotto> prodotti = Database.GetProdotti();
                productRepeater.DataSource = prodotti;
                productRepeater.DataBind();
            }
        }

        /*
         * Summary: Gestisce l'aggiunta del prodotto al carrello.
         * Parameters: L'evento di innesco è il click sul bottone Aggiungi al Carrello
         * Return: Nessun valore restituito.
         * Extra: aggiunto Pop-up per segnalare l'aggiunta al carrello
      */
        protected void AddCarrello_Click(object sender, EventArgs e)
        {           
            if (sender is Button button)
            {
                if (int.TryParse(button.CommandArgument, out int productId))
                {
                    Prodotto prodotto = Database.GetProdottoById(productId);

                    if (prodotto != null)
                    {
                        Carrello carrello = Session["Carrello"] as Carrello ?? new Carrello();
                        prodotto.IdProdotto = productId;
                        carrello.AggiungiProdotto(prodotto);
                        Session["Carrello"] = carrello;
                        ((SiteMaster)this.Master).AggiornaNumeroElementiCarrello();
                        PopupLiteral.Text = "<script>alert('Prodotto aggiunto al carrello!');</script>";
                    }
                }
            }
        }
    }
}