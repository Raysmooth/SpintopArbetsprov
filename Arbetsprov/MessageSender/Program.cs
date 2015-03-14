using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.DataAccess;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
namespace MessageSender
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Type a message: ");
            var message = new Message(Console.ReadLine(), DateTime.Now);
            while (message.Text != "")
            {
                try
                {
                    HttpClient client = new HttpClient();
                    JsonConvert.SerializeObject(message);
                    client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.PostAsJsonAsync("http://localhost:64156/api/MessageApi/", message).Result;

                            if (response.IsSuccessStatusCode)
                                {
                                Console.WriteLine("Message sent");
                       
                                }
                            else
                                {
                                 Console.WriteLine("Error Code" +
                                 response.StatusCode + " : Message - " + response.ReasonPhrase);
                                }
                 }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
           message.Text = Console.ReadLine();
           message.Time = DateTime.Now;
            }
        }
    }
}


