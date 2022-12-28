using Kursovaya_3sem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_3sem
{
    internal class DefaultRegionalATS : IRegionalATS
    {

        private List<IRegionalATS> connectedRATS;
        private List<IATS> toRedirectATSs;
        private static int idcounter = 0;
        private int id;
        private int maximumLoad;
        private int currentLoad;
        private static Random rnd = new Random();
        public DefaultRegionalATS(int maximumLoad)
        {
            id = idcounter;
            idcounter++; 
            this.maximumLoad = maximumLoad;
            connectedRATS = new List<IRegionalATS>();
            toRedirectATSs= new List<IATS>();
        }

        public List<IRegionalATS> ConnectedRATS { get { return connectedRATS; } set { if (value != null) connectedRATS = value; }  }
        public List<IATS> ToRedirectATSs { get { return toRedirectATSs; } set { if (value != null) toRedirectATSs = value;} }
        public int Id { get { return id; }}

        public int MaximumLoad { get { return maximumLoad; }}

        public void EndCall(int idOfConnectedATS)
        {
            foreach (IATS ats in toRedirectATSs)
            {
                if (ats.Id == idOfConnectedATS)
                {

                    ats.ChannelStatus = ChannelStatus.NotBusy;
                }
            }
            foreach (IRegionalATS RATS in connectedRATS)
            {
                foreach (IATS ats in RATS.ToRedirectATSs)
                {
                    if (ats.Id == idOfConnectedATS)
                    {
                        ats.ChannelStatus = ChannelStatus.NotBusy;
                    }
                }
            }
        }
        public void TakeCallFromATS(IATS idOfSender,int idOfReciever)
        {
            bool checker = false;
            foreach (IATS ats in toRedirectATSs)
            {
                if (ats.Id == idOfReciever)
                {
                  if (rnd.NextDouble() < ats.ChanceOfTakeCall)
                     ats.TakeCall(idOfSender.Id);
                  else
                  {
                     idOfSender.ChannelStatus = ChannelStatus.NotBusy;
                        checker = true; 
                     break;
                  }
                }
            }
            if (checker == false)
            {
                foreach (IRegionalATS RATS in connectedRATS)
                {
                    foreach (IATS ats in RATS.ToRedirectATSs)
                    {
                        if (ats.Id == idOfReciever)
                        {
                            if (rnd.NextDouble() < ats.ChanceOfTakeCall)
                                ats.TakeCall(idOfSender.Id);
                            else
                            {
                                idOfSender.ChannelStatus = ChannelStatus.NotBusy;
                                checker = true;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
