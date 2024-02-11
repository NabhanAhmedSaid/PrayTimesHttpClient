using Newtonsoft.Json;

HttpClient httpClient = new HttpClient();
string endpoint = "http://api.aladhan.com/v1/calendarByCity";
string parameters = "?city=London&country=Gulf&Region=2&month=04&year=2020";
string uri = endpoint + parameters;
HttpResponseMessage responseMessage = httpClient.GetAsync(uri).Result;
string response = responseMessage.Content.ReadAsStringAsync().Result;
dynamic resultObject = JsonConvert.DeserializeObject(response);
Console.Write("Fajr: ");
Console.WriteLine(resultObject.data[0].timings.Fajr);
Console.Write("Dhuhr: ");
Console.WriteLine(resultObject.data[0].timings.Dhuhr);
Console.Write("Asr: ");
Console.WriteLine(resultObject.data[0].timings.Asr);
Console.Write("Maghrib: ");
Console.WriteLine(resultObject.data[0].timings.Maghrib);
Console.Write("Isha: ");
Console.WriteLine(resultObject.data[0].timings.Isha);


