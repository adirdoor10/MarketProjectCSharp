
namespace WindowsFormsApp2
{
    partial class SnaksFormStock
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
            this.Refresh = new System.Windows.Forms.Button();
            this.deleteFromStock = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SnaksSweet = new System.Windows.Forms.CheckBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SnaksPrice = new System.Windows.Forms.TextBox();
            this.SnaksQuan = new System.Windows.Forms.TextBox();
            this.SnaksName = new System.Windows.Forms.TextBox();
            this.SnaksSour = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BillingBtn = new System.Windows.Forms.Label();
            this.GummyBtn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DrinksBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Controls.Add(this.deleteFromStock);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.SnaksSweet);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.SnaksPrice);
            this.panel1.Controls.Add(this.SnaksQuan);
            this.panel1.Controls.Add(this.SnaksName);
            this.panel1.Controls.Add(this.SnaksSour);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BillingBtn);
            this.panel1.Controls.Add(this.GummyBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DrinksBtn);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(45, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 495);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.ForestGreen;
            this.Refresh.FlatAppearance.BorderSize = 0;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.Location = new System.Drawing.Point(753, 228);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(144, 39);
            this.Refresh.TabIndex = 47;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // deleteFromStock
            // 
            this.deleteFromStock.AutoSize = true;
            this.deleteFromStock.Location = new System.Drawing.Point(73, 422);
            this.deleteFromStock.Name = "deleteFromStock";
            this.deleteFromStock.Size = new System.Drawing.Size(235, 31);
            this.deleteFromStock.TabIndex = 46;
            this.deleteFromStock.Text = "Delete From Stock";
            this.deleteFromStock.Click += new System.EventHandler(this.deleteFromStock_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(630, 188);
            this.dataGridView1.TabIndex = 39;
            // 
            // SnaksSweet
            // 
            this.SnaksSweet.AutoSize = true;
            this.SnaksSweet.Location = new System.Drawing.Point(939, 104);
            this.SnaksSweet.Name = "SnaksSweet";
            this.SnaksSweet.Size = new System.Drawing.Size(112, 35);
            this.SnaksSweet.TabIndex = 38;
            this.SnaksSweet.Text = "Sweet";
            this.SnaksSweet.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(553, 228);
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
            this.SaveBtn.Location = new System.Drawing.Point(347, 228);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(144, 39);
            this.SaveBtn.TabIndex = 34;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SnaksPrice
            // 
            this.SnaksPrice.Location = new System.Drawing.Point(743, 137);
            this.SnaksPrice.Name = "SnaksPrice";
            this.SnaksPrice.Size = new System.Drawing.Size(154, 39);
            this.SnaksPrice.TabIndex = 32;
            this.SnaksPrice.TextChanged += new System.EventHandler(this.drinksPrice_TextChanged);
            // 
            // SnaksQuan
            // 
            this.SnaksQuan.Location = new System.Drawing.Point(553, 137);
            this.SnaksQuan.Name = "SnaksQuan";
            this.SnaksQuan.Size = new System.Drawing.Size(154, 39);
            this.SnaksQuan.TabIndex = 31;
            // 
            // SnaksName
            // 
            this.SnaksName.Enabled = false;
            this.SnaksName.Location = new System.Drawing.Point(347, 137);
            this.SnaksName.Name = "SnaksName";
            this.SnaksName.Size = new System.Drawing.Size(154, 39);
            this.SnaksName.TabIndex = 30;
            // 
            // SnaksSour
            // 
            this.SnaksSour.AutoSize = true;
            this.SnaksSour.Location = new System.Drawing.Point(1115, 104);
            this.SnaksSour.Name = "SnaksSour";
            this.SnaksSour.Size = new System.Drawing.Size(96, 35);
            this.SnaksSour.TabIndex = 29;
            this.SnaksSour.Text = "Sour";
            this.SnaksSour.UseVisualStyleBackColor = true;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 31);
            this.label7.TabIndex = 26;
            this.label7.Text = "Quantity";
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
            this.panel2.Location = new System.Drawing.Point(79, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 5);
            this.panel2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 31);
            this.label5.TabIndex = 23;
            this.label5.Text = "Add to stock:";
            // 
            // BillingBtn
            // 
            this.BillingBtn.AutoSize = true;
            this.BillingBtn.Location = new System.Drawing.Point(73, 103);
            this.BillingBtn.Name = "BillingBtn";
            this.BillingBtn.Size = new System.Drawing.Size(90, 31);
            this.BillingBtn.TabIndex = 22;
            this.BillingBtn.Text = "Billing";
            this.BillingBtn.Click += new System.EventHandler(this.BillingBtn_Click);
            // 
            // GummyBtn
            // 
            this.GummyBtn.AutoSize = true;
            this.GummyBtn.Location = new System.Drawing.Point(73, 360);
            this.GummyBtn.Name = "GummyBtn";
            this.GummyBtn.Size = new System.Drawing.Size(110, 31);
            this.GummyBtn.TabIndex = 21;
            this.GummyBtn.Text = "Gummy";
            this.GummyBtn.Click += new System.EventHandler(this.GummyBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Snaks";
            // 
            // DrinksBtn
            // 
            this.DrinksBtn.AutoSize = true;
            this.DrinksBtn.Location = new System.Drawing.Point(73, 236);
            this.DrinksBtn.Name = "DrinksBtn";
            this.DrinksBtn.Size = new System.Drawing.Size(92, 31);
            this.DrinksBtn.TabIndex = 19;
            this.DrinksBtn.Text = "Drinks";
            this.DrinksBtn.Click += new System.EventHandler(this.DrinksBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(577, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 55);
            this.label1.TabIndex = 48;
            this.label1.Text = "Holon 24/7";
            // 
            // SnaksFormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1429, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SnaksFormStock";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SnaksFormStock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox SnaksPrice;
        private System.Windows.Forms.TextBox SnaksQuan;
        private System.Windows.Forms.TextBox SnaksName;
        private System.Windows.Forms.CheckBox SnaksSour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BillingBtn;
        private System.Windows.Forms.Label GummyBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DrinksBtn;
        private System.Windows.Forms.CheckBox SnaksSweet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label deleteFromStock;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label1;
    }
}