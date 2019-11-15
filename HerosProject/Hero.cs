using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosProject
{
    class Hero
    {
        private String _name;
        private String _locale;
        public Hero(String name, String locale)
        {
            _name = name;
            _locale = locale;
        }

        public override string ToString()
        {
            return "Name\t\t: "+_name+"\nLocale\t\t: "+_locale;
        }
        public string Name { get => _name; set => _name = value; }
        public string Locale { get => _locale; set => _locale = value; }

        public void Save (int DangeredPeople)
        {
            return;
        }
    }
}
