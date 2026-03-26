namespace Lab02
{
    partial class Bai03
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
            Read_btn = new Button();
            Write_btn = new Button();
            KetQua_listbox = new ListBox();
            SuspendLayout();
            // 
            // Read_btn
            // 
            Read_btn.Location = new Point(79, 64);
            Read_btn.Name = "Read_btn";
            Read_btn.Size = new Size(94, 29);
            Read_btn.TabIndex = 0;
            Read_btn.Text = "Đọc tệp";
            Read_btn.UseVisualStyleBackColor = true;
            Read_btn.Click += Read_btn_Click;
            // 
            // Write_btn
            // 
            Write_btn.Location = new Point(79, 99);
            Write_btn.Name = "Write_btn";
            Write_btn.Size = new Size(94, 29);
            Write_btn.TabIndex = 1;
            Write_btn.Text = "Ghi kết quả";
            Write_btn.UseVisualStyleBackColor = true;
            Write_btn.Click += Write_btn_Click;
            // 
            // KetQua_listbox
            // 
            KetQua_listbox.FormattingEnabled = true;
            KetQua_listbox.Location = new Point(283, 64);
            KetQua_listbox.Name = "KetQua_listbox";
            KetQua_listbox.Size = new Size(416, 284);
            KetQua_listbox.TabIndex = 2;
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KetQua_listbox);
            Controls.Add(Write_btn);
            Controls.Add(Read_btn);
            Name = "Bai03";
            Text = "Ghi và đọc file (Mở rộng)";
            ResumeLayout(false);
        }

        #endregion

        private Button Read_btn;
        private Button Write_btn;
        private ListBox KetQua_listbox;
    }
}