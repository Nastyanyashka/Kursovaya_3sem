using Kursovaya_3sem;
namespace Kursovaya_GPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            List<DefaultRegionalATS> list = new List<DefaultRegionalATS>(); 
            DefaultRegionalATS RATS1 = new DefaultRegionalATS(Convert.ToInt32(textBoxMaxLoadRATS.Text));
            DefaultRegionalATS RATS2 = new DefaultRegionalATS(Convert.ToInt32(textBoxMaxLoadRATS.Text));
            DefaultRegionalATS RATS3 = new DefaultRegionalATS(Convert.ToInt32(textBoxMaxLoadRATS.Text));
            list.Add(RATS1);
            list.Add(RATS2);
            list.Add(RATS3);    
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 100; j++)
                {
                    list[i].ToRedirectATSs.Add(new DefaultATS(list[i], Convert.ToDouble(textBoxChanceOfTakeCall.Text), Convert.ToInt32(textBoxMaxTimeOfCall.Text)));
                }
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            var dt = double.Parse(textBoxDeltaT.Text);
        }
    }
}