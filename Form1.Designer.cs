namespace StresserClientTutorial
{
    partial class Form1
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
            this.IP = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.ThreadCount = new System.Windows.Forms.TextBox();
            this.Attack = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(248, 157);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(146, 20);
            this.IP.TabIndex = 0;
            this.IP.Text = "Target IP";
            this.IP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(248, 236);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(146, 20);
            this.Port.TabIndex = 1;
            this.Port.Text = "Target Port";
            // 
            // ThreadCount
            // 
            this.ThreadCount.Location = new System.Drawing.Point(248, 325);
            this.ThreadCount.Name = "ThreadCount";
            this.ThreadCount.Size = new System.Drawing.Size(146, 20);
            this.ThreadCount.TabIndex = 2;
            this.ThreadCount.Text = "Amount Of Threads (500)";
            this.ThreadCount.TextChanged += new System.EventHandler(this.ThreadCount_TextChanged);
            // 
            // Attack
            // 
            this.Attack.Location = new System.Drawing.Point(259, 405);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(117, 49);
            this.Attack.TabIndex = 3;
            this.Attack.Text = "Start Attack";
            this.Attack.UseVisualStyleBackColor = true;
            this.Attack.Click += new System.EventHandler(this.Attack_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(259, 491);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(117, 49);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Stop Attack";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 626);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Attack);
            this.Controls.Add(this.ThreadCount);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.IP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox ThreadCount;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.Button Stop;
    }
}

