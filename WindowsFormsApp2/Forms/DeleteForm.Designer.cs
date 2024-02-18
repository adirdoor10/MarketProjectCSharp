
namespace WindowsFormsApp2
{
    partial class DeleteForm
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
            this.snaksBtn = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Refresh = new System.Windows.Forms.Button();
            this.drinksBtn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BillingBtn = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.barcode = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.QuanBtn = new System.Windows.Forms.Label();
            this.BarcodeBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.snaksBtn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Controls.Add(this.drinksBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BillingBtn);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.barcode);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.QuanBtn);
            this.panel1.Controls.Add(this.BarcodeBtn);
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(40, 75);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1244, 508);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // snaksBtn
            // 
            this.snaksBtn.AutoSize = true;
            this.snaksBtn.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snaksBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.snaksBtn.Location = new System.Drawing.Point(48, 289);
            this.snaksBtn.Name = "snaksBtn";
            this.snaksBtn.Size = new System.Drawing.Size(93, 39);
            this.snaksBtn.TabIndex = 50;
            this.snaksBtn.Text = "Snaks";
            this.snaksBtn.Click += new System.EventHandler(this.snaksBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(419, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(785, 188);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Refresh
            // 
            this.Refresh.ForeColor = System.Drawing.Color.ForestGreen;
            this.Refresh.Location = new System.Drawing.Point(567, 158);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(125, 49);
            this.Refresh.TabIndex = 48;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // drinksBtn
            // 
            this.drinksBtn.AutoSize = true;
            this.drinksBtn.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.drinksBtn.Location = new System.Drawing.Point(48, 234);
            this.drinksBtn.Name = "drinksBtn";
            this.drinksBtn.Size = new System.Drawing.Size(101, 39);
            this.drinksBtn.TabIndex = 47;
            this.drinksBtn.Text = "Drinks";
            this.drinksBtn.Click += new System.EventHandler(this.DrinksBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(48, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 39);
            this.label3.TabIndex = 46;
            this.label3.Text = "Gummy";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(48, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 39);
            this.label2.TabIndex = 45;
            this.label2.Text = "Delete From Stock";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.ForestGreen;
            this.panel2.Location = new System.Drawing.Point(60, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 10);
            this.panel2.TabIndex = 44;
            // 
            // BillingBtn
            // 
            this.BillingBtn.AutoSize = true;
            this.BillingBtn.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.BillingBtn.Location = new System.Drawing.Point(50, 132);
            this.BillingBtn.Name = "BillingBtn";
            this.BillingBtn.Size = new System.Drawing.Size(99, 39);
            this.BillingBtn.TabIndex = 42;
            this.BillingBtn.Text = "Billing";
            this.BillingBtn.Click += new System.EventHandler(this.BillingBtn_Click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(858, 63);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 37);
            this.quantity.TabIndex = 38;
            // 
            // barcode
            // 
            this.barcode.Location = new System.Drawing.Point(592, 67);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(100, 37);
            this.barcode.TabIndex = 37;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.DeleteBtn.Location = new System.Drawing.Point(396, 158);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(124, 49);
            this.DeleteBtn.TabIndex = 36;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // QuanBtn
            // 
            this.QuanBtn.AutoSize = true;
            this.QuanBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.QuanBtn.Location = new System.Drawing.Point(719, 63);
            this.QuanBtn.Name = "QuanBtn";
            this.QuanBtn.Size = new System.Drawing.Size(100, 29);
            this.QuanBtn.TabIndex = 34;
            this.QuanBtn.Text = "Quantity";
            // 
            // BarcodeBtn
            // 
            this.BarcodeBtn.AutoSize = true;
            this.BarcodeBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.BarcodeBtn.Location = new System.Drawing.Point(467, 64);
            this.BarcodeBtn.Name = "BarcodeBtn";
            this.BarcodeBtn.Size = new System.Drawing.Size(95, 29);
            this.BarcodeBtn.TabIndex = 33;
            this.BarcodeBtn.Text = "Barcode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(494, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 55);
            this.label1.TabIndex = 51;
            this.label1.Text = "Holon 24/7";
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1396, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "DeleteForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label QuanBtn;
        private System.Windows.Forms.Label BarcodeBtn;
        private System.Windows.Forms.TextBox barcode;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BillingBtn;
        private System.Windows.Forms.Label drinksBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label snaksBtn;
        private System.Windows.Forms.Label label1;
    }
}