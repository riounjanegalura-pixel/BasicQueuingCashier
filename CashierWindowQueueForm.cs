using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CashierWindowQueueForm: Form
    {
        private System.Windows.Forms.Timer refreshTimer;
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 1000;
            refreshTimer.Tick += RefreshTimer_Tick; 
            refreshTimer.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();

            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string nextNumber = CashierClass.GetNextInQueue();

            if (nextNumber != null)
            {
                // Ipinapakita ang numero sa lblNowServing.
                // Siguraduhin na mayroon kang Label control na pinangalanang 'lblNowServing' sa iyong form.
                lblNowServing.Text = nextNumber;

                // I-refresh ang ListView para mawala ang natapos nang numero.
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
            else
            {
                // Ipakita ang mensaheng ito kung walang laman ang pila.
                lblNowServing.Text = "Done!";
            }


            /*string nextNumber = CashierClass.GetNextInQueue();

            if (nextNumber != null)
            {
                MessageBox.Show("Now Serving: " + nextNumber);

                DisplayCashierQueue(CashierClass.CashierQueue);
            }
            else
            {
                MessageBox.Show("Wala nang nakapila.");
            }*/
        }
    }
}
