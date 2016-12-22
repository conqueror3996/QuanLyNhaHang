namespace QL_Nhà_Hàng
{
    partial class Form_Thêm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Thêm));
            this.Họ = new System.Windows.Forms.Label();
            this.Tên = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btmQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Họ
            // 
            this.Họ.AutoSize = true;
            this.Họ.ForeColor = System.Drawing.Color.Red;
            this.Họ.Location = new System.Drawing.Point(17, 26);
            this.Họ.Name = "Họ";
            this.Họ.Size = new System.Drawing.Size(23, 13);
            this.Họ.TabIndex = 0;
            this.Họ.Text = "Họ";
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.ForeColor = System.Drawing.Color.Red;
            this.Tên.Location = new System.Drawing.Point(17, 84);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(29, 13);
            this.Tên.TabIndex = 1;
            this.Tên.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(253, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(253, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ";
            // 
            // txtHo
            // 
            this.txtHo.ForeColor = System.Drawing.Color.Red;
            this.txtHo.Location = new System.Drawing.Point(78, 28);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(116, 20);
            this.txtHo.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.ForeColor = System.Drawing.Color.Red;
            this.txtTen.Location = new System.Drawing.Point(78, 84);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(116, 20);
            this.txtTen.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.ForeColor = System.Drawing.Color.Red;
            this.txtDiaChi.Location = new System.Drawing.Point(313, 33);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(167, 45);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtSDT
            // 
            this.txtSDT.ForeColor = System.Drawing.Color.Red;
            this.txtSDT.Location = new System.Drawing.Point(313, 84);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(167, 20);
            this.txtSDT.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 183);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(519, 219);
            this.dataGridView2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(98, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 67);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btmQuayLai
            // 
            this.btmQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("btmQuayLai.Image")));
            this.btmQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmQuayLai.Location = new System.Drawing.Point(324, 110);
            this.btmQuayLai.Name = "btmQuayLai";
            this.btmQuayLai.Size = new System.Drawing.Size(146, 67);
            this.btmQuayLai.TabIndex = 10;
            this.btmQuayLai.Text = "Quay Lại";
            this.btmQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmQuayLai.UseVisualStyleBackColor = true;
            this.btmQuayLai.Click += new System.EventHandler(this.btmQuayLai_Click_1);
            // 
            // Form_Thêm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 400);
            this.Controls.Add(this.btmQuayLai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tên);
            this.Controls.Add(this.Họ);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_Thêm";
            this.Text = "Form Thêm NV";
            this.Load += new System.EventHandler(this.Form_Thêm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Họ;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btmQuayLai;
    }
}