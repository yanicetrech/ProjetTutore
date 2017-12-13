using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using SimpleJson;
using System.Net;
using System.Runtime.Serialization.Json;


namespace TestCrous_1._0._2
{
   
     public class Envoie 
    {

        // POST a JSON string

        private string url = "http://169.254.242.49";



        public async void maMethodePost()
        {
            var monUser = new
            {
                nom = "AAA",
                prenom = "BBB",
                pseudo = "CCC",
                ville = "DDD",
                dateNaissance = DateTime.Now,
                adresse = "EEE",
                mail = "FFF@yolo.com"
            };

            var monJson = JsonConvert.SerializeObject(monUser);



            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            using (Stream MyWebStream = await request.GetRequestStreamAsync())
            {
                using (StreamWriter requestWriter = new StreamWriter(MyWebStream, Encoding.UTF8))
                {
                    requestWriter.Write(monJson);
                }
            }

            try
            {
                WebResponse webResponse = await request.GetResponseAsync();
                using (Stream webStream = webResponse.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            Console.WriteLine("Successfull");
                            string response = responseReader.ReadToEnd();
                            
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Echec");
              
            }
        }





    }
}
