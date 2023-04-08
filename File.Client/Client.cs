using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Client
{
    public class Client
    {
        //create a client
        //call this client, this endpoint, this api.

        public string GetData()
        {
            try
            {
                using var client = new HttpClient();
                var result = client.GetAsync("https://localhost:7177/File").Result;
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
