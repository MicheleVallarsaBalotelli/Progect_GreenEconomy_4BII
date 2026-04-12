using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Progect_GreenEconomy_4BII
{
    public class JsonService
    {
        private static string nomeFile = "dataset_ambientale.json";

        public static void SalvaDati(List<EnviromentData> lista)
        {
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(nomeFile, json);
        }

        public static List<EnviromentData> CaricaDati()
        {
            if (!File.Exists(nomeFile))
            {
                return new List<EnviromentData>();
            }

            // leggo tutto il testo 
            string json = File.ReadAllText(nomeFile);

            // trasformo il testo JSON in una lista di oggetti EnviromentData
            List<EnviromentData> listaCaricata = JsonSerializer.Deserialize<List<EnviromentData>>(json);

            return listaCaricata;
        }

        public static void ResetDatabase()
        {
            if (File.Exists(nomeFile))
            {
                File.Delete(nomeFile);
            }
        }
    }
}
