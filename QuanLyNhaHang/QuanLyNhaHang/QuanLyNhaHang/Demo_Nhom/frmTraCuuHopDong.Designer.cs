namespace QuanLyNhaHang.Demo_Nhom
{
    partial class frmTraCuuHopDong
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat4 = new System.Windows.Forms.Button();
            this.cbbMaHD = new System.Windows.Forms.TextBox();
            this.btnTKHD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataHienThiTTHĐ = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThiTTHĐ)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÌM KIẾM HỢP ĐỒNG";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.panel2.Controls.Add(this.btnThoat4);
            this.panel2.Controls.Add(this.cbbMaHD);
            this.panel2.Controls.Add(this.btnTKHD);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 45);
            this.panel2.TabIndex = 1;
            // 
            // btnThoat4
            // 
            this.btnThoat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat4.Location = new System.Drawing.Point(561, 8);
            this.btnThoat4.Name = "btnThoat4";
            this.btnThoat4.Size = new System.Drawing.Size(118, 23);
            this.btnThoat4.TabIndex = 4;
            this.btnThoat4.Text = "Thoát";
            this.btnThoat4.UseVisualStyleBackColor = true;
            this.btnThoat4.Click += new System.EventHandler(this.btnThoat4_Click);
            // 
            // cbbMaHD
            // 
            this.cbbMaHD.Location = new System.Drawing.Point(115, 11);
            this.cbbMaHD.Name = "cbbMaHD";
            this.cbbMaHD.Size = new System.Drawing.Size(188, 20);
            this.cbbMaHD.TabIndex = 3;
            this.cbbMaHD.TextChanged += new System.EventHandler(this.cbbMaHD_TextChanged);
            // 
            // btnTKHD
            // 
            this.btnTKHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTKHD.Location = new System.Drawing.Point(368, 8);
            this.btnTKHD.Name = "btnTKHD";
            this.btnTKHD.Size = new System.Drawing.Size(118, 23);
            this.btnTKHD.TabIndex = 2;
            this.btnTKHD.Text = "Tìm Kiếm HĐ";
            this.btnTKHD.UseVisualStyleBackColor = true;
            this.btnTKHD.Click += new System.EventHandler(this.btnTKHD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hợp Đồng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataHienThiTTHĐ);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(1, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển Thị Thông Tin Hợp Đồng";
            // 
            // dataHienThiTTHĐ
            // 
            this.dataHienThiTTHĐ.BackgroundColor = System.Drawing.Color.Azure;
            this.dataHienThiTTHĐ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHienThiTTHĐ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataHienThiTTHĐ.Location = new System.Drawing.Point(3, 18);
            this.dataHienThiTTHĐ.Name = "dataHienThiTTHĐ";
            this.dataHienThiTTHĐ.Size = new System.Drawing.Size(785, 166);
            this.dataHienThiTTHĐ.TabIndex = 0;
            // 
            // frmTraCuuHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(792, 282);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTraCuuHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTraCuuHopDong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTraCuuHopDong_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThiTTHĐ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cbbMaHD;
        private System.Windows.Forms.Button btnTKHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataHienThiTTHĐ;
        private System.Windows.Forms.Button btnThoat4;
    }
}