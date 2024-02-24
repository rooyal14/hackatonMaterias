using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Professor
    {
        private string id;
        private Preferencias preferencias;

        public Professor(string id)
        {
            this.id = id;
            this.preferencias = new Preferencias();
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public Preferencias Preferencias
        {
            get { return preferencias; }
            set { preferencias = value; }
        }


    }
}
