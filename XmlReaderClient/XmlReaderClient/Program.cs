using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Xml;

namespace XmlReaderClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Register channel:
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, true);

            // Instantiate new XmlReader object:
            XmlReader.Tickets x = (XmlReader.Tickets)Activator.GetObject(typeof(XmlReader.Tickets), "tcp://localhost:1902/XmlReader");

            ConsoleKeyInfo cki;

            while (true)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine();
                Console.WriteLine("Get Destination Prices:");
                Console.WriteLine();
                Console.WriteLine("1. All destinations");
                Console.WriteLine("2. Cape Town");
                Console.WriteLine("3. Johannesburg");
                Console.WriteLine("4. Durban");
                Console.WriteLine("5. Bloemfontein");
                Console.WriteLine("6. Kimberley");
                Console.WriteLine();
                Console.Write("Select an option (or Q to quit): ");
                
                cki = Console.ReadKey(true);

                string option = Console.ReadLine();
                Console.WriteLine();

                // Exit if the user pressed the 'Q' key:
                if (cki.Key == ConsoleKey.Q) break;

                switch (option)
                {
                    case "1":
                        Console.WriteLine("-----------------------");
                        Console.WriteLine();
                        Console.WriteLine("All destinations:");
                        Console.WriteLine();
                        Console.WriteLine(x.GetAllXml());
                        Console.WriteLine();
                        Console.Write("Press enter key to continue");
                        Console.ReadLine();
                        Console.WriteLine();
                        break;
                    case "2":
                        option = "CapeTown";
                        Console.WriteLine("-----------------------");
                        Console.WriteLine();
                        Console.WriteLine("Cape Town:");
                        Console.WriteLine();
                        Console.WriteLine(x.GetSelectedXml(option));
                        Console.WriteLine();
                        Console.Write("Press enter key to continue");
                        Console.ReadLine();
                        Console.WriteLine();
                        break;
                    case "3":
                        option = "Johannesburg";
                        Console.WriteLine("-----------------------");
                        Console.WriteLine();
                        Console.WriteLine("Johannesburg:");
                        Console.WriteLine();
                        Console.WriteLine(x.GetSelectedXml(option));
                        Console.WriteLine();
                        Console.Write("Press enter key to continue");
                        Console.ReadLine();
                        Console.WriteLine();
                        break;
                    case "4":
                        option = "Durban";
                        Console.WriteLine("-----------------------");
                        Console.WriteLine();
                        Console.WriteLine("Durban:");
                        Console.WriteLine();
                        Console.WriteLine(x.GetSelectedXml(option));
                        Console.WriteLine();
                        Console.Write("Press enter key to continue");
                        Console.ReadLine();
                        Console.WriteLine();
                        break;
                    case "5":
                        option = "Bloemfontein";
                        Console.WriteLine("-----------------------");
                        Console.WriteLine();
                        Console.WriteLine("Bloemfontein:");
                        Console.WriteLine();
                        Console.WriteLine(x.GetSelectedXml(option));
                        Console.WriteLine();
                        Console.Write("Press enter key to continue");
                        Console.ReadLine();
                        Console.WriteLine();
                        break;
                    case "6":
                        option = "Kimberley";
                        Console.WriteLine("-----------------------");
                        Console.WriteLine();
                        Console.WriteLine("Kimberley:");
                        Console.WriteLine();
                        Console.WriteLine(x.GetSelectedXml(option));
                        Console.WriteLine();
                        Console.Write("Press enter key to continue");
                        Console.ReadLine();
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Please select a valid option...");
                        Console.WriteLine();
                        Console.Write("Press enter key to continue");
                        Console.ReadLine();
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
