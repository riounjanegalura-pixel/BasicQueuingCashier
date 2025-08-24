using System;
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
    public partial class QueuingForm: Form
    {
        private int counter = 10000;
        //private CashierClass cashier;
        public QueuingForm()
    {
        InitializeComponent();
        //cashier = new CashierClass();
    }

    private void btnCashier_Click(object sender, EventArgs e)
    {
            string queueNumber = GenerateQueueNumber();
            lblQueue.Text = queueNumber;

            CashierClass.CashierQueue.Enqueue(queueNumber);

            /*lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);*/
        }

        private string GenerateQueueNumber()
        {
            counter++;
            return "P - " + counter.ToString();
        }
    } 
}
