namespace CSharp_Booter
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
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_init = new System.Windows.Forms.Button();
            this.btn_launch = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.text_IP = new System.Windows.Forms.Label();
            this.text_time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label_action = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(37, 158);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(75, 23);
            this.btn_init.TabIndex = 3;
            this.btn_init.Text = "Initilize";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_launch
            // 
            this.btn_launch.Enabled = false;
            this.btn_launch.Location = new System.Drawing.Point(149, 158);
            this.btn_launch.Name = "btn_launch";
            this.btn_launch.Size = new System.Drawing.Size(75, 23);
            this.btn_launch.TabIndex = 4;
            this.btn_launch.Text = "Launch";
            this.btn_launch.UseVisualStyleBackColor = true;
            this.btn_launch.Click += new System.EventHandler(this.btn_launch_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.title.Location = new System.Drawing.Point(65, 33);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(132, 18);
            this.title.TabIndex = 2;
            this.title.Text = "Exploder\'s Booter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Settings";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(37, 87);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(187, 20);
            this.textBox_IP.TabIndex = 1;
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(37, 127);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(187, 20);
            this.textBox_time.TabIndex = 2;
            this.textBox_time.Text = "900";
            // 
            // text_IP
            // 
            this.text_IP.AutoSize = true;
            this.text_IP.Location = new System.Drawing.Point(36, 74);
            this.text_IP.Name = "text_IP";
            this.text_IP.Size = new System.Drawing.Size(20, 13);
            this.text_IP.TabIndex = 6;
            this.text_IP.Text = "IP:";
            // 
            // text_time
            // 
            this.text_time.AutoSize = true;
            this.text_time.Location = new System.Drawing.Point(36, 113);
            this.text_time.Name = "text_time";
            this.text_time.Size = new System.Drawing.Size(33, 13);
            this.text_time.TabIndex = 7;
            this.text_time.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status:";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(50, 190);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(45, 13);
            this.label_status.TabIndex = 9;
            this.label_status.Text = "Inactive";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.iPListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(263, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // iPListToolStripMenuItem
            // 
            this.iPListToolStripMenuItem.Name = "iPListToolStripMenuItem";
            this.iPListToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.iPListToolStripMenuItem.Text = "IP List";
            this.iPListToolStripMenuItem.Click += new System.EventHandler(this.iPListToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Action:";
            // 
            // label_action
            // 
            this.label_action.AutoSize = true;
            this.label_action.Location = new System.Drawing.Point(52, 207);
            this.label_action.Name = "label_action";
            this.label_action.Size = new System.Drawing.Size(33, 13);
            this.label_action.TabIndex = 12;
            this.label_action.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 225);
            this.Controls.Add(this.label_action);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_time);
            this.Controls.Add(this.text_IP);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btn_launch);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Booter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Button btn_launch;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.Label text_IP;
        private System.Windows.Forms.Label text_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPListToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_action;
    }
}

