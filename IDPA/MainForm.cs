using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDPA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSentiment_Click(object sender, EventArgs e)
        {
            SentimentForm sentiment = new SentimentForm();
            sentiment.Show();
            this.Hide();
        }
    }
}
