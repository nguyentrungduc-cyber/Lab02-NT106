namespace Lab02
{
    partial class Bai02
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
        /// the contents of this method with the code editor
        /// </summary>
        private void InitializeComponent()
        {
            btnRead = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFilename = new TextBox();
            txtUrl = new TextBox();
            txtLines = new TextBox();
            txtWord = new TextBox();
            txtChar = new TextBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(56, 25);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(173, 89);
            btnRead.TabIndex = 0;
            btnRead.Text = "ĐỌC FILE";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 144);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên file";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 179);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 2;
            label2.Text = "URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 220);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Số dòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 261);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 4;
            label4.Text = "Số từ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 305);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 5;
            label5.Text = "Số ký tự";
            // 
            // txtFilename
            // 
            txtFilename.Location = new Point(127, 141);
            txtFilename.Name = "txtFilename";
            txtFilename.ReadOnly = true;
            txtFilename.Size = new Size(256, 27);
            txtFilename.TabIndex = 6;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(127, 176);
            txtUrl.Name = "txtUrl";
            txtUrl.ReadOnly = true;
            txtUrl.Size = new Size(256, 27);
            txtUrl.TabIndex = 7;
            // 
            // txtLines
            // 
            txtLines.Location = new Point(127, 217);
            txtLines.Name = "txtLines";
            txtLines.ReadOnly = true;
            txtLines.Size = new Size(256, 27);
            txtLines.TabIndex = 8;
            // 
            // txtWord
            // 
            txtWord.Location = new Point(127, 258);
            txtWord.Name = "txtWord";
            txtWord.ReadOnly = true;
            txtWord.Size = new Size(256, 27);
            txtWord.TabIndex = 9;
            // 
            // txtChar
            // 
            txtChar.Location = new Point(127, 302);
            txtChar.Name = "txtChar";
            txtChar.ReadOnly = true;
            txtChar.Size = new Size(256, 27);
            txtChar.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(403, 25);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(385, 401);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(txtChar);
            Controls.Add(txtWord);
            Controls.Add(txtLines);
            Controls.Add(txtUrl);
            Controls.Add(txtFilename);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRead);
            Name = "Bai02";
            Text = "Bai02";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button btnRead;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFilename;
        private TextBox txtUrl;
        private TextBox txtLines;
        private TextBox txtWord;
        private TextBox txtChar;
        private RichTextBox richTextBox1;
    }
}