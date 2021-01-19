using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SentimentAnalysisConsoleApp;

namespace IDPA
{
    public partial class SentimentForm : Form
    {
        public SentimentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Working";
            var result = SentimentPredictor.Predict(txtInsert.Text);
            lblOutput.Text = $"Prediction: {(Convert.ToBoolean(result.Prediction) ? "Toxic" : "Non Toxic")} sentiment | Probability of being toxic: {result.Probability} | Score: {result.Score}";
        }
    }
}
