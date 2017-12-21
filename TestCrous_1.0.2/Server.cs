using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace TestCrous_1._0._2
{
    class Server
    {
        
        

        public void Test()
        {

            Category cat = new Category(1, "grec", true);
            Product prod = new Product(1, "Americain", 6.5);
            


            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 13000.
                Int32 port = 13000;
                IPAddress localAddr = IPAddress.Parse("10.0.2.26");

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also user server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                       string JsonA = cat.getA();
                       string JsonB = prod.getB();

                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", data);

                        // Process the data sent by the client.
                        data = data.ToUpper();

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                        byte[] messJson1 = System.Text.Encoding.ASCII.GetBytes(JsonA);
                        byte[] messJson2 = System.Text.Encoding.ASCII.GetBytes(JsonB);


                        // Send back a response.
                        stream.Write(msg, 0, msg.Length);
                        stream.Write(messJson1, 0, messJson1.Length);
                        stream.Write(messJson2, 0, messJson2.Length);


                        Console.WriteLine("Sent: {0}", data);
                    }

                    // Shutdown and end connection
                    stream.Close();
                    client.Close();
                }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(
                    "{0}: Le client a été deconnecté",
                    e.GetType().Name);
            }

            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }


            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }
    }
}