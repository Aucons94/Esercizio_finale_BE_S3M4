using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Esercizio_finaleS3M4
{
   public partial class Dettaglio : System.Web.UI.Page
    {

        /*
          * Summary: Carica i dettagli del prodotto sulla pagina.
          * Parameters: L'evento di innesco è il caricamento della pagina
          * Return: 
        */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (int.TryParse(Request.QueryString["id"], out int productId))
                {
                    Prodotto prodotto = Database.GetProdottoById(productId);

                    if (prodotto != null)
                    {
                        NomeProdotto.Text = prodotto.Nome;
                        DescrizioneProdotto.Text = prodotto.Descrizione;
                        DescrizioneDettagliata.Text = prodotto.DescrizioneDettagliata;
                        Prezzo.Text = prodotto.Prezzo.ToString("0.00€");
                        ImgUrl.ImageUrl = prodotto.ImgUrl;
                    }
                }
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
            if (int.TryParse(Request.QueryString["id"], out int productId))
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