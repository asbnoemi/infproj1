﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.csapt_projekt.backend
{
    public static class appfunction
    {

        public static int WinLous { get; set; }
        public static int maxpoint { get; set; } = 1;
        public static int maxfault { get; set; } = 10;

        //public static appfunction.win actualvin { get;set } = new appfunction.win();
        public static int Victori(int maxpoint, int maxfault, int actualpoint, int actualfauli)
        {
            int actual = 0;//0=nincs vége 1=nyert 2=vesztett
            if (actualpoint >= maxpoint)
            {
                actual = 1; //nyert
            }
            else if (actualfauli >= maxfault)
            {
                actual = 2; //vesztett
            }
            else
            {
                actual = 0; //nincs vége
            }

            return actual;
        }
       




    }
}
