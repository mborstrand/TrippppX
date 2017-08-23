using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Diagnostics;
using System.Net.Http.Headers;
using Common.Models;

namespace Trippp.Common
{
    public class Service
    {
        readonly static string accessToken = "88862c0f-c696-324c-941f-ba57bba5cb31";

        public async Task<LocationList> GetStops()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    // AuthenticationHeaderValue 
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                    var response = client.GetAsync(new Uri("https://api.vasttrafik.se/bin/rest.exe/v2/location.name?input=Chalmers&format=json")).Result;
                    Debug.WriteLine("Response: {0}", response.StatusCode);
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new HttpRequestException(string.Format("Couln't get url. Failed with status code {1}", response.StatusCode));
                    }
                    var json = await response.Content.ReadAsStringAsync();

                    Debug.WriteLine("***: {0}", json);

                    LocationList list = JsonConvert.DeserializeObject<LocationList>(json);

                    return list;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Exception: " + ex.Message);
                    return null;
                }
            }
        }

        public async Task<IEnumerable<Departure>> GetDepartures()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    // AuthenticationHeaderValue 
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                    var response = client.GetAsync(new Uri("https://api.vasttrafik.se/bin/rest.exe/v2/departureBoard?id=9021014001960000&date=2017-07-06&time=13%3A42&format=json")).Result;
                    Debug.WriteLine("Response: {0}", response);
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new HttpRequestException(string.Format("Couln't get url. Failed with status code {1}", response.StatusCode));
                    }
                    var json = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine(" *** Data:\n\n {0} \n\n", json);
                    return JsonConvert.DeserializeObject<DepartureBoard>(json).Departures;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(" *** > " + ex.Message);
                    return null;
                }
            }
        }

        public async Task<T> GetDataAsync<T>(string baseUrl, string param1 = null, string param2 = null, string param3 = null)
        {
            var serviceUrl = baseUrl + (param1 != null ? "/" + param1 : string.Empty) + (param2 != null ? "/" + param2 : string.Empty) + (param3 != null ? "/" + param3 : string.Empty);

            using (var client = new HttpClient())
            {
                try
                {
                    // AuthenticationHeaderValue 
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                    var response = client.GetAsync(new Uri(serviceUrl)).Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new HttpRequestException(string.Format("Generic Get to url {0} failed with status code {1}", serviceUrl, response.StatusCode));
                    }
                    var json = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine(" *** Data: {0}", json);
                    Debug.WriteLine("*** DES {0}", JsonConvert.DeserializeObject<T>(json));

                    return JsonConvert.DeserializeObject<T>(json);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(" *** > " + ex.Message);
                    return default(T);
                }
            }
        }
    }
}
