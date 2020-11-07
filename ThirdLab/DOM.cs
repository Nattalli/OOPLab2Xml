using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ThirdLab
{
    class DOM : IStrategy
    {
        XmlDocument doc = new XmlDocument();
        public List<Cats> AnalyzeFile(Cats mySearch, string path)
        {
            doc.Load(path);
            List<List<Cats>> info = new List<List<Cats>>();

            if(mySearch.name == null && mySearch.breed == null && mySearch.sex == null && mySearch.age == null && mySearch.vac == null)
            {
                return ErrorCatch(doc);
            }

            if (mySearch.name != null) info.Add(SearchByAttribute("cat", "NAME", mySearch.name, doc));
            if (mySearch.sex != null) info.Add(SearchByAttribute("cat", "SEX", mySearch.sex, doc));
            if (mySearch.breed != null) info.Add(SearchByAttribute("cat", "BREED", mySearch.breed, doc));
            if (mySearch.age != null) info.Add(SearchByAttribute("cat", "AGE", mySearch.age, doc));
            if (mySearch.vac != null) info.Add(SearchByAttribute("cat", "VACCINATIONS", mySearch.vac, doc));

            return Cross(info, mySearch);
        }

        public List<Cats> SearchByAttribute(string Name, string Attribute, string Temp, XmlDocument doc)
        {
            List<Cats> find = new List<Cats>();

            if(Temp != null)
            {
                XmlNodeList lst = doc.SelectNodes("//" + Name + "[@" + Attribute + "=\"" + Temp + "\"]");
                foreach(XmlNode x in lst)
                {
                    find.Add(Info(x));
                }
            }
            return find;
        }

        public List<Cats> ErrorCatch(XmlDocument doc)
        {
            List<Cats> res = new List<Cats>();
            XmlNodeList lst = doc.SelectNodes("//" + "cat");
            foreach(XmlNode x in lst)
            {
                res.Add(Info(x));
            }
            return res;
        }

        public Cats Info(XmlNode node)
        {
            Cats search = new Cats();
            search.name = node.Attributes.GetNamedItem("NAME").Value;
            search.sex = node.Attributes.GetNamedItem("SEX").Value;
            search.breed = node.Attributes.GetNamedItem("BREED").Value;
            search.age = node.Attributes.GetNamedItem("AGE").Value;
            search.vac = node.Attributes.GetNamedItem("VACCINATIONS").Value;

            return search;
        }

        public List<Cats> Cross(List<List<Cats>> cats, Cats Temp)
        {
            List<Cats> res = new List<Cats>();
            List<Cats> clear = CheckNodes(cats, Temp);
            foreach(Cats x in clear)
            {
                bool isIn = false;
                foreach(Cats s in res)
                {
                    if(s.Compare(x))
                    {
                        isIn = true;
                    }
                }
                if(isIn)
                {
                    res.Add(x);
                }
            }
            return res;
        }

        public List<Cats> CheckNodes(List<List<Cats>> cat, Cats Temp)
        {
            List<Cats> res = new List<Cats>();
            foreach(List<Cats> x in cat)
            {
                foreach(Cats s in x)
                {
                    if((Temp.name == s.name || Temp.name == null)&&
                        (Temp.sex == s.sex || Temp.sex == null) &&
                        (Temp.age == s.age || Temp.age == null) &&
                        (Temp.breed == s.breed || Temp.breed == null) &&
                        (Temp.vac == s.name || Temp.vac == null))
                    {
                        res.Add(s);
                    }
                }
            }
            return res;
        }
    }
}
