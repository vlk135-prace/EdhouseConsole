using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdhouseConsole
{
    internal class Smajlici
    {
        public Smajlik Top { get; private set; }
        public Smajlik Right { get; private set; }
        public Smajlik Bot { get; private set; }
        public Smajlik Left { get; private set; }

        public int otoceni = 0;
        public int pole_cislo;

        public Smajlici(Smajlik top, Smajlik right, Smajlik bot, Smajlik left, int ID)
        {
            Top = top;
            Right = right;
            Bot = bot;
            Left = left;
            pole_cislo = ID;
        }

        public void Rotate()
        {
            Smajlik tmp = Top;
            Top = Right;
            Right = Bot;
            Bot = Left;
            Left = tmp;
            otoceni++;
            otoceni = otoceni % 4;
        }
    }
}
