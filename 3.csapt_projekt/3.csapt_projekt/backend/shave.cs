//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace _3.csapt_projekt.backend
{
    public class Shave //mentés fájl ját kezelö osztály

    {
        const string filename = @"c:\temp\shave.json";//proba bekek még alitani
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
        public bool ShaveFile( string svFile =filename)
        {

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
        public void load(string svFile =filename) 
        {
            Shave shave = JsonSerializer.Deserialize<Shave>(File.ReadAllText(svFile));
            _me = shave;
        }
    
    }
}
    
