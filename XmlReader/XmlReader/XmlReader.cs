using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlReader
{
    public class Tickets : MarshalByRefObject
    {
        // New XML Reader object:
        XmlTextReader xtr = new XmlTextReader(@"C:\AssessmentsFolder\Tickets.xml");

        // Get all destinations:
        public string GetAllXml()
        {
            // Create variables for each location:
            string capeTown = "";
            string johannesburg = "";
            string durban = "";
            string bloemfontein = "";
            string kimberley = "";

            // Read through XML file
            while (xtr.Read())
            {
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "CapeTown")
                {
                    // Store element to string:
                    capeTown = xtr.ReadElementString();
                }

                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Johannesburg")
                {
                    // Store element to string:
                    johannesburg = xtr.ReadElementString();
                }

                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Durban")
                {
                    // Store element to string:
                    durban = xtr.ReadElementString();
                }

                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Bloemfontein")
                {
                    // Store element to string:
                    bloemfontein = xtr.ReadElementString();
                }

                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Kimberley")
                {
                    // Store element to string:
                    kimberley = xtr.ReadElementString();
                }
            }

            // String to be displayed:
            string allPrices = "Cape Town: R" + capeTown + Environment.NewLine + "Johannesburg: R" + johannesburg + Environment.NewLine + "Durban: R" + durban + Environment.NewLine + "Bloemfontein: R" + bloemfontein + Environment.NewLine + "Kimberley: R" + kimberley + Environment.NewLine;

            // Display all prices:
            return allPrices;
        }

        // Get specified destination:
        public string GetSelectedXml(string location)
        {
            // Create variable for single location price:
            string price = "";

            // Read through XML file:
            while (xtr.Read())
            {
                // Get element of specified location: 
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == location)
                {
                    // Store element to string:
                    price = xtr.ReadElementString();
                }
            }

            // Display single location price:
            return "Price: R" + price;
        }
    }
}
