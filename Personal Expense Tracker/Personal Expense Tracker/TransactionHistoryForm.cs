using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Personal_Expense_Tracker
{
    public partial class TransactionHistoryForm : Form
    {
        public TransactionHistoryForm()
        {
            InitializeComponent();
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged; // Ensure event hookup
        }

        private void TransactionHistoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();     // Load mock categories first
            LoadTransactions();   // Load all mock data
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");
            cmbCategory.Items.Add("Food");
            cmbCategory.Items.Add("Transport");
            cmbCategory.Items.Add("Bills");
            cmbCategory.Items.Add("Snacks");

            cmbCategory.SelectedIndex = 0;  // Select "All" by default
        }

        private void LoadTransactions(string filter = "")
        {
            // Create mock transaction data
            DataTable table = new DataTable();
            table.Columns.Add("Amount", typeof(decimal));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("PaymentMethod", typeof(string));

            // Sample mock rows
            table.Rows.Add(500.00m, DateTime.Today, "Food", "Cash");
            table.Rows.Add(1200.00m, DateTime.Today.AddDays(-1), "Transport", "Credit Card");
            table.Rows.Add(800.00m, DateTime.Today.AddDays(-3), "Bills", "Online");
            table.Rows.Add(200.00m, DateTime.Today.AddDays(-5), "Snacks", "GCash");
            table.Rows.Add(150.00m, DateTime.Today.AddDays(-2), "Food", "Cash");

            // Start filtering
            var filteredRows = table.AsEnumerable();

            // Filter: Date range
            filteredRows = filteredRows.Where(row =>
                row.Field<DateTime>("Date") >= dtpFrom.Value.Date &&
                row.Field<DateTime>("Date") <= dtpTo.Value.Date);

            // Filter: Category (skip "All")
            if (cmbCategory.SelectedItem != null && cmbCategory.SelectedItem.ToString() != "All")
            {
                string selectedCategory = cmbCategory.SelectedItem.ToString();
                filteredRows = filteredRows.Where(row =>
                    row.Field<string>("Category").Equals(selectedCategory, StringComparison.OrdinalIgnoreCase));
            }

            // Filter: Amount range or exact
            string amountText = txtAmount.Text.Trim();
            if (!string.IsNullOrEmpty(amountText))
            {
                if (amountText.Contains("-"))
                {
                    var parts = amountText.Split('-');
                    if (parts.Length == 2 &&
                        decimal.TryParse(parts[0].Trim(), out decimal minAmount) &&
                        decimal.TryParse(parts[1].Trim(), out decimal maxAmount))
                    {
                        filteredRows = filteredRows.Where(row =>
                            row.Field<decimal>("Amount") >= minAmount &&
                            row.Field<decimal>("Amount") <= maxAmount);
                    }
                    else
                    {
                        MessageBox.Show("Invalid amount range format. Use min-max, e.g. 100-500.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (decimal.TryParse(amountText, out decimal amount))
                    {
                        filteredRows = filteredRows.Where(row =>
                            row.Field<decimal>("Amount") == amount);
                    }
                    else
                    {
                        MessageBox.Show("Invalid amount value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            // Convert back to DataTable safely
            DataTable filteredTable;
            if (filteredRows.Any())
            {
                filteredTable = filteredRows.CopyToDataTable();
            }
            else
            {
                filteredTable = table.Clone(); // Empty table with same structure
            }

            // Display in DataGridView
            dataGridView1.DataSource = filteredTable;

            // Update summary labels
            UpdateSummary(filteredTable);

            // Update chart
            UpdateChart(filteredTable);
        }

        private void UpdateSummary(DataTable table)
        {
            decimal total = 0;
            var summary = new StringBuilder();

            var groups = table.AsEnumerable()
                .GroupBy(row => row.Field<string>("Category"));

            foreach (var group in groups)
            {
                decimal categoryTotal = group.Sum(row => row.Field<decimal>("Amount"));
                total += categoryTotal;
                summary.AppendLine($"{group.Key}: ₱{categoryTotal:N2}");
            }

            lblTotal.Text = $"Total Spending: ₱{total:N2}";
            lblCategorySummary.Text = summary.Length > 0 ? summary.ToString() : "No data to summarize.";
        }

        private void UpdateChart(DataTable table)
        {
            chartSummary.Series.Clear();
            chartSummary.ChartAreas.Clear();

            var chartArea = new ChartArea();
            chartSummary.ChartAreas.Add(chartArea);

            var series = new Series
            {
                Name = "SpendingByCategory",
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelFormat = "₱{0:N2}"
            };

            chartSummary.Series.Add(series);

            var groups = table.AsEnumerable()
                .GroupBy(row => row.Field<string>("Category"));

            foreach (var group in groups)
            {
                decimal totalAmount = group.Sum(row => row.Field<decimal>("Amount"));
                series.Points.AddXY(group.Key, totalAmount);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadTransactions();  // Reload with filters applied
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpenseTracker main = new ExpenseTracker();
            main.Show();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTransactions();  // Filter immediately on category change
        }
    }
}
