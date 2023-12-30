namespace Bai3_Winform_canban
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
            lb_sothunhat = new Label();
            lb_sothuhai = new Label();
            txt_1 = new TextBox();
            txt_2 = new TextBox();
            btn_cong = new Button();
            btn_tru = new Button();
            btn_nhan = new Button();
            btn_chia = new Button();
            btn_Del = new Button();
            lb_Ketqua = new Label();
            txt_3 = new TextBox();
            SuspendLayout();
            // 
            // lb_sothunhat
            // 
            lb_sothunhat.AutoSize = true;
            lb_sothunhat.Location = new Point(76, 74);
            lb_sothunhat.Name = "lb_sothunhat";
            lb_sothunhat.Size = new Size(68, 15);
            lb_sothunhat.TabIndex = 0;
            lb_sothunhat.Text = "Số thứ nhất";
            // 
            // lb_sothuhai
            // 
            lb_sothuhai.AutoSize = true;
            lb_sothuhai.Location = new Point(76, 100);
            lb_sothuhai.Name = "lb_sothuhai";
            lb_sothuhai.Size = new Size(60, 15);
            lb_sothuhai.TabIndex = 1;
            lb_sothuhai.Text = "Số thứ hai";
            // 
            // txt_1
            // 
            txt_1.Location = new Point(150, 71);
            txt_1.Name = "txt_1";
            txt_1.Size = new Size(200, 23);
            txt_1.TabIndex = 2;
            // 
            // txt_2
            // 
            txt_2.Location = new Point(150, 100);
            txt_2.Name = "txt_2";
            txt_2.Size = new Size(200, 23);
            txt_2.TabIndex = 3;
            // 
            // btn_cong
            // 
            btn_cong.Location = new Point(76, 155);
            btn_cong.Name = "btn_cong";
            btn_cong.Size = new Size(40, 35);
            btn_cong.TabIndex = 4;
            btn_cong.Text = "+";
            btn_cong.UseVisualStyleBackColor = true;
            // 
            // btn_tru
            // 
            btn_tru.Location = new Point(150, 155);
            btn_tru.Name = "btn_tru";
            btn_tru.Size = new Size(40, 35);
            btn_tru.TabIndex = 5;
            btn_tru.Text = "-";
            btn_tru.UseVisualStyleBackColor = true;
            // 
            // btn_nhan
            // 
            btn_nhan.Location = new Point(217, 155);
            btn_nhan.Name = "btn_nhan";
            btn_nhan.Size = new Size(40, 35);
            btn_nhan.TabIndex = 6;
            btn_nhan.Text = "*";
            btn_nhan.UseVisualStyleBackColor = true;
            // 
            // btn_chia
            // 
            btn_chia.Location = new Point(281, 155);
            btn_chia.Name = "btn_chia";
            btn_chia.Size = new Size(40, 35);
            btn_chia.TabIndex = 7;
            btn_chia.Text = "/";
            btn_chia.UseVisualStyleBackColor = true;
            // 
            // btn_Del
            // 
            btn_Del.Location = new Point(355, 155);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(40, 35);
            btn_Del.TabIndex = 8;
            btn_Del.Text = "Del";
            btn_Del.UseVisualStyleBackColor = true;
            // 
            // lb_Ketqua
            // 
            lb_Ketqua.AutoSize = true;
            lb_Ketqua.Location = new Point(76, 222);
            lb_Ketqua.Name = "lb_Ketqua";
            lb_Ketqua.Size = new Size(47, 15);
            lb_Ketqua.TabIndex = 9;
            lb_Ketqua.Text = "Kết quả";
            // 
            // txt_3
            // 
            txt_3.Location = new Point(150, 219);
            txt_3.Name = "txt_3";
            txt_3.Size = new Size(200, 23);
            txt_3.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_3);
            Controls.Add(lb_Ketqua);
            Controls.Add(btn_Del);
            Controls.Add(btn_chia);
            Controls.Add(btn_nhan);
            Controls.Add(btn_tru);
            Controls.Add(btn_cong);
            Controls.Add(txt_2);
            Controls.Add(txt_1);
            Controls.Add(lb_sothuhai);
            Controls.Add(lb_sothunhat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_sothunhat;
        private Label lb_sothuhai;
        private TextBox txt_1;
        private TextBox txt_2;
        private Button btn_cong;
        private Button btn_tru;
        private Button btn_nhan;
        private Button btn_chia;
        private Button btn_Del;
        private Label lb_Ketqua;
        private TextBox txt_3;
    }
}
private void txt_1_KeyPress(object sender, KeyPressEventArgs e)

{

    if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

    {

        e.Handled = true;

    }

}