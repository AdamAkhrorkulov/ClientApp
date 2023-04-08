namespace Main.Client
{
    public class BaseClient
    {
        public string GetData(string address)
        {
            try
            {
                using var client = new HttpClient();
                var result = client.GetAsync(address).Result;
                return result.Content.ReadAsStringAsync().Result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
