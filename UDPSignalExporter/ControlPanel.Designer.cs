namespace SDRSharp.UDPSignalExporter
{
    partial class ControlPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EnableBtn = new System.Windows.Forms.Button();
            labelAddress = new System.Windows.Forms.Label();
            labelPort = new System.Windows.Forms.Label();
            ipPortUpDown = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            ipAddressBox = new System.Windows.Forms.MaskedTextBox();
            helpButton = new System.Windows.Forms.Button();
            intervalUpDown = new System.Windows.Forms.NumericUpDown();
            labelInterval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)ipPortUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intervalUpDown).BeginInit();
            SuspendLayout();
            // 
            // EnableBtn
            // 
            EnableBtn.Location = new System.Drawing.Point(15, 137);
            EnableBtn.Name = "EnableBtn";
            EnableBtn.Size = new System.Drawing.Size(177, 23);
            EnableBtn.TabIndex = 4;
            EnableBtn.Text = "Enable";
            EnableBtn.UseVisualStyleBackColor = true;
            EnableBtn.Click += toggleExporterBtn;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new System.Drawing.Point(15, 54);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new System.Drawing.Size(49, 15);
            labelAddress.TabIndex = 0;
            labelAddress.Text = "Address";
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Location = new System.Drawing.Point(15, 81);
            labelPort.Name = "labelPort";
            labelPort.Size = new System.Drawing.Size(29, 15);
            labelPort.TabIndex = 0;
            labelPort.Text = "Port";
            // 
            // ipPortUpDown
            // 
            ipPortUpDown.Location = new System.Drawing.Point(92, 79);
            ipPortUpDown.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            ipPortUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ipPortUpDown.Name = "ipPortUpDown";
            ipPortUpDown.Size = new System.Drawing.Size(100, 23);
            ipPortUpDown.TabIndex = 2;
            ipPortUpDown.Value = new decimal(new int[] { 9988, 0, 0, 0 });
            ipPortUpDown.ValueChanged += PortValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(18, 14);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(165, 21);
            label3.TabIndex = 0;
            label3.Text = "UDP Signal Exporter";
            // 
            // ipAddressBox
            // 
            ipAddressBox.Location = new System.Drawing.Point(92, 51);
            ipAddressBox.Name = "ipAddressBox";
            ipAddressBox.Size = new System.Drawing.Size(100, 23);
            ipAddressBox.TabIndex = 1;
            ipAddressBox.Text = "255.255.255.255";
            ipAddressBox.Validated += AddressBoxValueChanged;
            // 
            // helpButton
            // 
            helpButton.Location = new System.Drawing.Point(15, 166);
            helpButton.Name = "helpButton";
            helpButton.Size = new System.Drawing.Size(49, 23);
            helpButton.TabIndex = 5;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += HelpButton_Click;
            // 
            // intervalUpDown
            // 
            intervalUpDown.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            intervalUpDown.Location = new System.Drawing.Point(92, 108);
            intervalUpDown.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            intervalUpDown.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            intervalUpDown.Name = "intervalUpDown";
            intervalUpDown.Size = new System.Drawing.Size(100, 23);
            intervalUpDown.TabIndex = 3;
            intervalUpDown.Value = new decimal(new int[] { 250, 0, 0, 0 });
            intervalUpDown.ValueChanged += IntervalUpDown_ValueChanged;
            // 
            // labelInterval
            // 
            labelInterval.AutoSize = true;
            labelInterval.Location = new System.Drawing.Point(15, 110);
            labelInterval.Name = "labelInterval";
            labelInterval.Size = new System.Drawing.Size(73, 15);
            labelInterval.TabIndex = 0;
            labelInterval.Text = "Interval [ms]";
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(intervalUpDown);
            Controls.Add(labelInterval);
            Controls.Add(helpButton);
            Controls.Add(ipAddressBox);
            Controls.Add(label3);
            Controls.Add(ipPortUpDown);
            Controls.Add(labelPort);
            Controls.Add(labelAddress);
            Controls.Add(EnableBtn);
            Name = "ControlPanel";
            Size = new System.Drawing.Size(201, 215);
            ((System.ComponentModel.ISupportInitialize)ipPortUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)intervalUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button EnableBtn;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.NumericUpDown ipPortUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ipAddressBox;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.NumericUpDown intervalUpDown;
        private System.Windows.Forms.Label labelInterval;
    }
}
