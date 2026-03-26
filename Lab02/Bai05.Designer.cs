namespace Lab02
{
    partial class Bai05
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
            listViewFile = new ListView();
            clnName = new ColumnHeader();
            clnSize = new ColumnHeader();
            clnTail = new ColumnHeader();
            clnDate = new ColumnHeader();
            btnOpen = new Button();
            SuspendLayout();
            // 
            // listViewFile
            // 
            listViewFile.Columns.AddRange(new ColumnHeader[] { clnName, clnSize, clnTail, clnDate });
            listViewFile.Location = new Point(50, 27);
            listViewFile.Name = "listViewFile";
            listViewFile.Size = new Size(699, 340);
            listViewFile.TabIndex = 0;
            listViewFile.UseCompatibleStateImageBehavior = false;
            listViewFile.View = View.Details;
            listViewFile.SelectedIndexChanged += listViewFile_SelectedIndexChanged;
            // 
            // clnName
            // 
            clnName.Text = "Tên file";
            clnName.Width = 300;
            // 
            // clnSize
            // 
            clnSize.Text = "Kích thước";
            clnSize.Width = 100;
            // 
            // clnTail
            // 
            clnTail.Text = "Đuôi mở rộng";
            clnTail.Width = 150;
            // 
            // clnDate
            // 
            clnDate.Text = "Ngày tạo";
            clnDate.Width = 200;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(353, 394);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(94, 29);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpen);
            Controls.Add(listViewFile);
            Name = "Bai05";
            Text = "Bai05";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewFile;
        private Button btnOpen;
        private ColumnHeader clnName;
        private ColumnHeader clnSize;
        private ColumnHeader clnTail;
        private ColumnHeader clnDate;
    }
}