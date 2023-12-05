namespace BWinFormsUsingWASDK
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
            progressBarBattery = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            textBoxPowerSource = new TextBox();
            SuspendLayout();
            // 
            // progressBarBattery
            // 
            progressBarBattery.Location = new Point(113, 45);
            progressBarBattery.Name = "progressBarBattery";
            progressBarBattery.Size = new Size(675, 23);
            progressBarBattery.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Battery Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 2;
            label2.Text = "Power source";
            // 
            // textBoxPowerSource
            // 
            textBoxPowerSource.Location = new Point(113, 84);
            textBoxPowerSource.Name = "textBoxPowerSource";
            textBoxPowerSource.Size = new Size(231, 23);
            textBoxPowerSource.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPowerSource);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBarBattery);
            Name = "MainForm";
            Text = "WinForms with Windows App SDK";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBarBattery;
        private Label label1;
        private Label label2;
        private TextBox textBoxPowerSource;
    }
}
