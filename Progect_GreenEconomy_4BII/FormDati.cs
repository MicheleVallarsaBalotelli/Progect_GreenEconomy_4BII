using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Progect_GreenEconomy_4BII
{
    public partial class FormDati : Form
    {

        List<EnviromentData> Dati;

        public FormDati(List<EnviromentData> dati)
        {
            Dati = dati;
            InitializeComponent();
        }

        private void FormDati_Load(object sender, EventArgs e)
        {
            dvg_dati.DataSource = Dati;
        }
    }
}
