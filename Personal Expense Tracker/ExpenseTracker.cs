using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Expense_Tracker
{
    public partial class ExpenseTracker: Form
    {
        public ExpenseTracker()
        {
            InitializeComponent();
        }

        private void ExpenseTracker_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Tracker = new Tracker();
            Tracker.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form goalTracker = new GoalTracker();
            goalTracker.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form subtracker = new SubscriptionTracker();
            subtracker.Show();
        }

        private void btnViewTransactions_Click(object sender, EventArgs e)
        {
            // Open Transaction History Form
            this.Hide();  // Hide this form
            TransactionHistoryForm historyForm = new TransactionHistoryForm();
            historyForm.Show();  // Show the transaction history form
        }
    }
}
