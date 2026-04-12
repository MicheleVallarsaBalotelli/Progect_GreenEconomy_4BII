using static System.Windows.Forms.DataFormats;

namespace Progect_GreenEconomy_4BII
{
    public partial class Form1 : Form
    {
        private ApiService _apiService = new ApiService();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btn_aggiorna_Click(object sender, EventArgs e)
        {
            try
            {
                btn_aggiorna.Enabled = false;
                lblStato.Text = "Download in corso...";

                // chiamata API
                EnviromentData nuoviDati = await _apiService.GetDatiAsync();

                // carica la lista esistente dal file JSON
                List<EnviromentData> listaAttuale = JsonService.CaricaDati();

                // aggiunta i nuovi dati alla lista
                listaAttuale.Add(nuoviDati);

                // salvataggio lista aggiornata nel file JSON
                JsonService.SalvaDati(listaAttuale);

                lblStato.Text = "Dati salvati correttamente!";
                MessageBox.Show($"Dati di Vicenza scaricati!\nTemp: {nuoviDati.temperatura}°C\nAQI: {nuoviDati.qualitaAria}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message, "Errore di Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStato.Text = "Errore durante l'aggiornamento.";
            }
            finally
            {
                btn_aggiorna.Enabled = true;
            }
        }

        private void btn_visualizzaDati_Click(object sender, EventArgs e)
        {
            List<EnviromentData> dati = JsonService.CaricaDati();

            if (dati.Count == 0)
            {
                MessageBox.Show("Il database è vuoto. Scarica prima i dati!", "Attenzione");
                return;
            }

            FormDati frmTabella = new FormDati(dati);
            frmTabella.ShowDialog();
        }

        private void btn_analisiGrafico_Click(object sender, EventArgs e)
        {
            List<EnviromentData> dati = JsonService.CaricaDati();

            if (dati.Count == 0)
            {
                MessageBox.Show("Nessun dato disponibile per l'analisi.", "Attenzione");
                return;
            }

            FormGrafico frmGrafico = new FormGrafico(dati);
            frmGrafico.ShowDialog();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            var conferma = MessageBox.Show("Vuoi davvero cancellare lo storico?", "Reset", MessageBoxButtons.YesNo);
            if (conferma == DialogResult.Yes)
            {
                JsonService.ResetDatabase();
                MessageBox.Show("Database svuotato!");
            }
        }
    }
}
