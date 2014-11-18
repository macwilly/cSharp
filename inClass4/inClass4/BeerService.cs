using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using CookComputing.XmlRpc;

namespace inClass4
{
    public class BeerService
    {
        string baseUri = "http://simon.ist.rit.edu:8080/BeerService/resources/Services/";
        
        
        public string[] GetBeers()
        {
            string thisUri = baseUri + "Beers";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(thisUri);
            req.Method="GET";

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream str = resp.GetResponseStream();
            XmlReader xr = XmlReader.Create(str);

            // deal with the response and prep for sending back to the call
            List<string> myBeers = new List<string>();

            while(xr.Read()){
                if(xr.Value !="") myBeers.Add(xr.Value);
            }
            //send back to call
            return myBeers.ToArray();
        }
        
        public string GetPrice(string beerName)
        {
            string thisUri = baseUri+"Beer/" + Uri.EscapeDataString(beerName);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(thisUri);
            req.Method = "GET";

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream str = resp.GetResponseStream();
            XmlReader xr = XmlReader.Create(str);

            //move the pointer xr on the xml doc to the first intance of <price>
            xr.ReadToFollowing("price");
            return "$"+xr.ReadElementContentAsString();
        }
    }
}
