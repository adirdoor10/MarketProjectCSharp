
namespace WindowsFormsApp2
{
    partial class Billing
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
            this.AddToBillBtn = new System.Windows.Forms.Button();
            this.BillingQnt = new System.Windows.Forms.TextBox();
            this.BillingPrice = new System.Windows.Forms.TextBox();
            this.BillingItem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddToStockBtn = new System.Windows.Forms.Label();
            this.BillingBtn = new System.Windows.Forms.Label();
            this.GummyBtn = new System.Windows.Forms.Label();
            this.DrinksBtn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.BuyBtn = new System.Windows.Forms.Button();
            this.TotalBillingPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteFromStock = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billingGrid = new System.Windows.Forms.DataGridView();
            this.SnaksBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddToBillBtn
            // 
            this.AddToBillBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.AddToBillBtn.FlatAppearance.BorderSize = 0;
            this.AddToBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToBillBtn.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToBillBtn.ForeColor = System.Drawing.Color.White;
            this.AddToBillBtn.Location = new System.Drawing.Point(314, 178);
            this.AddToBillBtn.Name = "AddToBillBtn";
            this.AddToBillBtn.Size = new System.Drawing.Size(144, 39);
            this.AddToBillBtn.TabIndex = 35;
            this.AddToBillBtn.Text = "Add To Bill";
            this.AddToBillBtn.UseVisualStyleBackColor = false;
            this.AddToBillBtn.Click += new System.EventHandler(this.AddToBillBtn_Click);
            // 
            // BillingQnt
            // 
            this.BillingQnt.Location = new System.Drawing.Point(439, 51);
            this.BillingQnt.Name = "BillingQnt";
            this.BillingQnt.Size = new System.Drawing.Size(130, 39);
            this.BillingQnt.TabIndex = 32;
            // 
            // BillingPrice
            // 
            this.BillingPrice.Enabled = false;
            this.BillingPrice.Location = new System.Drawing.Point(601, 51);
            this.BillingPrice.Name = "BillingPrice";
            this.BillingPrice.Size = new System.Drawing.Size(130, 39);
            this.BillingPrice.TabIndex = 31;
            // 
            // BillingItem
            // 
            this.BillingItem.Location = new System.Drawing.Point(283, 51);
            this.BillingItem.Name = "BillingItem";
            this.BillingItem.Size = new System.Drawing.Size(130, 39);
            this.BillingItem.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 31);
            this.label8.TabIndex = 27;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(609, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 31);
            this.label7.TabIndex = 26;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 31);
            this.label6.TabIndex = 25;
            this.label6.Text = "BarCode";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Location = new System.Drawing.Point(48, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 5);
            this.panel2.TabIndex = 24;
            // 
            // AddToStockBtn
            // 
            this.AddToStockBtn.AutoSize = true;
            this.AddToStockBtn.Location = new System.Drawing.Point(42, 185);
            this.AddToStockBtn.Name = "AddToStockBtn";
            this.AddToStockBtn.Size = new System.Drawing.Size(175, 31);
            this.AddToStockBtn.TabIndex = 23;
            this.AddToStockBtn.Text = "Add to stock:";
            // 
            // BillingBtn
            // 
            this.BillingBtn.AutoSize = true;
            this.BillingBtn.Location = new System.Drawing.Point(42, 109);
            this.BillingBtn.Name = "BillingBtn";
            this.BillingBtn.Size = new System.Drawing.Size(90, 31);
            this.BillingBtn.TabIndex = 22;
            this.BillingBtn.Text = "Billing";
            // 
            // GummyBtn
            // 
            this.GummyBtn.AutoSize = true;
            this.GummyBtn.Location = new System.Drawing.Point(42, 366);
            this.GummyBtn.Name = "GummyBtn";
            this.GummyBtn.Size = new System.Drawing.Size(110, 31);
            this.GummyBtn.TabIndex = 21;
            this.GummyBtn.Text = "Gummy";
            this.GummyBtn.Click += new System.EventHandler(this.GummyBtn_Click);
            // 
            // DrinksBtn
            // 
            this.DrinksBtn.AutoSize = true;
            this.DrinksBtn.Location = new System.Drawing.Point(42, 242);
            this.DrinksBtn.Name = "DrinksBtn";
            this.DrinksBtn.Size = new System.Drawing.Size(92, 31);
            this.DrinksBtn.TabIndex = 19;
            this.DrinksBtn.Text = "Drinks";
            this.DrinksBtn.Click += new System.EventHandler(this.DrinksBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ResetBtn);
            this.panel1.Controls.Add(this.BuyBtn);
            this.panel1.Controls.Add(this.TotalBillingPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.deleteFromStock);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.billingGrid);
            this.panel1.Controls.Add(this.AddToBillBtn);
            this.panel1.Controls.Add(this.BillingQnt);
            this.panel1.Controls.Add(this.BillingPrice);
            this.panel1.Controls.Add(this.BillingItem);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.AddToStockBtn);
            this.panel1.Controls.Add(this.BillingBtn);
            this.panel1.Controls.Add(this.GummyBtn);
            this.panel1.Controls.Add(this.SnaksBtn);
            this.panel1.Controls.Add(this.DrinksBtn);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(32, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1569, 566);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.ResetBtn.FlatAppearance.BorderSize = 0;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(464, 178);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(144, 39);
            this.ResetBtn.TabIndex = 48;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // BuyBtn
            // 
            this.BuyBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.BuyBtn.FlatAppearance.BorderSize = 0;
            this.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBtn.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyBtn.ForeColor = System.Drawing.Color.White;
            this.BuyBtn.Location = new System.Drawing.Point(629, 178);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(144, 39);
            this.BuyBtn.TabIndex = 47;
            this.BuyBtn.Text = "Buy";
            this.BuyBtn.UseVisualStyleBackColor = false;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // TotalBillingPrice
            // 
            this.TotalBillingPrice.Location = new System.Drawing.Point(1042, 24);
            this.TotalBillingPrice.Name = "TotalBillingPrice";
            this.TotalBillingPrice.Size = new System.Drawing.Size(174, 39);
            this.TotalBillingPrice.TabIndex = 46;
            this.TotalBillingPrice.TextChanged += new System.EventHandler(this.TotalBillingPrice_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(872, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
            this.label2.TabIndex = 45;
            this.label2.Text = "Billing Price:";
            // 
            // deleteFromStock
            // 
            this.deleteFromStock.AutoSize = true;
            this.deleteFromStock.Location = new System.Drawing.Point(42, 416);
            this.deleteFromStock.Name = "deleteFromStock";
            this.deleteFromStock.Size = new System.Drawing.Size(235, 31);
            this.deleteFromStock.TabIndex = 44;
            this.deleteFromStock.Text = "Delete From Stock";
            this.deleteFromStock.Click += new System.EventHandler(this.deleteFromStock_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(578, 247);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // billingGrid
            // 
            this.billingGrid.AllowUserToAddRows = false;
            this.billingGrid.AllowUserToDeleteRows = false;
            this.billingGrid.BackgroundColor = System.Drawing.Color.White;
            this.billingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingGrid.GridColor = System.Drawing.Color.White;
            this.billingGrid.Location = new System.Drawing.Point(878, 69);
            this.billingGrid.Name = "billingGrid";
            this.billingGrid.RowHeadersWidth = 62;
            this.billingGrid.RowTemplate.Height = 28;
            this.billingGrid.Size = new System.Drawing.Size(673, 481);
            this.billingGrid.TabIndex = 41;
            this.billingGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billingGrid_CellContentClick);
            // 
            // SnaksBtn
            // 
            this.SnaksBtn.AutoSize = true;
            this.SnaksBtn.Location = new System.Drawing.Point(42, 307);
            this.SnaksBtn.Name = "SnaksBtn";
            this.SnaksBtn.Size = new System.Drawing.Size(84, 31);
            this.SnaksBtn.TabIndex = 20;
            this.SnaksBtn.Text = "Snaks";
            this.SnaksBtn.Click += new System.EventHandler(this.SnaksBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(525, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "Holon 24/7";
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1633, 659);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.Text = "Billing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddToBillBtn;
        private System.Windows.Forms.TextBox BillingQnt;
        private System.Windows.Forms.TextBox BillingPrice;
        private System.Windows.Forms.TextBox BillingItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AddToStockBtn;
        private System.Windows.Forms.Label BillingBtn;
        private System.Windows.Forms.Label GummyBtn;
        private System.Windows.Forms.Label DrinksBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView billingGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label SnaksBtn;
        private System.Windows.Forms.Label deleteFromStock;
        private System.Windows.Forms.TextBox TotalBillingPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label label1;
    }
}