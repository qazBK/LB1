namespace WinFormsApp1
{
    partial class FormMain
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
            panelTop = new Panel();
            labelUsers = new Label();
            panel1 = new Panel();
            labelInfAdoutUsers = new Label();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelUsers);
            panelTop.Dock = DockStyle.Top;
            panelTop.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panelTop.Location = new Point(10, 10);
            panelTop.Margin = new Padding(5);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(664, 50);
            panelTop.TabIndex = 1;
            // 
            // labelUsers
            // 
            labelUsers.Dock = DockStyle.Top;
            labelUsers.Location = new Point(10, 10);
            labelUsers.Name = "labelUsers";
            labelUsers.Padding = new Padding(10);
            labelUsers.Size = new Size(644, 50);
            labelUsers.TabIndex = 0;
            labelUsers.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelInfAdoutUsers);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 60);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(664, 491);
            panel1.TabIndex = 2;
            // 
            // labelInfAdoutUsers
            // 
            labelInfAdoutUsers.Dock = DockStyle.Fill;
            labelInfAdoutUsers.Location = new Point(10, 10);
            labelInfAdoutUsers.Name = "labelInfAdoutUsers";
            labelInfAdoutUsers.Size = new Size(644, 471);
            labelInfAdoutUsers.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 561);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMain";
            Padding = new Padding(10);
            Text = "Пользователи";
            Load += FormMain_Load;
            panelTop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTop;
        private Label labelUsers;
        private Panel panel1;
        private Label labelInfAdoutUsers;
    }
}
