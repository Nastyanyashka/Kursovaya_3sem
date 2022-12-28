using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_3sem.Interfaces
{
    internal interface IATS
    {
        int Id { get; }
        ChannelStatus ChannelStatus { get; set; }
        IRegionalATS ConnectedRATS { get; }
        public double ChanceOfTakeCall { get; }
        public void MakeCall(int idOfReceiver);
        public void TakeCall(int idOfSender);

        public void EndCall();
    }
}
