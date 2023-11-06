using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VnaScpier
{
    partial class Form1
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
            this.tbVisaAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbScpiCommand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnWriteRead = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbVisaAddress
            // 
            this.tbVisaAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbVisaAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbVisaAddress.Location = new System.Drawing.Point(24, 75);
            this.tbVisaAddress.Name = "tbVisaAddress";
            this.tbVisaAddress.Size = new System.Drawing.Size(469, 29);
            this.tbVisaAddress.TabIndex = 3;
            this.tbVisaAddress.Text = "NOT FOUND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "VISA Address";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConnect.Location = new System.Drawing.Point(517, 55);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(130, 53);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbScpiCommand
            // 
            this.tbScpiCommand.AllowDrop = true;
            this.tbScpiCommand.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbScpiCommand.Location = new System.Drawing.Point(24, 144);
            this.tbScpiCommand.Multiline = true;
            this.tbScpiCommand.Name = "tbScpiCommand";
            this.tbScpiCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbScpiCommand.Size = new System.Drawing.Size(469, 139);
            this.tbScpiCommand.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "SCPI Command";
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnWrite.Location = new System.Drawing.Point(517, 153);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnWrite.Size = new System.Drawing.Size(130, 53);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnWriteRead
            // 
            this.btnWriteRead.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnWriteRead.Location = new System.Drawing.Point(517, 230);
            this.btnWriteRead.Name = "btnWriteRead";
            this.btnWriteRead.Size = new System.Drawing.Size(130, 53);
            this.btnWriteRead.TabIndex = 2;
            this.btnWriteRead.Text = "Write/Read";
            this.btnWriteRead.UseVisualStyleBackColor = true;
            this.btnWriteRead.Click += new System.EventHandler(this.btnWriteRead_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbOutput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbOutput.Location = new System.Drawing.Point(24, 311);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(623, 150);
            this.tbOutput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output Box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(676, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.btnWriteRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbScpiCommand);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVisaAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "VNA SCPIer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbVisaAddress;
        private Label label1;
        private Button btnConnect;
        private TextBox tbScpiCommand;
        private Label label2;
        private Button btnWrite;
        private Button btnWriteRead;
        private TextBox tbOutput;
        private Label label3;
    }
}