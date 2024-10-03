using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdhouseConsole
{
    internal class Smajlik
    {
        public string barva { private set; get; }
        public string castSmajlika { private set; get; }

        public Smajlik(string barva, string castSmajlika)
        {
            this.barva = barva;
            this.castSmajlika = castSmajlika;
        }
    }
}
