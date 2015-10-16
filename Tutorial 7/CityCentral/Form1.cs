using System;
using System.Windows.Forms;

namespace CityCentral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //event handlers should be here
        private void openCitiesButton1_Click(object sender, EventArgs e)
        {
            if (openCityDialog.ShowDialog() == DialogResult.OK)
            {
                CityArray ca = new CityArray(openCityDialog.FileName);
                textBox1.Text = ca.ToString() + Environment.NewLine + "City closest to center = " + ca.FindCentralCity();
            }
        }

    }
}
