using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EdhouseConsole
{
    internal class Hlavolam
    {

        static public bool Kontrola(List<Smajlici> pole, int x, int y)
        {
            if (pole.Count == 1)
            {
                return true;
            }

            int LastIndex = pole.Count;
            if (LastIndex-1 % 3 != 0)
            {
                if (pole[LastIndex - 1].Left.barva != pole[LastIndex - 2].Right.barva || pole[LastIndex - 1].Left.castSmajlika == pole[LastIndex - 2].Right.castSmajlika)
                {
                    return false;
                }
            }
            if(LastIndex > 3)
            {
                if (pole[LastIndex - 1].Top.barva != pole[LastIndex - 4].Bot.barva || pole[LastIndex - 1].Top.castSmajlika == pole[LastIndex - 4].Bot.castSmajlika)
                {
                    return false;
                }
            }
            return true;
        }
        static public List<Smajlici> Reseni(List<Smajlici> pole, List<Smajlici> Hra, int X, int Y, bool vypis = false)
        {
            for (int i = 0; i < pole.Count; i++) 
            {
                if (Hra.Contains(pole[i])) continue;
                if (vypis)
                {
                    foreach (Smajlici h in Hra) Console.Write(h.pole_cislo + ">");
                    Console.WriteLine();
                }

                Hra.Add(pole[i]);
                if (Hra.Count == 1)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Hra = Reseni(pole,Hra,X,Y,vypis);
                        if(Hra.Count == 9) return Hra;
                        else
                        {
                            Hra[0].Rotate();
                        }
                    }
                    Hra.RemoveAt(Hra.Count - 1);
                }
                else
                {
                    for(int j = 0;j < 4; j++)
                    {
                        if(Hra.Count == 9 && Kontrola(Hra, X, Y)) {return Hra;}
                        if (Kontrola(Hra, X, Y) == false) Hra[Hra.Count - 1].Rotate();
                        else Reseni(pole, Hra, X, Y, vypis);
                    }
                    Hra.RemoveAt(Hra.Count - 1);
                }
            }
            return Hra;
        }
    }
}
