using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\zhua1\Desktop\lexisRedData\test1@hotmail.com\1\unencrypted\fact10001000.xml";
            XmlDocument doc=new XmlDocument();
            doc.Load(path);
            var nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("case", "http://www.lexis-nexis.com/glp/case");
            nsmgr.AddNamespace("ci", "http://www.lexis-nexis.com/ci");
            nsmgr.AddNamespace("comm", "http://www.lexis-nexis.com/glp/comm");
            nsmgr.AddNamespace("cttr", "http://www.lexis-nexis.com/glp/cttr");

            nsmgr.AddNamespace("dict", "http://www.lexis-nexis.com/glp/dict");
            nsmgr.AddNamespace("dig", "http://www.lexis-nexis.com/glp/dig");
            nsmgr.AddNamespace("docinfo", "http://www.lexis-nexis.com/glp/docinfo");
            nsmgr.AddNamespace("frm", "http://www.lexis-nexis.com/glp/frm");
            nsmgr.AddNamespace("glp", "http://www.lexis-nexis.com/glp");
            nsmgr.AddNamespace("in", "http://www.lexis-nexis.com/glp/in");
            nsmgr.AddNamespace("jrnl", "http://www.lexis-nexis.com/glp/jrnl");

            nsmgr.AddNamespace("lnci", "http://www.lexis-nexis.com/lnci");
            nsmgr.AddNamespace("lncle", "http://www.lexis-nexis.com/lncle");
            nsmgr.AddNamespace("lnclx", "http://www.lexis-nexis.com/lnclx");
            nsmgr.AddNamespace("lndel", "http://www.lexis-nexis.com/lndel");
            nsmgr.AddNamespace("lndocmeta", "http://www.lexis-nexis.com/lndocmeta");

            nsmgr.AddNamespace("lngntxt", "http://www.lexis-nexis.com/lngntxt");
            nsmgr.AddNamespace("lnlit", "http://www.lexis-nexis.com/lnlit");
            nsmgr.AddNamespace("lnv", "http://www.lexis-nexis.com/lnv");
            nsmgr.AddNamespace("lnvni", "http://www.lexis-nexis.com/lnvni");
            nsmgr.AddNamespace("lnvx", "http://www.lexis-nexis.com/lnvx");
            nsmgr.AddNamespace("lnvxe", "http://www.lexis-nexis.com/lnvxe");
            nsmgr.AddNamespace("nitf", "urn:nitf:iptc.org.20010418.NITF");
            nsmgr.AddNamespace("xhtml", "http://www.w3c.org/1999/xhtml");

            var node = doc.SelectSingleNode("//comm:body/level/level/bodytext/p/text/text()[1]", nsmgr);
            Console.WriteLine(node.Value.Substring(0,126));
        }
    }
}
