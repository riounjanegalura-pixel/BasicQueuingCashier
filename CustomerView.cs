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
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();

            UpdateQueueDisplay();

            CashierClass.OnQueueChanged += UpdateQueueDisplay;
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            CashierClass.OnQueueChanged -= UpdateQueueDisplay;
        }

        private void UpdateQueueDisplay()
        {
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count > 0)
            {
                lblCurrentNumber.Text = CashierClass.CashierQueue.Peek();
            }
            else
            {
                lblCurrentNumber.Text = "           ";
            }
        }
    }
}
