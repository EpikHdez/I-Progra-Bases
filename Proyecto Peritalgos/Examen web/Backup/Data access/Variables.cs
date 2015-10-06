using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_web.Data_access
{
    [Serializable]

    public class Variables
    {
        private string horas = "1";

        public string Horas
        {
            get { return horas; }
            set { horas = value; }
        }

        private string min = "59";

        public string Min
        {
            get { return min; }
            set { min = value; }
        }

        private string seg = "59";

        public string Seg
        {
            get { return seg; }
            set { seg = value; }
        }
    }
}