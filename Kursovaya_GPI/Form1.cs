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

        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            var dt = double.Parse(textBoxDeltaT.Text);
        }
    }
}