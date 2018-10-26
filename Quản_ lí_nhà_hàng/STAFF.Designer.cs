namespace Quản__lí_nhà_hàng
{
    partial class Staff
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
            this.tcBanhang = new System.Windows.Forms.TabControl();
            this.tpSale = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvBill = new System.Windows.Forms.ListView();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbShowFood = new System.Windows.Forms.ComboBox();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.flpShowTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.cbSwitch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDCustomer = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.tcBanhang.SuspendLayout();
            this.tpSale.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tcBanhang
            // 
            this.tcBanhang.Controls.Add(this.tpSale);
            this.tcBanhang.Controls.Add(this.tpInfo);
            this.tcBanhang.Location = new System.Drawing.Point(0, 0);
            this.tcBanhang.Name = "tcBanhang";
            this.tcBanhang.SelectedIndex = 0;
            this.tcBanhang.Size = new System.Drawing.Size(860, 438);
            this.tcBanhang.TabIndex = 0;
            this.tcBanhang.TabStop = false;
            this.tcBanhang.Tag = "";
            // 
            // tpSale
            // 
            this.tpSale.BackColor = System.Drawing.Color.Gainsboro;
            this.tpSale.Controls.Add(this.numCount);
            this.tpSale.Controls.Add(this.btnAddFood);
            this.tpSale.Controls.Add(this.cbShowFood);
            this.tpSale.Controls.Add(this.cbCategory);
            this.tpSale.Controls.Add(this.panel3);
            this.tpSale.Controls.Add(this.panel2);
            this.tpSale.Controls.Add(this.panel1);
            this.tpSale.Location = new System.Drawing.Point(4, 22);
            this.tpSale.Name = "tpSale";
            this.tpSale.Padding = new System.Windows.Forms.Padding(3);
            this.tpSale.Size = new System.Drawing.Size(852, 412);
            this.tpSale.TabIndex = 0;
            this.tpSale.Text = "Bán hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpShowTable);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 403);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvBill);
            this.panel2.Location = new System.Drawing.Point(454, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 270);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Controls.Add(this.txtIDCustomer);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbSwitch);
            this.panel3.Controls.Add(this.btnSwitchTable);
            this.panel3.Location = new System.Drawing.Point(454, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 66);
            this.panel3.TabIndex = 2;
            // 
            // lvBill
            // 
            this.lvBill.Location = new System.Drawing.Point(0, 3);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(380, 268);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(454, 6);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(221, 21);
            this.cbCategory.TabIndex = 3;
            // 
            // cbShowFood
            // 
            this.cbShowFood.FormattingEnabled = true;
            this.cbShowFood.Location = new System.Drawing.Point(454, 33);
            this.cbShowFood.Name = "cbShowFood";
            this.cbShowFood.Size = new System.Drawing.Size(221, 21);
            this.cbShowFood.TabIndex = 4;
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.Navy;
            this.btnAddFood.Location = new System.Drawing.Point(681, 6);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(84, 50);
            this.btnAddFood.TabIndex = 5;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = false;
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(771, 18);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(66, 20);
            this.numCount.TabIndex = 6;
            // 
            // flpShowTable
            // 
            this.flpShowTable.Location = new System.Drawing.Point(0, 0);
            this.flpShowTable.Name = "flpShowTable";
            this.flpShowTable.Size = new System.Drawing.Size(440, 403);
            this.flpShowTable.TabIndex = 0;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSwitchTable.ForeColor = System.Drawing.Color.Navy;
            this.btnSwitchTable.Location = new System.Drawing.Point(3, 2);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(89, 29);
            this.btnSwitchTable.TabIndex = 7;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = false;
            // 
            // cbSwitch
            // 
            this.cbSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbSwitch.FormattingEnabled = true;
            this.cbSwitch.Location = new System.Drawing.Point(3, 33);
            this.cbSwitch.Name = "cbSwitch";
            this.cbSwitch.Size = new System.Drawing.Size(89, 24);
            this.cbSwitch.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(142, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID khách hàng";
            // 
            // txtIDCustomer
            // 
            this.txtIDCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIDCustomer.Location = new System.Drawing.Point(132, 33);
            this.txtIDCustomer.Name = "txtIDCustomer";
            this.txtIDCustomer.Size = new System.Drawing.Size(111, 23);
            this.txtIDCustomer.TabIndex = 10;
            this.txtIDCustomer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.Navy;
            this.btnPay.Location = new System.Drawing.Point(277, 8);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(84, 50);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // tpInfo
            // 
            this.tpInfo.Location = new System.Drawing.Point(4, 22);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(852, 412);
            this.tpInfo.TabIndex = 1;
            this.tpInfo.Text = "Thông tin tài khoản";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.tcBanhang);
            this.Name = "Staff";
            this.Text = "STAFF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcBanhang.ResumeLayout(false);
            this.tpSale.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcBanhang;
        private System.Windows.Forms.TabPage tpSale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cbShowFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.FlowLayoutPanel flpShowTable;
        private System.Windows.Forms.TextBox txtIDCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSwitch;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TabPage tpInfo;
    }
}

