namespace SDRSharp.UDPSignalExporter
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            helpTextBox = new System.Windows.Forms.RichTextBox();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // helpTextBox
            // 
            helpTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            helpTextBox.Location = new System.Drawing.Point(12, 45);
            helpTextBox.Name = "helpTextBox";
            helpTextBox.ReadOnly = true;
            helpTextBox.Size = new System.Drawing.Size(394, 255);
            helpTextBox.TabIndex = 0;
            helpTextBox.Text = resources.GetString("helpTextBox.Text");
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(150, 289);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(109, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(165, 21);
            label3.TabIndex = 2;
            label3.Text = "UDP Signal Exporter";
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(418, 324);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(helpTextBox);
            Name = "HelpForm";
            Text = "UDP Signal Exporter Help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox helpTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}