﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _3.csapt_projekt.backend
{
    public class Save 
    {
        public short TimeMinut { get; set; } //játékidö perc ben
        public short Mep { get; set; }//pája sorszáma
        public short Score { get; set; }//öszegyüjtött pontok
        public short[] Top3 { get; set; }//3 legjobb eredmény

        public Save(short timeMinut, short mep, short score, short[] top3)
        {
            TimeMinut = timeMinut;
            Mep = mep;
            Score = score;
            if (top3[0] < score)
            {
                top3[0] = score;
                Top3[1] = top3[1];
                Top3[2] = top3[2];
            }
            else if (top3[1] < score)
            {
                top3[1] = score;
                Top3[0] = top3[0];
                Top3[2] = top3[2];
            }
            else if (top3[2] < score)
            {
                top3[2] = score;
                Top3[0] = top3[0];
                Top3[1] = top3[1];
            }
        }
        public bool ShaveFile(Save currentStatus, string svFile = "saves.json")
        {

            try
            {
                string json = JsonConvert.SerializeObject(currentStatus, Formatting.Indented);
                File.WriteAllText(svFile, json);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    
    }
}
    
