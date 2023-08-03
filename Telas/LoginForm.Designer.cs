namespace Financeiro_2.Telas
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            ExitAppButton = new Button();
            UserLoginButton = new Button();
            ShowPasswordCheckBox = new CheckBox();
            UserPasswordTextBox = new TextBox();
            label1 = new Label();
            UserNameTextBox = new TextBox();
            UserLoginNameLabel = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(ExitAppButton);
            panel1.Controls.Add(UserLoginButton);
            panel1.Controls.Add(ShowPasswordCheckBox);
            panel1.Controls.Add(UserPasswordTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(UserNameTextBox);
            panel1.Controls.Add(UserLoginNameLabel);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(467, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 565);
            panel1.TabIndex = 0;
            // 
            // ExitAppButton
            // 
            ExitAppButton.BackColor = SystemColors.ActiveCaptionText;
            ExitAppButton.FlatStyle = FlatStyle.Popup;
            ExitAppButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ExitAppButton.ForeColor = Color.White;
            ExitAppButton.Location = new Point(74, 403);
            ExitAppButton.Name = "ExitAppButton";
            ExitAppButton.Size = new Size(332, 48);
            ExitAppButton.TabIndex = 6;
            ExitAppButton.Text = "Sair";
            ExitAppButton.UseVisualStyleBackColor = false;
            ExitAppButton.Click += ExitAppButton_Click;
            // 
            // UserLoginButton
            // 
            UserLoginButton.BackColor = Color.SeaGreen;
            UserLoginButton.FlatStyle = FlatStyle.Popup;
            UserLoginButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            UserLoginButton.ForeColor = Color.White;
            UserLoginButton.Location = new Point(74, 342);
            UserLoginButton.Name = "UserLoginButton";
            UserLoginButton.Size = new Size(332, 46);
            UserLoginButton.TabIndex = 5;
            UserLoginButton.Text = "Entrar";
            UserLoginButton.UseVisualStyleBackColor = false;
            UserLoginButton.Click += UserLoginButton_Click;
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ShowPasswordCheckBox.Location = new Point(74, 269);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(181, 21);
            ShowPasswordCheckBox.TabIndex = 4;
            ShowPasswordCheckBox.Text = "Mostrar a palavra-passe";
            ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // UserPasswordTextBox
            // 
            UserPasswordTextBox.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UserPasswordTextBox.Location = new Point(74, 222);
            UserPasswordTextBox.Name = "UserPasswordTextBox";
            UserPasswordTextBox.Size = new Size(332, 28);
            UserPasswordTextBox.TabIndex = 3;
            UserPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(71, 190);
            label1.Name = "label1";
            label1.Size = new Size(106, 18);
            label1.TabIndex = 2;
            label1.Text = "Palavra-passe:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameTextBox.Location = new Point(74, 132);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(332, 28);
            UserNameTextBox.TabIndex = 1;
            // 
            // UserLoginNameLabel
            // 
            UserLoginNameLabel.AutoSize = true;
            UserLoginNameLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            UserLoginNameLabel.Location = new Point(71, 100);
            UserLoginNameLabel.Name = "UserLoginNameLabel";
            UserLoginNameLabel.Size = new Size(137, 18);
            UserLoginNameLabel.TabIndex = 0;
            UserLoginNameLabel.Text = "Nome do Utlizador:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 301);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 565);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "Txuna Mola - Entrar";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitAppButton;
        private System.Windows.Forms.Button UserLoginButton;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.TextBox UserPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label UserLoginNameLabel;
        private PictureBox pictureBox1;
    }
}