
namespace WindowsFormsApp2
{
    partial class DrinksStockForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DrinksLiter = new System.Windows.Forms.ComboBox();
            this.DrinksNames = new System.Windows.Forms.ComboBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.deleteFromStock = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DrinksPrice = new System.Windows.Forms.TextBox();
            this.DrinksQun = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DrinksName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BillingBtn = new System.Windows.Forms.Label();
            this.GummyBtn = new System.Windows.Forms.Label();
            this.SnaksBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.DrinksLiter);
            this.panel1.Controls.Add(this.DrinksNames);
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Controls.Add(this.deleteFromStock);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.DrinksPrice);
            this.panel1.Controls.Add(this.DrinksQun);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.DrinksName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BillingBtn);
            this.panel1.Controls.Add(this.GummyBtn);
            this.panel1.Controls.Add(this.SnaksBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(37, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 508);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DrinksLiter
            // 
            this.DrinksLiter.FormattingEnabled = true;
            this.DrinksLiter.Items.AddRange(new object[] {
            "1",
            "0.750"});
            this.DrinksLiter.Location = new System.Drawing.Point(904, 147);
            this.DrinksLiter.Name = "DrinksLiter";
            this.DrinksLiter.Size = new System.Drawing.Size(153, 39);
            this.DrinksLiter.TabIndex = 23;
            // 
            // DrinksNames
            // 
            this.DrinksNames.FormattingEnabled = true;
            this.DrinksNames.Items.AddRange(new object[] {
            "Cola"});
            this.DrinksNames.Location = new System.Drawing.Point(330, 147);
            this.DrinksNames.Name = "DrinksNames";
            this.DrinksNames.Size = new System.Drawing.Size(153, 39);
            this.DrinksNames.TabIndex = 22;
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.ForestGreen;
            this.Refresh.FlatAppearance.BorderSize = 0;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.Location = new System.Drawing.Point(737, 229);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(144, 39);
            this.Refresh.TabIndex = 21;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // deleteFromStock
            // 
            this.deleteFromStock.AutoSize = true;
            this.deleteFromStock.Location = new System.Drawing.Point(57, 425);
            this.deleteFromStock.Name = "deleteFromStock";
            this.deleteFromStock.Size = new System.Drawing.Size(235, 31);
            this.deleteFromStock.TabIndex = 20;
            this.deleteFromStock.Text = "Delete From Stock";
            this.deleteFromStock.Click += new System.EventHandler(this.deleteFromStock_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(378, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(630, 188);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(524, 229);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(144, 39);
            this.EditBtn.TabIndex = 16;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(318, 229);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(144, 39);
            this.SaveBtn.TabIndex = 15;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DrinksPrice
            // 
            this.DrinksPrice.Location = new System.Drawing.Point(727, 147);
            this.DrinksPrice.Name = "DrinksPrice";
            this.DrinksPrice.Size = new System.Drawing.Size(154, 39);
            this.DrinksPrice.TabIndex = 13;
            // 
            // DrinksQun
            // 
            this.DrinksQun.Location = new System.Drawing.Point(537, 147);
            this.DrinksQun.Name = "DrinksQun";
            this.DrinksQun.Size = new System.Drawing.Size(154, 39);
            this.DrinksQun.TabIndex = 12;
            this.DrinksQun.TextChanged += new System.EventHandler(this.DrinksQun_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(914, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 31);
            this.label9.TabIndex = 9;
            this.label9.Text = "Liter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(725, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Quantity";
            // 
            // DrinksName
            // 
            this.DrinksName.AutoSize = true;
            this.DrinksName.Location = new System.Drawing.Point(336, 113);
            this.DrinksName.Name = "DrinksName";
            this.DrinksName.Size = new System.Drawing.Size(86, 31);
            this.DrinksName.TabIndex = 6;
            this.DrinksName.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Location = new System.Drawing.Point(63, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 5);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Add to stock:";
            // 
            // BillingBtn
            // 
            this.BillingBtn.AutoSize = true;
            this.BillingBtn.Location = new System.Drawing.Point(57, 113);
            this.BillingBtn.Name = "BillingBtn";
            this.BillingBtn.Size = new System.Drawing.Size(90, 31);
            this.BillingBtn.TabIndex = 3;
            this.BillingBtn.Text = "Billing";
            this.BillingBtn.Click += new System.EventHandler(this.BillingBtn_Click);
            // 
            // GummyBtn
            // 
            this.GummyBtn.AutoSize = true;
            this.GummyBtn.Location = new System.Drawing.Point(57, 370);
            this.GummyBtn.Name = "GummyBtn";
            this.GummyBtn.Size = new System.Drawing.Size(110, 31);
            this.GummyBtn.TabIndex = 2;
            this.GummyBtn.Text = "Gummy";
            this.GummyBtn.Click += new System.EventHandler(this.GummyBtn_Click);
            // 
            // SnaksBtn
            // 
            this.SnaksBtn.AutoSize = true;
            this.SnaksBtn.Location = new System.Drawing.Point(57, 311);
            this.SnaksBtn.Name = "SnaksBtn";
            this.SnaksBtn.Size = new System.Drawing.Size(84, 31);
            this.SnaksBtn.TabIndex = 1;
            this.SnaksBtn.Text = "Snaks";
            this.SnaksBtn.Click += new System.EventHandler(this.SnaksBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drinks";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(564, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 55);
            this.label2.TabIndex = 24;
            this.label2.Text = "Holon 24/7";
            // 
            // DrinksStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1289, 614);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrinksStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrinksStockForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BillingBtn;
        private System.Windows.Forms.Label GummyBtn;
        private System.Windows.Forms.Label SnaksBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DrinksName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox DrinksPrice;
        private System.Windows.Forms.TextBox DrinksQun;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label deleteFromStock;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.ComboBox DrinksNames;
        private System.Windows.Forms.ComboBox DrinksLiter;
        private System.Windows.Forms.Label label2;
    }
}