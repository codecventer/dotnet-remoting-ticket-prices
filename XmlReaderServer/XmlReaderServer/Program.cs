using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace XmlReaderServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Using TCP and port 1902:
                TcpChannel channel = new TcpChannel(1902);
                ChannelServices.RegisterChannel(channel, true);

                // Server-Activated Objects:
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(XmlReader.Tickets), "XmlReader", WellKnownObjectMode.SingleCall);

                // Success message:
                Console.WriteLine("Server is running!");
                Console.WriteLine();
                Console.Write("Press any key to exit . . .");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                // Error message:
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine();
                Console.Write("Press any key to exit . . .");
                Console.ReadLine();
            }
        }
    }
}
