namespace Personal_Expense_Tracker
{
    partial class TransactionHistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionHistory = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCategorySummary = new System.Windows.Forms.Label();
            this.chartSummary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(933, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(3, 28);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(204, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(3, 72);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(204, 20);
            this.dtpTo.TabIndex = 2;
            // 
            // lblTransactionHistory
            // 
            this.lblTransactionHistory.AutoSize = true;
            this.lblTransactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionHistory.Location = new System.Drawing.Point(20, 0);
            this.lblTransactionHistory.Name = "lblTransactionHistory";
            this.lblTransactionHistory.Size = new System.Drawing.Size(183, 24);
            this.lblTransactionHistory.TabIndex = 10;
            this.lblTransactionHistory.Text = "TransactionHistory";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(4, 7);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(48, 18);
            this.lblFrom.TabIndex = 13;
            this.lblFrom.Text = "Form:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(8, 51);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(30, 18);
            this.lblTo.TabIndex = 14;
            this.lblTo.Text = "To:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 104);
            this.panel1.TabIndex = 15;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(12, 51);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(63, 18);
            this.lblAmount.TabIndex = 17;
            this.lblAmount.Text = "Amount:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(15, 27);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 18;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(15, 72);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(154, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 46);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCategory);
            this.panel2.Controls.Add(this.lblAmount);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Location = new System.Drawing.Point(224, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 104);
            this.panel2.TabIndex = 21;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(12, 7);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 18);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "Category:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(759, 11);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(20, 13);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "\" \"";
            // 
            // lblCategorySummary
            // 
            this.lblCategorySummary.AutoSize = true;
            this.lblCategorySummary.Location = new System.Drawing.Point(499, 11);
            this.lblCategorySummary.Name = "lblCategorySummary";
            this.lblCategorySummary.Size = new System.Drawing.Size(20, 13);
            this.lblCategorySummary.TabIndex = 23;
            this.lblCategorySummary.Text = "\" \"";
            // 
            // chartSummary
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSummary.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSummary.Legends.Add(legend2);
            this.chartSummary.Location = new System.Drawing.Point(7, 378);
            this.chartSummary.Name = "chartSummary";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSummary.Series.Add(series2);
            this.chartSummary.Size = new System.Drawing.Size(300, 300);
            this.chartSummary.TabIndex = 24;
            this.chartSummary.Text = "chart1";
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Location = new System.Drawing.Point(372, 400);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(116, 52);
            this.btnExportPDF.TabIndex = 25;
            this.btnExportPDF.Text = "ExportPDF";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(802, 400);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 52);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Exit";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TransactionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(932, 532);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.chartSummary);
            this.Controls.Add(this.lblCategorySummary);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTransactionHistory);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TransactionHistoryForm";
            this.Text = "TransactionHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblTransactionHistory;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCategorySummary;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSummary;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnBack;
    }
}