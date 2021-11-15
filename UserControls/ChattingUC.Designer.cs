
namespace Manachan.UserControls
{
    partial class ChattingUC
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
            this.ControlUserChatPanel = new System.Windows.Forms.Panel();
            this.SendMsgBox = new System.Windows.Forms.PictureBox();
            this.ChatTextbox = new System.Windows.Forms.TextBox();
            this.ChatDisplayPanel = new System.Windows.Forms.Panel();
            this.AlertMsgPanel = new System.Windows.Forms.Panel();
            this.AlertMsgLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ControlUserChatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendMsgBox)).BeginInit();
            this.AlertMsgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlUserChatPanel
            // 
            this.ControlUserChatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ControlUserChatPanel.Controls.Add(this.SendMsgBox);
            this.ControlUserChatPanel.Controls.Add(this.ChatTextbox);
            this.ControlUserChatPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlUserChatPanel.Location = new System.Drawing.Point(0, 418);
            this.ControlUserChatPanel.Name = "ControlUserChatPanel";
            this.ControlUserChatPanel.Size = new System.Drawing.Size(600, 47);
            this.ControlUserChatPanel.TabIndex = 1;
            // 
            // SendMsgBox
            // 
            this.SendMsgBox.Image = global::Manachan.Properties.Resources.tail;
            this.SendMsgBox.Location = new System.Drawing.Point(565, 11);
            this.SendMsgBox.Name = "SendMsgBox";
            this.SendMsgBox.Size = new System.Drawing.Size(32, 32);
            this.SendMsgBox.TabIndex = 1;
            this.SendMsgBox.TabStop = false;
            this.SendMsgBox.Click += new System.EventHandler(this.SendMsgBox_Click);
            // 
            // ChatTextbox
            // 
            this.ChatTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ChatTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatTextbox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatTextbox.ForeColor = System.Drawing.Color.Gray;
            this.ChatTextbox.Location = new System.Drawing.Point(8, 11);
            this.ChatTextbox.Name = "ChatTextbox";
            this.ChatTextbox.Size = new System.Drawing.Size(543, 20);
            this.ChatTextbox.TabIndex = 0;
            this.ChatTextbox.Text = "Write a message...";
            this.ChatTextbox.Enter += new System.EventHandler(this.ChatTextbox_Enter);
            this.ChatTextbox.Leave += new System.EventHandler(this.ChatTextbox_Leave);
            // 
            // ChatDisplayPanel
            // 
            this.ChatDisplayPanel.AutoScroll = true;
            this.ChatDisplayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ChatDisplayPanel.Location = new System.Drawing.Point(4, 9);
            this.ChatDisplayPanel.Name = "ChatDisplayPanel";
            this.ChatDisplayPanel.Size = new System.Drawing.Size(588, 411);
            this.ChatDisplayPanel.TabIndex = 2;
            // 
            // AlertMsgPanel
            // 
            this.AlertMsgPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(111)))), ((int)(((byte)(166)))));
            this.AlertMsgPanel.Controls.Add(this.AlertMsgLabel);
            this.AlertMsgPanel.Controls.Add(this.panel5);
            this.AlertMsgPanel.Controls.Add(this.panel4);
            this.AlertMsgPanel.Controls.Add(this.panel3);
            this.AlertMsgPanel.Controls.Add(this.panel2);
            this.AlertMsgPanel.Location = new System.Drawing.Point(600, 18);
            this.AlertMsgPanel.Name = "AlertMsgPanel";
            this.AlertMsgPanel.Size = new System.Drawing.Size(150, 62);
            this.AlertMsgPanel.TabIndex = 0;
            // 
            // AlertMsgLabel
            // 
            this.AlertMsgLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlertMsgLabel.Font = new System.Drawing.Font("Century", 9.75F);
            this.AlertMsgLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AlertMsgLabel.Location = new System.Drawing.Point(1, 1);
            this.AlertMsgLabel.Name = "AlertMsgLabel";
            this.AlertMsgLabel.Size = new System.Drawing.Size(148, 60);
            this.AlertMsgLabel.TabIndex = 5;
            this.AlertMsgLabel.Text = "Pesan kosong";
            this.AlertMsgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(149, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 60);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 60);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 1);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 1);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 1);
            this.panel1.TabIndex = 21;
            // 
            // ChattingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.ChatDisplayPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AlertMsgPanel);
            this.Controls.Add(this.ControlUserChatPanel);
            this.Name = "ChattingUC";
            this.Size = new System.Drawing.Size(600, 465);
            this.ControlUserChatPanel.ResumeLayout(false);
            this.ControlUserChatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendMsgBox)).EndInit();
            this.AlertMsgPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ControlUserChatPanel;
        private System.Windows.Forms.TextBox ChatTextbox;
        private System.Windows.Forms.PictureBox SendMsgBox;
        private System.Windows.Forms.Panel ChatDisplayPanel;
        private System.Windows.Forms.Panel AlertMsgPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AlertMsgLabel;
        private System.Windows.Forms.Panel panel1;
    }
}
