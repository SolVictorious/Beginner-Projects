using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectoOriantedProgramming
{
    class jobs
    {
        public string jobName;
        int Str,Int,Wis,End,HP,MP;
        public jobs(string jobname ,int str,int mind,int wis,int end)
        {
            this.jobName = jobname;
            this.Str = str; this.Int = mind; this.Wis = wis; this.End = end;
            this.HP = End * 10; this.MP = Int * 2;
        }

        public void Description()
        {
            Console.WriteLine("============================");
            Console.WriteLine(jobName);
            Console.WriteLine("Health Points {0} , Mana Points {1} ",HP,MP);
            Console.WriteLine("Strength is {0} ,\nIntelligence is {1}\nWisdom is {2}\nEndurance is {3}",Str,Int,Wis,End);
            Console.WriteLine("=============================");

        }

        
    }
}
