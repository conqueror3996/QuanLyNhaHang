﻿namespace QL_Nhà_Hàng
{
    partial class QLHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btmSuaHD = new System.Windows.Forms.Button();
            this.btmXoaHD = new System.Windows.Forms.Button();
            this.comboMaKH = new System.Windows.Forms.ComboBox();
            this.comboMaNV = new System.Windows.Forms.ComboBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.comboMaNV);
            this.groupBox1.Controls.Add(this.comboMaKH);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hoa Don";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(387, 97);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.Value = new System.DateTime(2016, 9, 12, 16, 23, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2016, 9, 12, 16, 22, 0, 0);
           // this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Giao Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Lập HĐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã KH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HĐ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 174);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(363, 362);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(101, 27);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Cập Nhật";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(470, 362);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 26);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Huy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm Hóa Đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btmSuaHD
            // 
            this.btmSuaHD.Location = new System.Drawing.Point(145, 363);
            this.btmSuaHD.Name = "btmSuaHD";
            this.btmSuaHD.Size = new System.Drawing.Size(101, 27);
            this.btmSuaHD.TabIndex = 5;
            this.btmSuaHD.Text = "Sửa Hóa Đơn";
            this.btmSuaHD.UseVisualStyleBackColor = true;
            this.btmSuaHD.Click += new System.EventHandler(this.btmSuaHD_Click_1);
            // 
            // btmXoaHD
            // 
            this.btmXoaHD.Location = new System.Drawing.Point(256, 362);
            this.btmXoaHD.Name = "btmXoaHD";
            this.btmXoaHD.Size = new System.Drawing.Size(101, 27);
            this.btmXoaHD.TabIndex = 6;
            this.btmXoaHD.Text = "Xóa Hóa Đơn";
            this.btmXoaHD.UseVisualStyleBackColor = true;
            this.btmXoaHD.Click += new System.EventHandler(this.btmXoaHD_Click);
            // 
            // comboMaKH
            // 
            this.comboMaKH.FormattingEnabled = true;
            this.comboMaKH.Location = new System.Drawing.Point(125, 62);
            this.comboMaKH.Name = "comboMaKH";
            this.comboMaKH.Size = new System.Drawing.Size(144, 21);
            this.comboMaKH.TabIndex = 11;
            // 
            // comboMaNV
            // 
            this.comboMaNV.FormattingEnabled = true;
            this.comboMaNV.Location = new System.Drawing.Point(363, 29);
            this.comboMaNV.Name = "comboMaNV";
            this.comboMaNV.Size = new System.Drawing.Size(144, 21);
            this.comboMaNV.TabIndex = 12;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(125, 25);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(143, 20);
            this.txtMaHD.TabIndex = 13;
            // 
            // QLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 407);
            this.Controls.Add(this.btmXoaHD);
            this.Controls.Add(this.btmSuaHD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "QLHoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btmSuaHD;
        private System.Windows.Forms.Button btmXoaHD;
        private System.Windows.Forms.ComboBox comboMaNV;
        private System.Windows.Forms.ComboBox comboMaKH;
        private System.Windows.Forms.TextBox txtMaHD;
    }
}