using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace serialazation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void serialazation()
            { 
                Event calgary = new Event("Calgary", 1);

                FileStream fileStream = File.OpenWrite("event.txt");

                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(fileStream, calgary);

                fileStream.Close();

                Console.WriteLine("saved obj");
            }
            void deserialize()
            {
                FileStream fileStream = File.OpenRead("event.txt");

                BinaryFormatter formatter = new BinaryFormatter();

                while (fileStream.Position < fileStream.Length)
                {  
                    Event calgary = (Event)formatter.Deserialize(fileStream);
                    Console.WriteLine(calgary.EventNumber + "\n" + calgary.Location);
                }

                fileStream.Close();


            }
            void readFromFile()
            {
                FileStream stream = File.OpenWrite("event.txt");
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine("Hackathon");
                
            }
            serialazation();
            deserialize();

            
        }
    }
}