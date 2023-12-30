namespace Demo_Conghaiso_WindowForm
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
            btn_hoten = new Button();
            SuspendLayout();
            // 
            // lb_hoten
            // 
            lb_hoten.AutoSize = true;
            lb_hoten.Location = new Point(90, 118);
            lb_hoten.Name = "lb_hoten";
            lb_hoten.Size = new Size(59, 15);
            lb_hoten.TabIndex = 0;
            lb_hoten.Text = "Họ và Tên";
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(172, 115);
            txt_hoten.Multiline = true;
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(100, 23);
            txt_hoten.TabIndex = 1;
            txt_hoten.TextChanged += txt_hoten_TextChanged_1;
            // 
            // btn_hoten
            // 
            btn_hoten.Location = new Point(181, 162);
            btn_hoten.Name = "btn_hoten";
            btn_hoten.Size = new Size(75, 23);
            btn_hoten.TabIndex = 2;
            btn_hoten.Text = "Hiển thị";
            btn_hoten.UseVisualStyleBackColor = true;
            btn_hoten.Click += btn_hoten_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 275);
            Controls.Add(btn_hoten);
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
        private Button btn_hoten;
    }
}