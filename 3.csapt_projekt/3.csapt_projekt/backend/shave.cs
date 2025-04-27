//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Windows.Media.Media3D;


namespace _3.csapt_projekt.backend
{
    public class Shave //mentés fájl ját kezelö osztály

    {
       //ne hivogasd a konstruktort NINCS OJAN hogy NEW SHAVE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private static Shave _me; //hivatkozás Shave.me.ScoreLs.(lista fügvény)vagy Shave.me!!!!!!!!!!!!!!
        public static Shave Me { get {
            if (_me==null) _me=new Shave(); return _me;
            } }
        public class ScoreC
        {
            public int TimeMinut { get; set; } //játékidö perc ben
            public int Mep { get; set; }//pája sorszáma
            public int Score { get; set; }//öszegyüjtött pontok
        }
        public List<ScoreC> scoreLs { get; set; }=new List<ScoreC>();

        private Shave() 
        {
            if(scoreLs.Count == 0)
            {
                load();
            }
        }
        public bool ShaveFile( string svFile ="") 
        {
            if (svFile == "")
            {
                svFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "shave.json");
            }
            try
            {
                
               string json= JsonSerializer.Serialize<List<ScoreC>>(_me.scoreLs );
                File.WriteAllText(svFile, json);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void load(string svFile ="") 
        {
            if (svFile == "")
            {
                svFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "shave.json");
            }
            var data= File.ReadAllText(svFile);
            scoreLs = JsonSerializer.Deserialize<List<ScoreC>>(data);
            
        }
        public int[] roppscore ()// meghivás int[] topIndexes = manager.roppscore();
        {

            int[] top3ind = new int[3] { 0, 0, 0 };
            if (scoreLs.Count >= 3)
                for (int i = 0; i < scoreLs.Count; i++)
                {
                    if (scoreLs[i].TimeMinut< scoreLs[top3ind[0]].TimeMinut|| scoreLs[i].Mep > scoreLs[top3ind[0]].Mep)
                    {
                        top3ind[2] = top3ind[1];
                        top3ind[1] = top3ind[0];

                        top3ind[0] = i;
                    }
                    else if (scoreLs[i].TimeMinut < scoreLs[top3ind[1]].TimeMinut || scoreLs[i].Mep > scoreLs[top3ind[1]].Mep)
                    {

                        top3ind[2] = top3ind[1];
                        top3ind[1] = i;
                    }
                    else if (scoreLs[i].TimeMinut< scoreLs[top3ind[2]].TimeMinut || scoreLs[i].Mep > scoreLs[top3ind[2]].Mep)
                    {
                        top3ind[2] = i;
                    }

                    else if (scoreLs.Count == 2)
                    {
                        if (scoreLs[i].TimeMinut < scoreLs[top3ind[1]].TimeMinut || scoreLs[i].Mep > scoreLs[top3ind[1]].Mep)
                        {

                            top3ind[2] = top3ind[1];
                            top3ind[1] = i;
                        }
                        else if (scoreLs[i].TimeMinut < scoreLs[top3ind[2]].TimeMinut || scoreLs[i].Mep > scoreLs[top3ind[2]].Mep)
                        {
                            top3ind[2] = i;
                        }
                    }
                    else if (scoreLs.Count == 1)
                    {
                        if (scoreLs.Count == 2)
                        {
                            
                                top3ind[2] = i;
                            
                        }
                    }
                }
            switch (scoreLs.Count)
            {
                case 0:
                    top3ind[0] = -1;
                    top3ind[1] = -1;
                    top3ind[2] = -1;
                    break;
                case 1:
                    top3ind[1] = -1;
                    top3ind[2] = -1;
                    break;
                case 2:
                    top3ind[2] = -1;
                    break;
            }

            return top3ind;// a legjobb 3 indexe igy egyszerübb volt 
        }   

    }
}
    
