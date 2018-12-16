namespace QuanLyNhaHang.Demo_Nhom
{
    partial class frmTimKiemNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataHienThiTTNV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat3 = new System.Windows.Forms.Button();
            this.frmTKNV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
     
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThiTTNV)).BeginInit();
       

            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(332, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tìm Nhân Viên";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataHienThiTTNV
            // 
            this.dataHienThiTTNV.AllowUserToAddRows = false;
            this.dataHienThiTTNV.AllowUserToDeleteRows = false;
            this.dataHienThiTTNV.BackgroundColor = System.Drawing.Color.Azure;
            this.dataHienThiTTNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHienThiTTNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataHienThiTTNV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataHienThiTTNV.Location = new System.Drawing.Point(3, 21);
            this.dataHienThiTTNV.Name = "dataHienThiTTNV";
            this.dataHienThiTTNV.ReadOnly = true;
            this.dataHienThiTTNV.Size = new System.Drawing.Size(591, 170);
            this.dataHienThiTTNV.TabIndex = 1;
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataHienThiTTNV);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển Thị Thông Tin Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài Khoản NV:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.btnThoat3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 52);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat3
            // 
            this.btnThoat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat3.Location = new System.Drawing.Point(475, 12);
            this.btnThoat3.Name = "btnThoat3";
            this.btnThoat3.Size = new System.Drawing.Size(96, 23);
            this.btnThoat3.TabIndex = 5;
            this.btnThoat3.Text = "Thoát";
            this.btnThoat3.UseVisualStyleBackColor = true;
            this.btnThoat3.Click += new System.EventHandler(this.btnThoat3_Click);
            // 
            // frmTKNV
            // 
            this.frmTKNV.AutoSize = true;
            this.frmTKNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.frmTKNV.ForeColor = System.Drawing.Color.Red;
            this.frmTKNV.Location = new System.Drawing.Point(221, 8);
            this.frmTKNV.Name = "frmTKNV";
            this.frmTKNV.Size = new System.Drawing.Size(176, 17);
            this.frmTKNV.TabIndex = 4;
            this.frmTKNV.Text = "TÌM KIẾM NHÂN VIÊN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.frmTKNV);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 31);
            this.panel2.TabIndex = 5;
            // 
            // frmTimKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(597, 288);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTimKiemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiemNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiemNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKiemNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThiTTNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataHienThiTTNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label frmTKNV;
        private System.Windows.Forms.Button btnThoat3;
        private System.Windows.Forms.Panel panel2;
    }
}