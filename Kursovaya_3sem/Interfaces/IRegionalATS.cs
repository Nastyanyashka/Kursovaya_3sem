using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_3sem.Interfaces
{
    public interface IRegionalATS
    {
        public List<IRegionalATS> ConnectedRATS { get; set; }
       public  List<IATS> ToRedirectATSs { get; set; }
        public int Id { get;}
        public int MaximumLoad { get;}
        public void TakeCallFromATS(IATS idOfSender,int idOfReceiver);
        public void EndCall(IATS sender, int idOfConnectedAts);
        public int CurrentLoad { get; set; }
    }
}
