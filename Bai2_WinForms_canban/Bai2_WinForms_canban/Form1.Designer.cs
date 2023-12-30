namespace Bai2_WinForms_canban
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_hoten = new Label();
            txt_hoten = new TextBox();
            btn_hienthi = new Button();
            btn_thoat = new Button();
            SuspendLayout();
            // 
            // lb_hoten
            // 
            lb_hoten.AutoSize = true;
            lb_hoten.Location = new Point(164, 137);
            lb_hoten.Name = "lb_hoten";
            lb_hoten.Size = new Size(62, 15);
            lb_hoten.TabIndex = 0;
            lb_hoten.Text = "Họ và Tên:";
            lb_hoten.Click += lb_hoten_Click;
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(241, 129);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(250, 23);
            txt_hoten.TabIndex = 1;
            txt_hoten.TextChanged += txt_hoten_TextChanged;
            // 
            // btn_hienthi
            // 
            btn_hienthi.Location = new Point(254, 190);
            btn_hienthi.Name = "btn_hienthi";
            btn_hienthi.Size = new Size(75, 23);
            btn_hienthi.TabIndex = 2;
            btn_hienthi.Text = "Hiển thị";
            btn_hienthi.UseVisualStyleBackColor = true;
            btn_hienthi.Click += btn_hienthi_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(392, 190);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(75, 23);
            btn_thoat.TabIndex = 3;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_thoat);
            Controls.Add(btn_hienthi);
            Controls.Add(txt_hoten);
            Controls.Add(lb_hoten);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_hoten;
        private TextBox txt_hoten;
        private Button btn_hienthi;
        private Button btn_thoat;
    }
}