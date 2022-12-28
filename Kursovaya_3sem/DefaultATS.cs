using Kursovaya_3sem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Kursovaya_3sem
{
    public class DefaultATS : IATS
    {
        private static int idcounter = 0;
        private int id;
        private ChannelStatus channelStatus;
        private IRegionalATS connectedRATS;
        private double nextStartSignalTime;
        private double nextStopSignalTime;
        private static Random rnd = new Random();
        private int maxTimeOfCall = 100;
        private int idOfConnectedATS;
        private double chanceOfTakeCall;
        public int MaxTimeOfCall { get { return maxTimeOfCall; } set { maxTimeOfCall = value; } }
       
        public double ChanceOfTakeCall { get { return chanceOfTakeCall; } }
        public DefaultATS(IRegionalATS toConnectWith, double chanceOfTakeCall, int maxTimeOfCall)
        {
            id = idcounter;
            idcounter++;
            channelStatus = ChannelStatus.NotBusy;
            connectedRATS = toConnectWith;
            this.chanceOfTakeCall = chanceOfTakeCall/100;
            this.maxTimeOfCall = maxTimeOfCall;
            
        }
        public void GenerateNextSignalTime(double currentTime)
        {
            var t = rnd.NextDouble() * maxTimeOfCall;
            nextStartSignalTime = currentTime + t;

            nextStopSignalTime = nextStartSignalTime + t + rnd.NextDouble() * (maxTimeOfCall -t);
        }
        public bool CheckAndGenerate(double currentTime)
        {
            if(nextStopSignalTime <= currentTime && channelStatus == ChannelStatus.NotBusy)
            {
                GenerateNextSignalTime(currentTime);
                return true;
            }
            if (nextStopSignalTime <= currentTime && channelStatus == ChannelStatus.Busy)
            {
                GenerateNextSignalTime(currentTime);
                EndCall();
                return true;
            }
            if (nextStartSignalTime <= currentTime && nextStopSignalTime > currentTime && channelStatus == ChannelStatus.NotBusy)
            {
                MakeCall(idOfConnectedATS);
                
            }
            return false;
        }
        public int Id
        {
            get { return id; } }

        public ChannelStatus ChannelStatus { get { return channelStatus; } set {channelStatus = value; } }

        public IRegionalATS ConnectedRATS { get { return connectedRATS; } }

        public int IdOfConnectedAts { get { return idOfConnectedATS;} set { idOfConnectedATS = value;} }

        public void MakeCall(int idOfReceiver)
        {
          connectedRATS.TakeCallFromATS(this, idOfReceiver);
        }

        public void TakeCall(int idOfSender)
        {
            idOfConnectedATS = idOfSender;
        }

        public void EndCall()
        {
            this.connectedRATS.EndCall(this,idOfConnectedATS);
        }
    }
}
