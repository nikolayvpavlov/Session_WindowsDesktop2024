namespace CWinFormsIslands
{
    partial class MainForm
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
            bLoadIsland = new Button();
            pXamlIsland = new Panel();
            bLoadCustomPage = new Button();
            SuspendLayout();
            // 
            // bLoadIsland
            // 
            bLoadIsland.Location = new Point(12, 12);
            bLoadIsland.Name = "bLoadIsland";
            bLoadIsland.Size = new Size(175, 23);
            bLoadIsland.TabIndex = 0;
            bLoadIsland.Text = "Load WinUI 3 in Island";
            bLoadIsland.UseVisualStyleBackColor = true;
            bLoadIsland.Click += bLoadIsland_Click;
            // 
            // pXamlIsland
            // 
            pXamlIsland.Location = new Point(12, 58);
            pXamlIsland.Name = "pXamlIsland";
            pXamlIsland.Size = new Size(776, 380);
            pXamlIsland.TabIndex = 1;
            // 
            // bLoadCustomPage
            // 
            bLoadCustomPage.Location = new Point(193, 12);
            bLoadCustomPage.Name = "bLoadCustomPage";
            bLoadCustomPage.Size = new Size(165, 23);
            bLoadCustomPage.TabIndex = 2;
            bLoadCustomPage.Text = "Load Page in Island";
            bLoadCustomPage.UseVisualStyleBackColor = true;
            bLoadCustomPage.Click += bLoadCustomPage_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bLoadCustomPage);
            Controls.Add(pXamlIsland);
            Controls.Add(bLoadIsland);
            Name = "MainForm";
            Text = "Xaml Islands in WinForms";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button bLoadIsland;
        private Panel pXamlIsland;
        private Button bLoadCustomPage;
    }
}
