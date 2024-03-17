namespace ObserverPatternExample
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
            panel1 = new Panel();
            nightButton = new Button();
            eveningButton = new Button();
            afternoonButton = new Button();
            morningButton = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            pictureboxtree = new PictureBox();
            pictureboxhouse = new PictureBox();
            pictureboxdird = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxtree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureboxhouse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureboxdird).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(nightButton);
            panel1.Controls.Add(eveningButton);
            panel1.Controls.Add(afternoonButton);
            panel1.Controls.Add(morningButton);
            panel1.Location = new Point(693, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 189);
            panel1.TabIndex = 0;
            // 
            // nightButton
            // 
            nightButton.Location = new Point(3, 114);
            nightButton.Name = "nightButton";
            nightButton.Size = new Size(96, 31);
            nightButton.TabIndex = 3;
            nightButton.Text = "night";
            nightButton.UseVisualStyleBackColor = true;
            nightButton.Click += nightButton_Click;
            // 
            // eveningButton
            // 
            eveningButton.Location = new Point(3, 77);
            eveningButton.Name = "eveningButton";
            eveningButton.Size = new Size(96, 31);
            eveningButton.TabIndex = 2;
            eveningButton.Text = "evening";
            eveningButton.UseVisualStyleBackColor = true;
            eveningButton.Click += eveningButton_Click;
            // 
            // afternoonButton
            // 
            afternoonButton.Location = new Point(3, 40);
            afternoonButton.Name = "afternoonButton";
            afternoonButton.Size = new Size(96, 31);
            afternoonButton.TabIndex = 1;
            afternoonButton.Text = "afternoon";
            afternoonButton.UseVisualStyleBackColor = true;
            afternoonButton.Click += afternoonButton_Click;
            // 
            // morningButton
            // 
            morningButton.Location = new Point(3, 3);
            morningButton.Name = "morningButton";
            morningButton.Size = new Size(96, 31);
            morningButton.TabIndex = 0;
            morningButton.Text = "morning";
            morningButton.UseVisualStyleBackColor = true;
            morningButton.Click += morningButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(653, 527);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBox3);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Location = new Point(696, 223);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 128);
            panel2.TabIndex = 2;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(13, 70);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(50, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "птах";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(13, 45);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(64, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "дерево";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(13, 20);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "будинок";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureboxtree
            // 
            pictureboxtree.Location = new Point(48, 302);
            pictureboxtree.Name = "pictureboxtree";
            pictureboxtree.Size = new Size(87, 201);
            pictureboxtree.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureboxtree.TabIndex = 3;
            pictureboxtree.TabStop = false;
            pictureboxtree.Visible = false;
            // 
            // pictureboxhouse
            // 
            pictureboxhouse.Location = new Point(243, 341);
            pictureboxhouse.Name = "pictureboxhouse";
            pictureboxhouse.Size = new Size(188, 201);
            pictureboxhouse.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureboxhouse.TabIndex = 4;
            pictureboxhouse.TabStop = false;
            pictureboxhouse.Visible = false;
            // 
            // pictureboxdird
            // 
            pictureboxdird.Location = new Point(509, 196);
            pictureboxdird.Name = "pictureboxdird";
            pictureboxdird.Size = new Size(101, 66);
            pictureboxdird.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxdird.TabIndex = 5;
            pictureboxdird.TabStop = false;
            pictureboxdird.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 554);
            Controls.Add(pictureboxdird);
            Controls.Add(pictureboxhouse);
            Controls.Add(pictureboxtree);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxtree).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureboxhouse).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureboxdird).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button nightButton;
        private Button eveningButton;
        private Button afternoonButton;
        private Button morningButton;
        private PictureBox pictureBox1;
        private Panel panel2;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private PictureBox pictureboxtree;
        private PictureBox pictureboxhouse;
        private PictureBox pictureboxdird;
    }
}
