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
        const string filename = @"c:\Temp\Quest.json";//proba bekek még alitani
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
            public int id { get; set; }
            public string question { get; set; } 
            //public List<string> options { get; set; }
            public string answer { get; set; }
            public int rank { get; set; }
        }
        public List<qestsC> questions { get; set; } = new List<qestsC>();
        public QuestRead() { }
        public void load(string qFile = filename)
        {
           string readall = File.ReadAllText(qFile);
            QuestRead questRead = JsonSerializer.Deserialize<QuestRead>(readall);

            _meQ = questRead;
        }
        public bool Qestverification(string sign,int id) 
        {
            var res = questions.Find(x => x.id == id);
            return res.answer == sign;
                
                
        }
        public qestsC randQestGen(int rank) 
        {
            int lastid= questions[questions.Count - 1].id;
            Random random = new Random();   
            int newQ=random.Next(1,lastid);
            while (questions[newQ].rank != rank)
            {  
                newQ++;
            }

            return questions[newQ];
        }
    }
}
