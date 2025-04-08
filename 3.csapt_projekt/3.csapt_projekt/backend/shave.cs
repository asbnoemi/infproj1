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
       
        private static Shave _me; //hivatkozás Shave.me.ScoreLs.lista fügvény
        public static Shave Me { get {
            if (_me==null) _me=new Shave(); return _me;
            } }
        public class ScoreC
        {
            public short TimeMinut { get; set; } //játékidö perc ben
            public short Mep { get; set; }//pája sorszáma
            public short Score { get; set; }//öszegyüjtött pontok
        }
        public List<ScoreC> scoreLs { get; set; }=new List<ScoreC>();

        public Shave() { }
        public bool ShaveFile( string svFile ="")
        {
            if (svFile == "")
            {
                svFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "shave.json");
            }
            try
            {
                
               string json= JsonSerializer.Serialize<Shave>(_me );
                File.WriteAllText(svFile, json);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void load(string svFile ="") 
        {
            if (svFile == "")
            {
                svFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "shave.json");
            }
            Shave shave = JsonSerializer.Deserialize<Shave>(File.ReadAllText(svFile));
            _me = shave;
        }
        public Shave[] roppscore ()
        {
            load();
            Shave[] top3 = new Shave[3] ;
            int[] top3ind = new int[3] { 0, 0, 0 };
            for (int i = 0; i < scoreLs.Count; i++)
            {
                if (scoreLs[i].Score > scoreLs[top3ind[0]].Score)
                {
                    top3ind[0] = i;
                }
                    else if (scoreLs[i].Score > scoreLs[top3ind[1]].Score)
                    {
                        top3ind[1] = i;
                    }
                        else if (scoreLs[i].Score > scoreLs[top3ind[2]].Score)
                        {
                            top3ind[2] = i;
                        }
            }
            top3[0] = scoreLs[top3ind[0]];
            top3[1] = scoreLs[top3ind[1]];
            top3[2] = scoreLs[top3ind[2]];
            return top3;
        }   

    }
}
    
