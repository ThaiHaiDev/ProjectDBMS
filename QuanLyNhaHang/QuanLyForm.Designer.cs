
namespace QuanLyNhaHang
{
    partial class QuanLyForm
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
            this.buttonQLBan = new System.Windows.Forms.Button();
            this.buttonQLMon = new System.Windows.Forms.Button();
            this.buttonQLMHang = new System.Windows.Forms.Button();
            this.buttonQLThanhPhan = new System.Windows.Forms.Button();
            this.buttonQLHoaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonQLBan
            // 
            this.buttonQLBan.Location = new System.Drawing.Point(74, 69);
            this.buttonQLBan.Name = "buttonQLBan";
            this.buttonQLBan.Size = new System.Drawing.Size(218, 50);
            this.buttonQLBan.TabIndex = 0;
            this.buttonQLBan.Text = "Quan Ly Ban";
            this.buttonQLBan.UseVisualStyleBackColor = true;
            this.buttonQLBan.Click += new System.EventHandler(this.buttonQLBan_Click);
            // 
            // buttonQLMon
            // 
            this.buttonQLMon.Location = new System.Drawing.Point(417, 69);
            this.buttonQLMon.Name = "buttonQLMon";
            this.buttonQLMon.Size = new System.Drawing.Size(218, 50);
            this.buttonQLMon.TabIndex = 1;
            this.buttonQLMon.Text = "Quan Ly Mon";
            this.buttonQLMon.UseVisualStyleBackColor = true;
            // 
            // buttonQLMHang
            // 
            this.buttonQLMHang.Location = new System.Drawing.Point(74, 166);
            this.buttonQLMHang.Name = "buttonQLMHang";
            this.buttonQLMHang.Size = new System.Drawing.Size(218, 50);
            this.buttonQLMHang.TabIndex = 2;
            this.buttonQLMHang.Text = "Quan Ly Mat Hang";
            this.buttonQLMHang.UseVisualStyleBackColor = true;
            // 
            // buttonQLThanhPhan
            // 
            this.buttonQLThanhPhan.Location = new System.Drawing.Point(417, 166);
            this.buttonQLThanhPhan.Name = "buttonQLThanhPhan";
            this.buttonQLThanhPhan.Size = new System.Drawing.Size(218, 50);
            this.buttonQLThanhPhan.TabIndex = 3;
            this.buttonQLThanhPhan.Text = "Quan Ly Thanh Phan";
            this.buttonQLThanhPhan.UseVisualStyleBackColor = true;
            // 
            // buttonQLHoaDon
            // 
            this.buttonQLHoaDon.Location = new System.Drawing.Point(74, 255);
            this.buttonQLHoaDon.Name = "buttonQLHoaDon";
            this.buttonQLHoaDon.Size = new System.Drawing.Size(218, 50);
            this.buttonQLHoaDon.TabIndex = 4;
            this.buttonQLHoaDon.Text = "Quan Ly Hoa Don";
            this.buttonQLHoaDon.UseVisualStyleBackColor = true;
            // 
            // QuanLyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQLHoaDon);
            this.Controls.Add(this.buttonQLThanhPhan);
            this.Controls.Add(this.buttonQLMHang);
            this.Controls.Add(this.buttonQLMon);
            this.Controls.Add(this.buttonQLBan);
            this.Name = "QuanLyForm";
            this.Text = "QuanLyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQLBan;
        private System.Windows.Forms.Button buttonQLMon;
        private System.Windows.Forms.Button buttonQLMHang;
        private System.Windows.Forms.Button buttonQLThanhPhan;
        private System.Windows.Forms.Button buttonQLHoaDon;
    }
}