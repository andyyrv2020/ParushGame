namespace ParushGame.View
{
    partial class ParushDesktopView
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
            parushDesktopBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // parushDesktopBtn
            // 
            parushDesktopBtn.BackColor = Color.Transparent;
            parushDesktopBtn.BackgroundImage = Properties.Resources._20171030105429;
            parushDesktopBtn.BackgroundImageLayout = ImageLayout.Stretch;
            parushDesktopBtn.Location = new Point(185, 126);
            parushDesktopBtn.Name = "parushDesktopBtn";
            parushDesktopBtn.Size = new Size(356, 167);
            parushDesktopBtn.TabIndex = 0;
            parushDesktopBtn.UseVisualStyleBackColor = false;
            parushDesktopBtn.Click += parushDesktopBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Banner", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(608, 92);
            label1.TabIndex = 3;
            label1.Text = "Parush's Gaming Room";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Sitka Banner", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(119, 349);
            label2.Name = "label2";
            label2.Size = new Size(532, 92);
            label2.TabIndex = 4;
            label2.Text = "Click on the desktop";
            // 
            // ParushDesktopView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1000_F_480603273_SSCjQbLbcd1qsfreRwMGWpuK61M90gA71;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(parushDesktopBtn);
            Name = "ParushDesktopView";
            Text = "ParushDesktopView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button parushDesktopBtn;
        private Label label1;
        private Label label2;
    }
}