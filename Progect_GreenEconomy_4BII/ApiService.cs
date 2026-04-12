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
                // CHIAMATA METEO (per temperatura)
                string urlMeteo = $"https://api.openweathermap.org/data/2.5/weather?q={citta}&appid={apiKey}&units=metric";
                string rispostaMeteo = await client.GetStringAsync(urlMeteo);
                JsonDocument docMeteo = JsonDocument.Parse(rispostaMeteo);

                double temp = docMeteo.RootElement.GetProperty("main").GetProperty("temp").GetDouble();

                // recupero coordinate per la seconda chiamata
                double lat = docMeteo.RootElement.GetProperty("coord").GetProperty("lat").GetDouble();
                double lon = docMeteo.RootElement.GetProperty("coord").GetProperty("lon").GetDouble();

                // CHIAMATA INQUINAMENTO (per PM10)
                string urlAria = $"https://api.openweathermap.org/data/2.5/air_pollution?lat={lat}&lon={lon}&appid={apiKey}";
                string rispostaAria = await client.GetStringAsync(urlAria);
                JsonDocument docAria = JsonDocument.Parse(rispostaAria);

                // json per PM10
                double pm10 = docAria.RootElement.GetProperty("list")[0]
                                     .GetProperty("components")
                                     .GetProperty("pm10").GetDouble();

                // oggetto con dati 
                return new EnviromentData(temp, pm10);
            }
            catch (Exception errore)
            {
                throw new Exception("Errore: " + errore.Message);
            }
            finally
            {
                client.Dispose();
            }
        }
    }
}

