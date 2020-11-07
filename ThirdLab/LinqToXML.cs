using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ThirdLab
{
    class LinqToXML:IStrategy
    {
        private List<Cats> find = null;
        XDocument doc = new XDocument();

        public List<Cats> AnalyzeFile(Cats mySearch, string path)
        {
            doc = XDocument.Load(@path);
            find = new List<Cats>();
            List<XElement> matches = (from val in doc.Descendants("cat")
                                      where ((mySearch.name == null || mySearch.name == val.Attribute("NAME").Value) &&
                                      (mySearch.sex == null || mySearch.sex == val.Attribute("SEX").Value) &&
                                      (mySearch.breed == null || mySearch.breed == val.Attribute("BREED").Value) &&
                                      (mySearch.age == null || mySearch.age == val.Attribute("AGE").Value) &&
                                      (mySearch.vac == null || mySearch.vac == val.Attribute("VACCINATIONS").Value))
                                      select val).ToList();
            foreach(XElement match in matches)
            {
                Cats res = new Cats();
                res.name = match.Attribute("NAME").Value;
                res.sex = match.Attribute("SEX").Value;
                res.breed = match.Attribute("BREED").Value;
                res.age = match.Attribute("AGE").Value;
                res.vac = match.Attribute("VACCINATIONS").Value;
                find.Add(res);
            }
            return find;
        }
    }
}
