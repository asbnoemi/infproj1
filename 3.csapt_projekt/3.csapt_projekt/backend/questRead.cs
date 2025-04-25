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
            public List<string> options { get; set; }
            public string answer { get; set; }
            public int rank { get; set; }
        }
        public List<qestsC> questions { get; set; } = new List<qestsC>();
        public QuestRead() { }
        public void load(string qFile = "")
        {
            if (qFile == "")
            {
                qFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Quest.json");
            }
            
            string readall = File.ReadAllText(qFile);
            QuestRead questRead = JsonSerializer.Deserialize<QuestRead>(readall);

            _meQ = questRead;
        }
        public ValueTuple<bool, int,int> Qestverification(string sign,int id,int vpoint, int fault) 
        {
            bool fc = false;
            int point = vpoint;
            int faultpoint = fault;
            var res = questions.Find(x => x.id == id);
            if (res.answer == sign)
            {
                fc = true;
                point = vpoint+1;      
            }
            else
            {
                fc = false;
                faultpoint = fault+1;
                point = vpoint -1;

            } 
                
            return (fc,point,faultpoint);
                
                
        }
        public qestsC randQestGen(int rank) 
        {

            int lastid= questions[questions.Count - 1].id;
            Random random = new Random();   
            int newQ=random.Next(1,lastid);
            do
            {
                if (questions[newQ].rank == rank) 
                {
                    return questions[newQ];
                    
                }
                else
                {
                    newQ++;
                    if (newQ >= questions.Count)
                    { newQ = 0; } //vissza az elejére ha elérte a végét
                }
            } while (newQ < rank);
            
            return questions[newQ];
        }
    }
}
