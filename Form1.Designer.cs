namespace ParushGame
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
            parushDoor = new Button();
            hasbullaDoor = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // parushDoor
            // 
            parushDoor.BackColor = Color.Transparent;
            parushDoor.BackgroundImageLayout = ImageLayout.Stretch;
            parushDoor.FlatStyle = FlatStyle.Popup;
            parushDoor.ForeColor = Color.Transparent;
            parushDoor.Location = new Point(183, 90);
            parushDoor.Name = "parushDoor";
            parushDoor.Size = new Size(141, 245);
            parushDoor.TabIndex = 0;
            parushDoor.UseVisualStyleBackColor = false;
            parushDoor.Click += parushDoor_Click;
            // 
            // hasbullaDoor
            // 
            hasbullaDoor.BackColor = Color.Transparent;
            hasbullaDoor.BackgroundImageLayout = ImageLayout.Stretch;
            hasbullaDoor.FlatStyle = FlatStyle.Popup;
            hasbullaDoor.ForeColor = Color.Transparent;
            hasbullaDoor.Location = new Point(389, 90);
            hasbullaDoor.Name = "hasbullaDoor";
            hasbullaDoor.Size = new Size(144, 245);
            hasbullaDoor.TabIndex = 1;
            hasbullaDoor.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Banner", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(141, -5);
            label1.Name = "label1";
            label1.Size = new Size(392, 92);
            label1.TabIndex = 2;
            label1.Text = "Choose a Door";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_400243690_ys9gDG7ngQkvJKJaRstaFVaVQ4CUikoW;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(717, 450);
            Controls.Add(label1);
            Controls.Add(hasbullaDoor);
            Controls.Add(parushDoor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button parushDoor;
        private Button hasbullaDoor;
        private Label label1;
    }
}