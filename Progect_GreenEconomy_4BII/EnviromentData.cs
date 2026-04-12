using System;
using System.Collections.Generic;
using System.Text;

namespace Progect_GreenEconomy_4BII
{
    public class EnviromentData
    {
        public DateTime DataOra { get; set; }
        public double temperatura { get; set; }
        public double qualitaAria { get; set; }


        public EnviromentData() { } // costruttore vuoto per la serializzazione JSON


        public EnviromentData(double temp, double aqi)
        {
            this.DataOra = DateTime.Now;
            this.temperatura = temp;
            this.qualitaAria = aqi;
        }
    }
}
