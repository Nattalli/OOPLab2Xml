using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
    public class Cats
    {
        public string name = null;
        public string sex = null;
        public string breed = null;
        public string age = null;
        public string vac = null;

        public Cats()
        {

        }
        public Cats(string[] data)
        {
            name = data[0];
            sex = data[1];
            breed = data[2];
            age = data[3];
            vac = data[4];
        }
        public bool Compare(Cats obj)
        {
            if ((this.name == obj.name) &&
                (this.sex == obj.sex) &&
                (this.breed == obj.breed) &&
                (this.age == obj.age) &&
                (this.vac == obj.vac))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
