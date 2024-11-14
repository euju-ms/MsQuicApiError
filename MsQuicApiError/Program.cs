// See https://aka.ms/new-console-template for more information
HttpClient httpClient = new HttpClient();
string st = httpClient.ToString() ?? string.Empty;

string uri = "Https://www.bing.com";
HttpResponseMessage response = await httpClient.GetAsync(uri).ConfigureAwait(true);

Console.WriteLine($"Hello, World! {st} {response}");
