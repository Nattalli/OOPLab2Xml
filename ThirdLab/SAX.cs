using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ThirdLab
{
    class SAX : IStrategy
    {
        private List<Cats> Lres = null;
        public List<Cats> AnalyzeFile(Cats mySearch, string path)
        {
            XmlReader reader = XmlReader.Create(path);
            List<Cats> res = new List<Cats>();

            Cats find = null;

            while(reader.Read())
            {
                switch(reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "cat")
                        {
                            find = new Cats();
                            while (reader.MoveToNextAttribute())
                            {
                                if(reader.Name == "NAME")
                                {
                                    find.name = reader.Value;
                                }
                                if (reader.Name == "SEX")
                                {
                                    find.sex = reader.Value;
                                }
                                if (reader.Name == "BREED")
                                {
                                    find.breed = reader.Value;
                                }
                                if (reader.Name == "AGE")
                                {
                                    find.age = reader.Value;
                                }
                                if (reader.Name == "VACCINATIONS")
                                {
                                    find.vac = reader.Value;
                                }
                            }
                            res.Add(find);
                        }
                        break;
                }
            }
            Lres = Filter(res, mySearch);
            return Lres;
        }

        private List<Cats> Filter(List<Cats> allres, Cats Temp)
        {
            List<Cats> newres = new List<Cats>();
            if(allres != null)
            {
                foreach(Cats s in allres)
                {
                    if((Temp.name == s.name || Temp.name == null) &&
                        (Temp.sex == s.sex || Temp.sex == null) &&
                        (Temp.age == s.age || Temp.age == null) &&
                        (Temp.breed == s.breed || Temp.breed == null) &&
                        (Temp.vac == s.name || Temp.vac == null))
                    {
                        newres.Add(s);
                    }
                }
            }
            return newres;
        }
    }
}
