using System;
using System.Collections.Generic;
using System.Net.Http;     // per connettersi a internet
using System.Text;
using System.Text.Json;    // per leggere i dati JSON
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Progect_GreenEconomy_4BII
{
    public class ApiService
    {
        private string apiKey = "0038449e78cd5edab0ba360b9e17e781"; // inserire la propria chiave API 
        private string citta = "Vicenza";

        
        public async Task<EnviromentData> GetDatiAsync() // metodo async per scaricare i dati da internet
        {
            // oggetto che fa la chiamata HTTP
            HttpClient client = new HttpClient();

            try
            {
                // url per scaricare i dati con la città e la chiave API
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={citta}&appid={apiKey}&units=metric";

                // dati in formato JSON
                string rispostaJson = await client.GetStringAsync(url);

                
                JsonDocument documento = JsonDocument.Parse(rispostaJson);
                JsonElement radice = documento.RootElement;


                JsonElement sezioneMain = radice.GetProperty("main");
                double temperaturaTrovata = sezioneMain.GetProperty("temp").GetDouble();


                Random generatoreRandom = new Random();
                int inquinamentoSimulato = generatoreRandom.Next(1, 6);


                EnviromentData risultato = new EnviromentData();
                risultato.DataOra = DateTime.Now;
                risultato.temperatura = temperaturaTrovata;
                risultato.qualitaAria = inquinamentoSimulato;

                return risultato;
            }
            catch (Exception errore)
            {
                throw new Exception("Errore durante il download: " + errore.Message);
            }
            finally
            {
                client.Dispose();
            }
        }
    }
}
