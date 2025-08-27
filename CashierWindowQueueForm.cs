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
            CashierClass.OnQueueChanged += UpdateQueueDisplay;
            UpdateQueueDisplay();
            
           /* refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 1000;
            refreshTimer.Tick += RefreshTimer_Tick; 
            refreshTimer.Start(); */
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
             UpdateQueueDisplay();
            //DisplayCashierQueue(CashierClass.CashierQueue);
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

            /*if (nextNumber != null)
            {
                lblNowServing.Text = nextNumber;

                DisplayCashierQueue(CashierClass.CashierQueue);
            }
            else
            {
                lblNowServing.Text = "                ";
            }*/


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

        private void CashierWindowQueueForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CashierClass.OnQueueChanged -= UpdateQueueDisplay;
        }

        private void UpdateQueueDisplay()
        {
            listCashierQueue.Items.Clear();

            foreach (Object obj in CashierClass.CashierQueue)
            {
                listCashierQueue.Items.Add(new ListViewItem(obj.ToString()));
            }
        }
    }
}
