namespace ParushGame.View
{
    partial class ParushFoundYou
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
            buttonRun = new Button();
            buttonBribe = new Button();
            buttonFight = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(64, 392);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(117, 54);
            buttonRun.TabIndex = 0;
            buttonRun.Text = "RUN";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // buttonBribe
            // 
            buttonBribe.Location = new Point(187, 392);
            buttonBribe.Name = "buttonBribe";
            buttonBribe.Size = new Size(117, 54);
            buttonBribe.TabIndex = 1;
            buttonBribe.Text = "BRIBE";
            buttonBribe.UseVisualStyleBackColor = true;
            buttonBribe.Click += buttonBribe_Click;
            // 
            // buttonFight
            // 
            buttonFight.Location = new Point(310, 392);
            buttonFight.Name = "buttonFight";
            buttonFight.Size = new Size(117, 54);
            buttonFight.TabIndex = 2;
            buttonFight.Text = "FIGHT";
            buttonFight.UseVisualStyleBackColor = true;
            buttonFight.Click += buttonFight_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 297);
            label1.Name = "label1";
            label1.Size = new Size(100, 39);
            label1.TabIndex = 4;
            label1.Text = "OH NO!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(12, 336);
            label2.Name = "label2";
            label2.Size = new Size(463, 39);
            label2.TabIndex = 5;
            label2.Text = "YOU HAVE  ENCOUNTERED THE PARUSH";
            // 
            // ParushFoundYou
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._406334136_2582523091917605_3212516689986705504_n;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(547, 508);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonFight);
            Controls.Add(buttonBribe);
            Controls.Add(buttonRun);
            Name = "ParushFoundYou";
            Text = "ParushFoundYou";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRun;
        private Button buttonBribe;
        private Button buttonFight;
        private Label label1;
        private Label label2;
    }
}