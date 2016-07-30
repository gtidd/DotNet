using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indweek4ExceptionHandling
{
    public partial class ExceptionHandling : Form
    {
        public ExceptionHandling()
        {
            InitializeComponent(); //starts form
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            int value = 10 / int.Parse("2"); //simple division
            lblRunNormal.Text = value.ToString(); // output
        }

        private void btnRegExp_Click(object sender, EventArgs e)
        {
            try
            {
                int value = 1 / int.Parse("0"); //throws exception if cannot divide 
                lblRunNormal.Text = value.ToString();
            }
            catch (Exception ex)
            {
                lblRunNormal.Text = ex.Message; //General message
            }
        }

        private void btnCustEx_Click(object sender, EventArgs e)
        {
            try
            {
                throw new ExceptionTest(); //throws exception if cannot divide
                int value = 1 / int.Parse("0");  
                lblRunNormal.Text = value.ToString();
            }
            catch (ExceptionTest ex)
            {
                lblRunNormal.Text = ex.Message;
            }
        }
    }
}
