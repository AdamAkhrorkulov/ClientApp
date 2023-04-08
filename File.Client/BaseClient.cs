using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Client
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
