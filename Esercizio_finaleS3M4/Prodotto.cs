using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Esercizio_finaleS3M4
{
    public class Prodotto
    {
        public int IdProdotto { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string DescrizioneDettagliata { get; set; }
        public decimal Prezzo { get; set; }
        public string ImgUrl { get; set; }
    }

    public static class Database
    {
        /*
         * Summary: Crea una lista di prodotti che poi posso usare nelle varie pagine tramite ID
         * Parameters: Nessuno
         * Return: Restituisce una lista di prodotti
        */
        public static List<Prodotto> GetProdotti()
        {
            List<Prodotto> prodotti = new List<Prodotto>
            {
                new Prodotto
                {
                    IdProdotto = 1,
                    Nome = "Oral-B Spazzolino Elettrico",
                    Descrizione = "Crossacrtion Spazzolino Elettrico e Dentifricio Gengive e Smalto Pro-Repair Classico, la Scelta dei Dentisti",
                    DescrizioneDettagliata = "Prova lo spazzolino elettrico SMART 4 4500 di Oral-B, la marca ideatrice dei primi spazzolini ricaricabili connessi; l'elegante manico nero dello spazzolino elettrico SMART 4 4500 perfezionera le tue abitudini di spazzolamento; si collega facilmente all'app Oral-B sul tuo smartphone per guidarti con suggerimenti in tempo reale e consentirti di spazzolare al meglio i tuoi denti; perfeziona la tua routine di igiene orale; la testina rotonda di Oral-B pensera al resto; rimuove fino al 100% di placca in piu rispetto ad uno spazzolino manuale tradizionale, per delle gengive piu sane. Il dentifricio oral-b professional gengive smalto pro-repair classico riduce le irritazioni e aiuta a riparare lo smalto in sole 2 settimane; la sua straordinaria tecnologia activrepair neutralizza i batteri nocivi riducendo le irritazioni; inoltre, ripristina i minerali dello smalto e protegge i denti dall'erosione causata dagli acidi.",
                    Prezzo = 49.99m,
                    ImgUrl = "https://m.media-amazon.com/images/I/81-0ulD+6GL._AC_SX522_.jpg"
                },
                new Prodotto
                {
                    IdProdotto = 2,
                    Nome = "Mielle - Olio lisciante e rinforzante per capelli",
                    Descrizione = "Olio lisciante e rinforzante per capelli, al rosmarino e menta, 59 ml",
                    DescrizioneDettagliata = "L'olio rinforzante per capelli e cuoio capelluto di Mielle Rosmarino è una formula intensiva e ricca di sostanze nutritive pensata per aiutarti a risolvere tutte le tue preoccupazioni sui capelli. Dal supporto per la conservazione della lunghezza e nutriente dei follicoli piliferi fino a lisciare le doppie punte e prevenire il cuoio capelluto secco, questo olio per capelli biologico utilizza ingredienti naturali e oli essenziali per fornire la cura che i capelli meritano. Questa formula è fatta per essere versatile!\r\n\r\n",
                    Prezzo = 19.00m,
                    ImgUrl = "https://m.media-amazon.com/images/I/41CnKN8QpqL._AC_SX522_.jpg"
                },
                new Prodotto
                {
                    IdProdotto = 3,
                    Nome = "EA SPORTS FC 24 Standard Edition",
                    Descrizione = "Xbox One / Xbox Series X | Videogiochi | Italiano1",
                    DescrizioneDettagliata = "EA SPORTS FC 24 è la era del gioco; oltre 19.000 giocatori con licenza piena, più di 700 squadre e oltre 30 campionati nell'esperienza calcistica autentica.\r\n\r\n\r\nVivi un'esperienza immersiva con tre tecnologie ottima che offrono in ogni partita un realismo ottimo: HyperMotionV*, stili di gioco ottimizzati da Opta e un motore Frostbite migliorato. HyperMotionV rispecchia l'azione autentica del calcio tramite dati volumetrici provenienti da oltre 180 partite professionistiche maschili e femminili, offrendo così un movimento di gioco che riflette in maniera accurata l'azione sul campo del mondo reale. Gli stili di gioco offrono agli atleti una ottima dimensione: i dati di Opta e di altre fonti vengono tradotti in abilità distintive che esaltano il realismo e l'individualità di ogni giocatore. Il motore Frostbite migliorato ci restituisce il gioco con un livello di dettaglio realistico, offrendo così una ottima immersione in ogni partita.\r\n\r\n\r\nMigliora i tuoi giocatori e fai crescere leggende nel tuo club con le Evoluzioni di Ultimate Team; inoltre, accogli in campo le calciatrici e crea il tuo undici da sogno. Scrivi la tua storia nella Carriera tecnico e giocatore, e scendi in campo con i tuoi amici in Club e VOLTA FOOTBALL grazie alle funzionalità cross-play.\r\n\r\n\r\nEA SPORTS FC 24 è il capitolo di un calcio ottimo.\r\n\r\n\r\n*La tecnologia HyperMotionV è disponibile solo per le versioni PlayStation 5, Xbox Series X|S e PC.",
                    Prezzo = 38.04m,
                    ImgUrl = "https://m.media-amazon.com/images/I/71FQFTfIcDL._AC_SX425_.jpg"
                },
                new Prodotto
                {
                    IdProdotto = 4,
                    Nome = "2001 odissea nello spazio",
                    Descrizione = "Copertina flessibile – 24 luglio 2017",
                    DescrizioneDettagliata = "Quando un enigmatico monolite viene trovato sotto la superfìcie lunare, gli scienziati non immaginano che quell'antico e straordinario manufatto abbia più di tre milioni di anni né che, una volta riportato alla luce, cominciasse a inviare un potente segnale indirizzato verso l'orbita di Saturno. Che cos'è veramente quel monolite? A chi è rivolto quel segnale? Per scoprirlo, la nave spaziale Discovery parte alla volta di Giapeto, satellite di Saturno. I membri dell 'equipaggio, scelti tra i migliori cosmonauti, sono assistiti nella loro missione da HAL 9000, cervello e sistema nervoso dell'astronave, un computer potentissimo capace di riprodurre i meccanismi della mente e dotato di una propria coscienza. Una macchina perfetta, fin troppo umana, tanto da essere soggetta a nevrosi e impulsi omicidi. Starà ai membri dell'equipaggio far sì che HAL 9000 non li coinvolga nella sua follia digitale: in gioco c'è la possibilità di entrare in contatto con entità sconosciute e insondabili, a cui il monolite appartiene e che potrebbero essere all'origine della civiltà stessa.",
                    Prezzo = 9.40m,
                    ImgUrl = "https://m.media-amazon.com/images/I/81mXmWlFVGL._SY466_.jpg"
                },
                new Prodotto
                {
                    IdProdotto = 5,
                    Nome = "Amazon Basics - Sedia da ufficio",
                    Descrizione = "Sedia da ufficio in ecopelle, 58 x 58 x 103 cm, nera",
                    DescrizioneDettagliata = "Dimensioni: 103 x 45 x 58 cm (altezza x larghezza x profondità). Altezza della seduta: 40-50 cm\r\nMateriale: sedile leggermente imbottito in realistica ecopelle vintage di un meraviglioso nero e cuciture orizzontali. Base mobile in metallo verniciato a polvere nero con 5 rotelle con freno\r\nSedile con funzione girevole e regolabile in altezza con leva manuale di sollevamento a gas\r\nDesign moderno ed elegante perfetto per un uso ricreativo\r\nRichiesto montaggio minimo",
                    Prezzo = 116.75m,
                    ImgUrl = "https://m.media-amazon.com/images/I/61MpwPzBN3L._AC_SX679_.jpg"
                },
                new Prodotto
                {
                    IdProdotto = 6,
                    Nome = "Echo Pop",
                    Descrizione = "Altoparlante Bluetooth intelligente con Alexa, compatto e dal suono potente | Antracite\r\n",
                    DescrizioneDettagliata = "TI PRESENTIAMO ECHO POP: questo altoparlante intelligente Bluetooth con Alexa, dalle dimensioni compatte, offre un suono ricco ed è ideale per stanze da letto e spazi ridotti. Abbastanza piccolo da stare bene ovunque, ma così potente da non passare inosservato.\r\nCONTROLLA LA MUSICA CON LA TUA VOCE: chiedi ad Alexa di riprodurre musica, audiolibri e podcast dai tuoi servizi preferiti, come Amazon Music, Apple Music, Spotify, Deezer e altri ancora. Collega il tuo smartphone tramite Bluetooth per diffondere la musica in tutta la stanza.\r\nRENDI OGNI AMBIENTE INTELLIGENTE: usa la tua voce o l’App Alexa per controllare facilmente i dispositivi intelligenti compatibili, come prese e luci.\r\nSEMPLIFICATI LA VITA: chiedi ad Alexa di impostare un timer, controllare il meteo, leggere le notizie, riordinare i tovaglioli di carta, effettuare una chiamata, rispondere alle tue domande e molto altro ancora.\r\nPERSONALIZZA ALEXA CON LE SKILL: con migliaia di Skill disponibili e in crescita continua, Alexa può aiutarti a fare sempre più cose. Ad esempio, può riprodurre suoni rilassanti o sfidarti sulla tua conoscenza musicale.",
                    Prezzo = 32.99m,
                    ImgUrl = "https://m.media-amazon.com/images/I/61TQVm2l1OL._AC_SX679_.jpg"
                },
                 new Prodotto
                {
                    IdProdotto = 7,
                    Nome = "Aspirapolvere Senza Fili",
                    Descrizione = "40Kpa&500W, Standby 60Mins Scopa Elettrica Senza Fili con Touchscreen Intelligente e Anti-Avvolgimento, 1,5L Aspirapolvere Senza Fili potente per Pavimenti/Tappeti/Casa",
                    DescrizioneDettagliata = "🌀【40 Kpa forte aspirazione ＆ 50W Motore 】Aspirapolvere senza fili dotato di un motore aggiornato da 500W, offre una potenza di aspirazione ciclonica senza precedenti di 40 Kpa, che migliora notevolmente l'efficienza del lavoro. Inoltre, briciole, peli di animali domestici e sporcizia da pavimenti e tappeti. Rumore <68 dB per una pulizia silenziosa ed efficiente che lascerà la vostra casa come nuova.\r\n🔋【8 *2500 mAh Batteria rimovibile 】Scopa elettrica senza fili con batterie ad alta capacità da 8 * 2500 mAh, rispetto alla tradizionale batteria a 7 celle, che estende notevolmente l'autonomia. Alla minima potenza di aspirazione, l'autonomia raggiunge i 60 minuti. Alla massima potenza, l'autonomia è di 20 minuti, più che sufficiente per pulire grandi superfici senza dover effettuare ricariche frequenti. L'aspirapolvere necessita solo di 4-5 ore per una ricarica completa.\r\n\U0001f9f9【Spazzola elastica a V migliorata ＆ 4 in 1】Aspirapolvere senza fili potente con una combinazione di setole morbide e dure, setole rotanti a V e setole pettinate, e un motore 5C per un migliore accesso ai canali di ventilazione e una riduzione dei grovigli di capelli. Il tubo telescopico 4-in-1 e le punte multiple migliorano i risultati di pulizia e facilitano la pulizia di porte, fessure del divano e bordi dei davanzali.",
                    Prezzo = 156.12m,
                    ImgUrl = "https://m.media-amazon.com/images/I/71F5GetwrCL.__AC_SX300_SY300_QL70_ML2_.jpg"
                },
                  new Prodotto
                {
                    IdProdotto = 8,
                    Nome = "Swarovski Infinity Heart Jewelry Collection",
                    Descrizione = "Necklaces and Bracelets, Rose Gold & Rhodium Tone Finish, Clear Crystals",
                    DescrizioneDettagliata = "Misure: lunghezza 24 cm\r\nUn'espressione di amore eterno: il bracciale placcato in tonalità rodio presenta un affascinante duplice elemento raffigurante un cuore e un simbolo dell’infinito intrecciati\r\nPronti, partenza, brilla: un’unica, brillante pietra scintillante adorna il simbolo dell’infinito e dona un tocco di luminosità al modello\r\nCattura i cuori: aggiungi ai tuoi gioielli il bracciale della Collezione Infinity con catena veneziana regolabile per uno stile semplice ma incantevole\r\nMeraviglia la persona amata: il bracciale della Collezione Infinity è un'idea regalo originale e ricca di significato per una persona importante nella tua vita\r\nArticolo consegnato: 1 x Swarovski Infinity Braccialetto, con zirconi Swarovski su cuore e infinito e placcatura in tonalità rodio, inclusa confezione Swarovski",
                    Prezzo = 73.51m,
                    ImgUrl = "https://m.media-amazon.com/images/I/61z6viKICjL._AC_SX679_.jpg"
                },
            };

            return prodotti;
        }

        /*
         * Summary: Restituisce un prodotto dal database in base all'ID specificato.
         * Parameters: L'ID del prodotto da cercare.
         * Return: l prodotto corrispondente all'ID specificato
        */
        public static Prodotto GetProdottoById(int productId)
        {
            List<Prodotto> prodotti = GetProdotti();
            return prodotti.FirstOrDefault(p => p.IdProdotto == productId);
        }
    }
}