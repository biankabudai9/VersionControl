namespace week08
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.Button();
            this.car = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.buttoncolor = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.buttoncolor);
            this.mainPanel.Controls.Add(this.label);
            this.mainPanel.Controls.Add(this.ball);
            this.mainPanel.Controls.Add(this.car);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(206, 40);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(89, 17);
            this.label.TabIndex = 2;
            this.label.Text = "Coming next:";
            // 
            // ball
            // 
            this.ball.Location = new System.Drawing.Point(475, 34);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(75, 23);
            this.ball.TabIndex = 1;
            this.ball.Text = "BALL";
            this.ball.UseVisualStyleBackColor = true;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // car
            // 
            this.car.Location = new System.Drawing.Point(357, 35);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(75, 23);
            this.car.TabIndex = 0;
            this.car.Text = "CAR";
            this.car.UseVisualStyleBackColor = true;
            this.car.Click += new System.EventHandler(this.car_Click);
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            // 
            // buttoncolor
            // 
            this.buttoncolor.BackColor = System.Drawing.Color.Fuchsia;
            this.buttoncolor.Location = new System.Drawing.Point(663, 34);
            this.buttoncolor.Name = "buttoncolor";
            this.buttoncolor.Size = new System.Drawing.Size(75, 23);
            this.buttoncolor.TabIndex = 3;
            this.buttoncolor.UseVisualStyleBackColor = false;
            this.buttoncolor.Click += new System.EventHandler(this.buttoncolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button ball;
        private System.Windows.Forms.Button car;
        private System.Windows.Forms.Button buttoncolor;
    }
}

