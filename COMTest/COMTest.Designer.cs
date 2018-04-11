namespace COMTest
{
    partial class COMTest
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
            this.comPortList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baudRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataBits = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.actionButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputData = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.parity = new System.Windows.Forms.ComboBox();
            this.stopBits = new System.Windows.Forms.ComboBox();
            this.flowControl = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtsEnable = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lfChar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timeoutMS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comPortList
            // 
            this.comPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPortList.FormattingEnabled = true;
            this.comPortList.Location = new System.Drawing.Point(52, 12);
            this.comPortList.Name = "comPortList";
            this.comPortList.Size = new System.Drawing.Size(121, 21);
            this.comPortList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate:";
            // 
            // baudRate
            // 
            this.baudRate.Location = new System.Drawing.Point(246, 12);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(100, 20);
            this.baudRate.TabIndex = 2;
            this.baudRate.Text = "9600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data Bits:";
            // 
            // dataBits
            // 
            this.dataBits.Location = new System.Drawing.Point(559, 12);
            this.dataBits.Name = "dataBits";
            this.dataBits.Size = new System.Drawing.Size(88, 20);
            this.dataBits.TabIndex = 2;
            this.dataBits.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stop Bits:";
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(817, 11);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(101, 23);
            this.actionButton.TabIndex = 3;
            this.actionButton.Text = "Connect";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(14, 77);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(904, 361);
            this.outputBox.TabIndex = 4;
            this.outputBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(671, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Input:";
            // 
            // inputData
            // 
            this.inputData.Enabled = false;
            this.inputData.Location = new System.Drawing.Point(711, 43);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(100, 20);
            this.inputData.TabIndex = 2;
            this.inputData.Text = "~00150 1";
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(817, 42);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(101, 23);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Write Data";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // parity
            // 
            this.parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parity.FormattingEnabled = true;
            this.parity.Location = new System.Drawing.Point(394, 12);
            this.parity.Name = "parity";
            this.parity.Size = new System.Drawing.Size(100, 21);
            this.parity.TabIndex = 0;
            // 
            // stopBits
            // 
            this.stopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBits.FormattingEnabled = true;
            this.stopBits.Location = new System.Drawing.Point(711, 12);
            this.stopBits.Name = "stopBits";
            this.stopBits.Size = new System.Drawing.Size(100, 21);
            this.stopBits.TabIndex = 0;
            // 
            // flowControl
            // 
            this.flowControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flowControl.FormattingEnabled = true;
            this.flowControl.Location = new System.Drawing.Point(91, 43);
            this.flowControl.Name = "flowControl";
            this.flowControl.Size = new System.Drawing.Size(149, 21);
            this.flowControl.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Flow Control:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "RTS Enable:";
            // 
            // rtsEnable
            // 
            this.rtsEnable.AutoSize = true;
            this.rtsEnable.Checked = true;
            this.rtsEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rtsEnable.Location = new System.Drawing.Point(316, 47);
            this.rtsEnable.Name = "rtsEnable";
            this.rtsEnable.Size = new System.Drawing.Size(15, 14);
            this.rtsEnable.TabIndex = 5;
            this.rtsEnable.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "LF Char:";
            // 
            // lfChar
            // 
            this.lfChar.Location = new System.Drawing.Point(395, 43);
            this.lfChar.Name = "lfChar";
            this.lfChar.Size = new System.Drawing.Size(100, 20);
            this.lfChar.TabIndex = 2;
            this.lfChar.Text = "\\r";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(501, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Timeout MS:";
            // 
            // timeoutMS
            // 
            this.timeoutMS.Location = new System.Drawing.Point(574, 43);
            this.timeoutMS.Name = "timeoutMS";
            this.timeoutMS.Size = new System.Drawing.Size(73, 20);
            this.timeoutMS.TabIndex = 2;
            this.timeoutMS.Text = "250";
            // 
            // COMTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.rtsEnable);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeoutMS);
            this.Controls.Add(this.dataBits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lfChar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.baudRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowControl);
            this.Controls.Add(this.stopBits);
            this.Controls.Add(this.parity);
            this.Controls.Add(this.comPortList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "COMTest";
            this.Text = "COMTest - By Latheesan Kanesamoorthy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.COMTest_FormClosing);
            this.Load += new System.EventHandler(this.COMTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comPortList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dataBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputData;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ComboBox parity;
        private System.Windows.Forms.ComboBox stopBits;
        private System.Windows.Forms.ComboBox flowControl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox rtsEnable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lfChar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox timeoutMS;
    }
}

