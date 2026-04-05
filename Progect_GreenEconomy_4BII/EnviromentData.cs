using System;
using System.Collections.Generic;
using System.Text;

namespace Progect_GreenEconomy_4BII
{
    public class EnviromentData
    {
        public DateTime DataOra { get; set; }
        public double temperatura { get; set; }
        public int qualitaAria { get; set; } // 1-5

        
        public EnviromentData() { } // costruttore vuoto per la serializzazione JSON


        public EnviromentData(double temp, int aqi)
        {
            this.DataOra = DateTime.Now;
            this.temperatura = temp;
            this.qualitaAria = aqi;
        }
    }
}
