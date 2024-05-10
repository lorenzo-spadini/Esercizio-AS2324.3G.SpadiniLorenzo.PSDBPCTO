using System.Data;
using System.Data.SQLite;

namespace Esercizio_AS2324._3G.SpadiniLorenzo.PSDBPCTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnElencoPiloti_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            strConnessione = "Data Source=" + @"C:\Users\lorenzo\Desktop\Esercizio AS2324.3G.SpadiniLorenzo.PSDBPCTO" + ";Version=3;";

            DataTable dtDati = new DataTable();

            query = "SELECT Nome, Cognome FROM Piloti WHERE Nazionalità = 'Italia' ORDER BY Cognome, Nome";


            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                da.Fill(dtDati);

                dgvDati.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void btnElencoGare_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";
            strConnessione = "Data Source=" + @"C:\Appl\Scuola\AS_2023_2024\3G\AS2324.3G.Prof.PCTODB\AS2324.3G.Prof.PCTODB\DB\MotoGP.db" + ";Version=3;";
            DataTable dtDati = new DataTable();

            query = "SELECT FROM Gare WHERE Posizione <= 3 ORDER BY Circuito, Punteggio;";

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            { 
                da.Fill(dtDati);
                dgvDati.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
    }
}
