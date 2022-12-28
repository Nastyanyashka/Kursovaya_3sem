using Kursovaya_3sem;
using Kursovaya_3sem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Kursovaya_GPI
{
    class Modeler
    {
        private double time = 0;
        List<DefaultRegionalATS> list = new List<DefaultRegionalATS>();
        public Modeler(List<DefaultRegionalATS> list) { 
            this.list = list;
        }

       public  List<DefaultRegionalATS> List { get { return list; } }

        public void Run(double dt)
        {
            for(int i = 0; i < list.Count; i++)
            {
                for(int j = 0; j < list[i].ToRedirectATSs.Count;j++)
                {
                   list[i].ToRedirectATSs[j].CheckAndGenerate(time);
                }
            }
            time += dt;
        }
    }

}

