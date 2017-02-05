using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public class XmlInfo
    {
        public string nodeName { get; set; }
        public Hashtable attr_hashtbl { get; set; }
        public string innertext { get; set; }

        public XmlInfo()
        {
            attr_hashtbl = new Hashtable();
        }
        public XmlInfo(string ndname, Hashtable tbl, string text)
        {
            nodeName = ndname;
            attr_hashtbl = tbl;
            innertext = text;
        }
        public XmlInfo(string ndname, Hashtable tbl)
        {
            nodeName = ndname;
            attr_hashtbl = tbl;
        }
    }
}
