using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Progect_GreenEconomy_4BII
{
    public partial class FormGrafico : Form
    {
        private List<EnviromentData> dati;
        public FormGrafico(List<EnviromentData> dati)
        {
            InitializeComponent();
            this.dati = dati;
        }

        private void FormGrafico_Load(object sender, EventArgs e)
        {
            ConfiguraGrafico();
            PopolaDatiGrafico();
        }

        private void btn_indietro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ConfiguraGrafico()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Analisi Correlazione: Temperatura vs Inquinamento");

            // creazione area grafico
            ChartArea area = chart1.ChartAreas[0];
            area.AxisX.Title = "Tempo";
            area.AxisY.Title = "Valori";
            area.AxisX.IntervalType = DateTimeIntervalType.Auto;

            // temperatura (linea arancione)
            Series serieTemp = new Series("Temperatura (°C)");
            serieTemp.ChartType = SeriesChartType.Spline; // linea morbida
            serieTemp.BorderWidth = 3;
            serieTemp.Color = Color.Orange;
            serieTemp.XValueType = ChartValueType.DateTime;

            // inquinamento (istogramma verde)
            Series serieAria = new Series("Qualità Aria (1-5)");
            serieAria.ChartType = SeriesChartType.Column; 
            serieAria.Color = Color.FromArgb(120, Color.SeaGreen);

            chart1.Series.Add(serieAria);
            chart1.Series.Add(serieTemp);

            // legenda
            chart1.Legends[0].Docking = Docking.Bottom;
        }

        public void PopolaDatiGrafico()
        {
            foreach (var d in dati)
            {
                chart1.Series["Temperatura (°C)"].Points.AddXY(d.DataOra, d.temperatura);
                chart1.Series["Qualità Aria (1-5)"].Points.AddXY(d.DataOra, d.qualitaAria);
            }

            AnalizzaDati();
        }

        private void AnalizzaDati()
        {
            if (dati.Count > 0)
            {
                var ultimo = dati[dati.Count - 1];
                if (ultimo.temperatura > 30 && ultimo.qualitaAria >= 4)
                {
                    lblAnalisi.Text = "Criticità rilevata: Alte temperature e inquinamento elevato.";
                }
            }
        }
    }
}
