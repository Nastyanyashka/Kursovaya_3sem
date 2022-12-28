using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_3sem.Interfaces
{
    public interface IATS
    {
        public void GenerateNextSignalTime(double currentTime);
        public bool CheckAndGenerate(double currentTime);
        int Id { get; }
        public int MaxTimeOfCall { get; set; }
        public int IdOfConnectedAts { get; set; }
        ChannelStatus ChannelStatus { get; set; }
        IRegionalATS ConnectedRATS { get; }
        public double ChanceOfTakeCall { get; }
        public void MakeCall(int idOfReceiver);
        public void TakeCall(int idOfSender);

        public void EndCall();
    }
}
