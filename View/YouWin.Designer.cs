﻿namespace ParushGame.View
{
    partial class YouWin
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(53, 343);
            label1.Name = "label1";
            label1.Size = new Size(609, 48);
            label1.TabIndex = 1;
            label1.Text = "YOU WON THE PARUSH IS HAPPY";
            // 
            // YouWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.IMG_4167_png_2023_11_28T22_20_08_827Z_output_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(722, 450);
            Controls.Add(label1);
            Name = "YouWin";
            Text = "YouWin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}