using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace _3.csapt_projekt.backend
{
    public class QuestRead 
    {
        const string filename = @"c:\temp\Quest.json";//proba bekek még alitani
        private static QuestRead _meQ; //hivatkozás QuestRead.me.ScoreLs.lista fügvény
        public static QuestRead MeQ
        {
            get
            {
                if (_meQ == null) _meQ = new QuestRead(); return _meQ;
            }
        }
        public class qestsC
        {
            public string Qest { get; set; } 
            public string solution1 { get; set; }
            public  string solution2 { get; set; }
            public string solution3 { get; set; }
            public string solution4 { get; set; }
            public string Goodsolution { get; set; }
            public int Rank { get; set; }
            public int Id { get; set; }
        }
        public List<qestsC> QestLs { get; set; } = new List<qestsC>();
        public QuestRead() { }
        public void load(string qFile = filename)
        {
            QuestRead questRead = JsonSerializer.Deserialize<QuestRead>(File.ReadAllText(qFile));
            _meQ = questRead;
        }
        public bool Qestverification(string sign,int id) 
        {
            var res = QestLs.Find(x => x.Id == id);
            return res.Goodsolution == sign;
                
                
        }
        public qestsC randQestGen(int rank) 
        {
            int lastid= QestLs[QestLs.Count - 1].Id;
            Random random = new Random();   
            int newQ=random.Next(1,lastid);
            while (QestLs[newQ].Rank != rank)
            {  
                newQ++;
            }

            return QestLs[newQ];
        }
    }
}
