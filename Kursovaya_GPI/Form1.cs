using Kursovaya_3sem;
using System.CodeDom.Compiler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Kursovaya_GPI
{
    public partial class Form1 : Form
    {
        DefaultRegionalATS RATS1;
        DefaultRegionalATS RATS2;
        DefaultRegionalATS RATS3;
        List<DefaultRegionalATS> list;
        List<Modeler> models = new List<Modeler>();
        int maxLoad;
        bool checker= false;
        List<double> meanLoadRATS = new List<double>() { 0, 0, 0 };
        List<double> summMeanLoadRATS = new List<double> { 0, 0, 0 };
        List<int> countOfLoadRATS = new List<int> { 0, 0, 0 };

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            maxLoad = Convert.ToInt32(textBoxMaxLoadRATS.Text);
            for (int amountofmodels = 0; amountofmodels < Convert.ToInt32(textBoxAmountOfModels.Text); amountofmodels++)
            {
                List<DefaultRegionalATS> list = new List<DefaultRegionalATS>();
                RATS1 = new DefaultRegionalATS(maxLoad);
                RATS2 = new DefaultRegionalATS(maxLoad);
                RATS3 = new DefaultRegionalATS(maxLoad);
                RATS1.ConnectedRATS.Add(RATS2);
                RATS1.ConnectedRATS.Add(RATS3);
                RATS2.ConnectedRATS.Add(RATS1);
                RATS2.ConnectedRATS.Add(RATS3);
                RATS3.ConnectedRATS.Add(RATS2);
                RATS3.ConnectedRATS.Add(RATS1);
                list.Add(RATS1);
                list.Add(RATS2);
                list.Add(RATS3);
                Random rand = new Random();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 100; j++)//300 номеров
                    {
                        DefaultATS dATS = new DefaultATS(list[i], Convert.ToDouble(textBoxChanceOfTakeCall.Text), Convert.ToInt32(textBoxMaxTimeOfCall.Text));
                        dATS.IdOfConnectedAts = rand.Next(0, 300);
                        list[i].ToRedirectATSs.Add(dATS);
                    }
                }
                Modeler newmodel = new Modeler(list);
                models.Add(newmodel);
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (models.Count != 0)
            {
                double dt;
                dt = double.Parse(textBoxDeltaT.Text);
                foreach (Modeler model in models)
                {
                        model.Run(dt);
                        meanLoadRATS[0] = model.List[0].CurrentLoad / (double)maxLoad;
                        meanLoadRATS[1] = model.List[1].CurrentLoad / (double)maxLoad;
                        meanLoadRATS[2] = model.List[2].CurrentLoad / (double)maxLoad;
                        summMeanLoadRATS[0] += meanLoadRATS[0];
                        countOfLoadRATS[0]++;
                        summMeanLoadRATS[1] += meanLoadRATS[1];
                        countOfLoadRATS[1]++;
                        summMeanLoadRATS[2] += meanLoadRATS[2];
                        countOfLoadRATS[2]++;   
                }
               
                labelLoadOfFirstRATS.Text = "Mean Load of 1st RATSs: " + (summMeanLoadRATS[0] / countOfLoadRATS[0]).ToString();
                labelLoadOfSecondRATS.Text = "Mean Load of 2st RATSs: " + (summMeanLoadRATS[1] / countOfLoadRATS[1]).ToString();
                labelLoadOfThirdRATS.Text = "Mean Load of 3st RATSs: " + (summMeanLoadRATS[2] / countOfLoadRATS[2]).ToString();
                if(summMeanLoadRATS[0] / countOfLoadRATS[0] >1 || summMeanLoadRATS[1] / countOfLoadRATS[1]>1 || summMeanLoadRATS[2] / countOfLoadRATS[2]>1)
                {
                    MessageBox.Show("One of stations is overloaded");
                    timerUpdate.Enabled = false;
                }
            }
        }
    }
}