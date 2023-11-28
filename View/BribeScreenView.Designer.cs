namespace ParushGame.View
{
    partial class BribeScreenView
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
            label2 = new Label();
            pizzaButton = new Button();
            donutButton = new Button();
            burgerButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(122, 199);
            label2.Name = "label2";
            label2.Size = new Size(506, 48);
            label2.TabIndex = 2;
            label2.Text = "WHAT THE PARUSH LOVES?";
            // 
            // pizzaButton
            // 
            pizzaButton.Location = new Point(122, 275);
            pizzaButton.Name = "pizzaButton";
            pizzaButton.Size = new Size(95, 95);
            pizzaButton.TabIndex = 3;
            pizzaButton.Text = "PIZZA";
            pizzaButton.UseVisualStyleBackColor = true;
            pizzaButton.Click += pizzaButton_Click;
            // 
            // donutButton
            // 
            donutButton.Location = new Point(321, 275);
            donutButton.Name = "donutButton";
            donutButton.Size = new Size(95, 95);
            donutButton.TabIndex = 4;
            donutButton.Text = "DONUT";
            donutButton.UseVisualStyleBackColor = true;
            donutButton.Click += donutButton_Click;
            // 
            // burgerButton
            // 
            burgerButton.Location = new Point(533, 275);
            burgerButton.Name = "burgerButton";
            burgerButton.Size = new Size(95, 95);
            burgerButton.TabIndex = 5;
            burgerButton.Text = "BURGER";
            burgerButton.UseVisualStyleBackColor = true;
            burgerButton.Click += burgerButton_Click;
            // 
            // BribeScreenView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.IMG_4167;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(burgerButton);
            Controls.Add(donutButton);
            Controls.Add(pizzaButton);
            Controls.Add(label2);
            Name = "BribeScreenView";
            Text = "BribeScreenView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button pizzaButton;
        private Button donutButton;
        private Button burgerButton;
    }
}