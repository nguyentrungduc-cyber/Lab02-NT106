namespace Lab02
{
    partial class Bai04
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtVan = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            txtMSSV = new TextBox();
            txtToan = new TextBox();
            btnAdd = new Button();
            btnWrite = new Button();
            btnRead = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 81);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 49);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "MSSV:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 114);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "SDT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 143);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "Điểm Toán:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 173);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 4;
            label5.Text = "Điểm Văn:";
            // 
            // txtVan
            // 
            txtVan.Location = new Point(114, 170);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(264, 27);
            txtVan.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(114, 111);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(264, 27);
            txtPhone.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(114, 78);
            txtName.Name = "txtName";
            txtName.Size = new Size(264, 27);
            txtName.TabIndex = 7;
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(114, 46);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(264, 27);
            txtMSSV.TabIndex = 8;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(114, 140);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(264, 27);
            txtToan.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 251);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm học viên";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(155, 251);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(123, 29);
            btnWrite.TabIndex = 11;
            btnWrite.Text = "Ghi file";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(284, 251);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(104, 29);
            btnRead.TabIndex = 12;
            btnRead.Text = "Đọc file";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(393, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(395, 426);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btnRead);
            Controls.Add(btnWrite);
            Controls.Add(btnAdd);
            Controls.Add(txtToan);
            Controls.Add(txtMSSV);
            Controls.Add(txtName);
            Controls.Add(txtPhone);
            Controls.Add(txtVan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai04";
            Text = "Bai04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtVan;
        private TextBox txtPhone;
        private TextBox txtName;
        private TextBox txtMSSV;
        private TextBox txtToan;
        private Button btnAdd;
        private Button btnWrite;
        private Button btnRead;
        private RichTextBox richTextBox1;
    }
}