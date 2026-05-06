namespace Lab3
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
            lbTask4 = new Label();
            btnClient = new Button();
            btnServer = new Button();
            SuspendLayout();
            // 
            // lbTask4
            // 
            lbTask4.AutoSize = true;
            lbTask4.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTask4.Location = new Point(157, 21);
            lbTask4.Margin = new Padding(2, 0, 2, 0);
            lbTask4.Name = "lbTask4";
            lbTask4.Size = new Size(122, 46);
            lbTask4.TabIndex = 8;
            lbTask4.Text = "Bài 04";
            // 
            // btnClient
            // 
            btnClient.Location = new Point(86, 141);
            btnClient.Margin = new Padding(2, 2, 2, 2);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(254, 34);
            btnClient.TabIndex = 7;
            btnClient.Text = "Open new TCP client";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // btnServer
            // 
            btnServer.Location = new Point(86, 93);
            btnServer.Margin = new Padding(2, 2, 2, 2);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(254, 34);
            btnServer.TabIndex = 6;
            btnServer.Text = "Open TCP server";
            btnServer.UseVisualStyleBackColor = true;
            btnServer.Click += btnServer_Click;
            // 
            // Task4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 196);
            Controls.Add(lbTask4);
            Controls.Add(btnClient);
            Controls.Add(btnServer);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Task4";
            Text = "Bài 04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTask4;
        private Button btnClient;
        private Button btnServer;
    }
}