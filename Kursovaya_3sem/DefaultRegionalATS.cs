using Kursovaya_3sem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_3sem
{
    public class DefaultRegionalATS : IRegionalATS
    {

        private List<IRegionalATS> connectedRATS;
        private List<IATS> toRedirectATSs;
        private static int idcounter = 0;
        private int id;
        private int maximumLoad;
        private int currentLoad = 0;
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
        public int CurrentLoad { get { return currentLoad; } set { currentLoad = value; } }

        public void EndCall(IATS sender,int idOfConnectedATS)
        {
            bool checker = false;
            foreach (IATS ats in toRedirectATSs)
            {
                if (ats.Id == idOfConnectedATS)
                {
                    currentLoad--;
                    sender.ChannelStatus = ChannelStatus.NotBusy;
                    ats.ChannelStatus = ChannelStatus.NotBusy;
                    checker = true;
                    break;
                }
            }
            if (checker == false)
            {
                foreach (IRegionalATS RATS in connectedRATS)
                {
                    foreach (IATS ats in RATS.ToRedirectATSs)
                    {
                        if (ats.Id == idOfConnectedATS)
                        {
                            currentLoad--;
                            RATS.CurrentLoad--;
                            sender.ChannelStatus = ChannelStatus.NotBusy;
                            ats.ChannelStatus = ChannelStatus.NotBusy;
                            break;
                        }
                    }
                }
            }
            }
            public void TakeCallFromATS(IATS idOfSender,int idOfReciever)
        {
            bool checker = false;
            foreach (IATS ats in toRedirectATSs)
            {
                if (ats.Id == idOfReciever && ats.ChannelStatus == ChannelStatus.NotBusy)
                {
                    if (rnd.NextDouble() < ats.ChanceOfTakeCall)//попытка дозвониться с шансом
                    {
                        ats.TakeCall(idOfSender.Id);
                        ats.ChannelStatus = ChannelStatus.Busy;
                        idOfSender.ChannelStatus = ChannelStatus.Busy;
                        currentLoad++;
                        checker = true;
                        break;
                    }
                    else
                    {
                        checker = true;
                        break;
                    }
                }
                else if(ats.Id == idOfReciever && ats.ChannelStatus ==ChannelStatus.Busy)//попытка позвонить но занято
                {
                    checker = true;
                    break;
                }
            }
            if (checker == false)
            {
                foreach (IRegionalATS RATS in connectedRATS)
                {
                    foreach (IATS ats in RATS.ToRedirectATSs)
                    {
                        if (ats.Id == idOfReciever && ats.ChannelStatus == ChannelStatus.NotBusy)
                        {
                            if (rnd.NextDouble() < ats.ChanceOfTakeCall)
                            {
                                ats.TakeCall(idOfSender.Id);
                                ats.ChannelStatus = ChannelStatus.Busy;
                                idOfSender.ChannelStatus = ChannelStatus.Busy;
                                currentLoad++;
                                RATS.CurrentLoad++;
                                checker = true;
                                break;
                            }
                            else
                            {
                                checker = true;
                                break;
                            }
                        }
                        else if (ats.Id == idOfReciever && ats.ChannelStatus == ChannelStatus.Busy)
                        {
                            checker = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
