using System;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Launch : Form
    {
        public Launch()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value==100)
                timer1.Stop();
        }

        
    }
}
