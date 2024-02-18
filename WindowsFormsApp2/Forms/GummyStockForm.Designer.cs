
namespace WindowsFormsApp2
{
    partial class GummyStockForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteFromStock = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.GummyPrice = new System.Windows.Forms.TextBox();
            this.GummyQuan = new System.Windows.Forms.TextBox();
            this.GummyName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BillinkBtn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SnaksBtn = new System.Windows.Forms.Label();
            this.DrinksBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.deleteFromStock);
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.GummyPrice);
            this.panel1.Controls.Add(this.GummyQuan);
            this.panel1.Controls.Add(this.GummyName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BillinkBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SnaksBtn);
            this.panel1.Controls.Add(this.DrinksBtn);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(43, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 495);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(403, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(630, 188);
            this.dataGridView1.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 31);
            this.label7.TabIndex = 46;
            this.label7.Text = "Quantity";
            // 
            // deleteFromStock
            // 
            this.deleteFromStock.AutoSize = true;
            this.deleteFromStock.Location = new System.Drawing.Point(58, 426);
            this.deleteFromStock.Name = "deleteFromStock";
            this.deleteFromStock.Size = new System.Drawing.Size(235, 31);
            this.deleteFromStock.TabIndex = 45;
            this.deleteFromStock.Text = "Delete From Stock";
            this.deleteFromStock.Click += new System.EventHandler(this.deleteFromStock_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.ForestGreen;
            this.Refresh.FlatAppearance.BorderSize = 0;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.Location = new System.Drawing.Point(753, 214);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(144, 39);
            this.Refresh.TabIndex = 36;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(553, 214);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(144, 39);
            this.EditBtn.TabIndex = 35;
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
            this.SaveBtn.Location = new System.Drawing.Point(347, 214);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(144, 39);
            this.SaveBtn.TabIndex = 34;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // GummyPrice
            // 
            this.GummyPrice.Location = new System.Drawing.Point(743, 137);
            this.GummyPrice.Name = "GummyPrice";
            this.GummyPrice.Size = new System.Drawing.Size(154, 39);
            this.GummyPrice.TabIndex = 32;
            // 
            // GummyQuan
            // 
            this.GummyQuan.Location = new System.Drawing.Point(553, 137);
            this.GummyQuan.Name = "GummyQuan";
            this.GummyQuan.Size = new System.Drawing.Size(154, 39);
            this.GummyQuan.TabIndex = 31;
            // 
            // GummyName
            // 
            this.GummyName.Enabled = false;
            this.GummyName.Location = new System.Drawing.Point(347, 137);
            this.GummyName.Name = "GummyName";
            this.GummyName.Size = new System.Drawing.Size(154, 39);
            this.GummyName.TabIndex = 30;
            this.GummyName.TextChanged += new System.EventHandler(this.GummyName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(741, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 31);
            this.label8.TabIndex = 27;
            this.label8.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 31);
            this.label6.TabIndex = 25;
            this.label6.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Location = new System.Drawing.Point(64, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 5);
            this.panel2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 31);
            this.label5.TabIndex = 23;
            this.label5.Text = "Add to stock:";
            // 
            // BillinkBtn
            // 
            this.BillinkBtn.AutoSize = true;
            this.BillinkBtn.Location = new System.Drawing.Point(58, 102);
            this.BillinkBtn.Name = "BillinkBtn";
            this.BillinkBtn.Size = new System.Drawing.Size(90, 31);
            this.BillinkBtn.TabIndex = 22;
            this.BillinkBtn.Text = "Billing";
            this.BillinkBtn.Click += new System.EventHandler(this.BillinkBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Gummy";
            // 
            // SnaksBtn
            // 
            this.SnaksBtn.AutoSize = true;
            this.SnaksBtn.Location = new System.Drawing.Point(58, 300);
            this.SnaksBtn.Name = "SnaksBtn";
            this.SnaksBtn.Size = new System.Drawing.Size(84, 31);
            this.SnaksBtn.TabIndex = 20;
            this.SnaksBtn.Text = "Snaks";
            this.SnaksBtn.Click += new System.EventHandler(this.label2_Click);
            // 
            // DrinksBtn
            // 
            this.DrinksBtn.AutoSize = true;
            this.DrinksBtn.Location = new System.Drawing.Point(58, 235);
            this.DrinksBtn.Name = "DrinksBtn";
            this.DrinksBtn.Size = new System.Drawing.Size(92, 31);
            this.DrinksBtn.TabIndex = 19;
            this.DrinksBtn.Text = "Drinks";
            this.DrinksBtn.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(568, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 55);
            this.label1.TabIndex = 49;
            this.label1.Text = "Holon 24/7";
            // 
            // GummyStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1425, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GummyStockForm";
            this.Text = "GummyStockForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox GummyPrice;
        private System.Windows.Forms.TextBox GummyQuan;
        private System.Windows.Forms.TextBox GummyName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BillinkBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SnaksBtn;
        private System.Windows.Forms.Label DrinksBtn;
        private System.Windows.Forms.Label deleteFromStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}