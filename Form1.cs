using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerekenen_Click(object sender, EventArgs e)
        {
            float gewicht = float.Parse(txtGewicht.Text);
            float lengte = float.Parse(txtLengte.Text);
            float leeftijd = float.Parse(txtLeeftijd.Text);

            float BMI = 25;
            string advies = "hier komt advies";

            lblBMI.Text = BMI.ToString();
            lblAdvies.Text = advies;
        }
    }
}
