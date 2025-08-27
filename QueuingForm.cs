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
        //private CashierClass cashier;
        private int counter = 10000;
        public QueuingForm()
    {
        InitializeComponent();
        //cashier = new CashierClass();
    }

    private void btnCashier_Click(object sender, EventArgs e)
        {
            string queueNumber = GenerateQueueNumber();
            lblQueue.Text = queueNumber;

            CashierClass.AddToQueue(queueNumber);

            /*string queueNumber = GenerateQueueNumber();
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

        private void btnOpenQueueForm_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm queueForm = new CashierWindowQueueForm();
            queueForm.Show();
        }
    } 
}
