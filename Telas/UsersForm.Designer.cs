namespace Financeiro_2.Telas
{
    partial class UsersForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminRadioButton = new System.Windows.Forms.RadioButton();
            this.UserRadioButton = new System.Windows.Forms.RadioButton();
            this.SaveUserButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.CleanFieldButton = new System.Windows.Forms.Button();
            this.ShowPassowrdCheckBox = new System.Windows.Forms.CheckBox();
            this.UsersGroupBox = new System.Windows.Forms.GroupBox();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.UsersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 638);
            this.panel1.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(93, 48);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(157, 20);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Nome do Utilizador:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(97, 71);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(347, 29);
            this.UsernameTextBox.TabIndex = 2;
            // 
            // UserPasswordTextBox
            // 
            this.UserPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPasswordTextBox.Location = new System.Drawing.Point(97, 162);
            this.UserPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserPasswordTextBox.Name = "UserPasswordTextBox";
            this.UserPasswordTextBox.Size = new System.Drawing.Size(347, 29);
            this.UserPasswordTextBox.TabIndex = 4;
            this.UserPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Palavra-passe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nivel:";
            // 
            // AdminRadioButton
            // 
            this.AdminRadioButton.AutoSize = true;
            this.AdminRadioButton.Location = new System.Drawing.Point(152, 251);
            this.AdminRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.AdminRadioButton.Name = "AdminRadioButton";
            this.AdminRadioButton.Size = new System.Drawing.Size(66, 20);
            this.AdminRadioButton.TabIndex = 7;
            this.AdminRadioButton.TabStop = true;
            this.AdminRadioButton.Text = "Admin";
            this.AdminRadioButton.UseVisualStyleBackColor = true;
            // 
            // UserRadioButton
            // 
            this.UserRadioButton.AutoSize = true;
            this.UserRadioButton.Location = new System.Drawing.Point(232, 251);
            this.UserRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.UserRadioButton.Name = "UserRadioButton";
            this.UserRadioButton.Size = new System.Drawing.Size(57, 20);
            this.UserRadioButton.TabIndex = 8;
            this.UserRadioButton.TabStop = true;
            this.UserRadioButton.Text = "User";
            this.UserRadioButton.UseVisualStyleBackColor = true;
            // 
            // SaveUserButton
            // 
            this.SaveUserButton.BackColor = System.Drawing.Color.SeaGreen;
            this.SaveUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveUserButton.ForeColor = System.Drawing.Color.White;
            this.SaveUserButton.Location = new System.Drawing.Point(97, 311);
            this.SaveUserButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveUserButton.Name = "SaveUserButton";
            this.SaveUserButton.Size = new System.Drawing.Size(111, 47);
            this.SaveUserButton.TabIndex = 9;
            this.SaveUserButton.Text = "Gravar";
            this.SaveUserButton.UseVisualStyleBackColor = false;
            this.SaveUserButton.Click += new System.EventHandler(this.SaveUserButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.BackColor = System.Drawing.Color.Maroon;
            this.DeleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserButton.ForeColor = System.Drawing.Color.White;
            this.DeleteUserButton.Location = new System.Drawing.Point(216, 311);
            this.DeleteUserButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(111, 47);
            this.DeleteUserButton.TabIndex = 10;
            this.DeleteUserButton.Text = "Remover";
            this.DeleteUserButton.UseVisualStyleBackColor = false;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // CleanFieldButton
            // 
            this.CleanFieldButton.BackColor = System.Drawing.Color.Navy;
            this.CleanFieldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanFieldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanFieldButton.ForeColor = System.Drawing.Color.White;
            this.CleanFieldButton.Location = new System.Drawing.Point(335, 311);
            this.CleanFieldButton.Margin = new System.Windows.Forms.Padding(4);
            this.CleanFieldButton.Name = "CleanFieldButton";
            this.CleanFieldButton.Size = new System.Drawing.Size(111, 47);
            this.CleanFieldButton.TabIndex = 11;
            this.CleanFieldButton.Text = "Limpar";
            this.CleanFieldButton.UseVisualStyleBackColor = false;
            this.CleanFieldButton.Click += new System.EventHandler(this.CleanFieldButton_Click);
            // 
            // ShowPassowrdCheckBox
            // 
            this.ShowPassowrdCheckBox.AutoSize = true;
            this.ShowPassowrdCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassowrdCheckBox.Location = new System.Drawing.Point(97, 202);
            this.ShowPassowrdCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ShowPassowrdCheckBox.Name = "ShowPassowrdCheckBox";
            this.ShowPassowrdCheckBox.Size = new System.Drawing.Size(177, 22);
            this.ShowPassowrdCheckBox.TabIndex = 12;
            this.ShowPassowrdCheckBox.Text = "Mostrar palavra passe";
            this.ShowPassowrdCheckBox.UseVisualStyleBackColor = true;
            this.ShowPassowrdCheckBox.CheckedChanged += new System.EventHandler(this.ShowPassowrdCheckBox_CheckedChanged);
            // 
            // UsersGroupBox
            // 
            this.UsersGroupBox.Controls.Add(this.UsersDataGridView);
            this.UsersGroupBox.Location = new System.Drawing.Point(473, 18);
            this.UsersGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsersGroupBox.Name = "UsersGroupBox";
            this.UsersGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.UsersGroupBox.Size = new System.Drawing.Size(1015, 607);
            this.UsersGroupBox.TabIndex = 13;
            this.UsersGroupBox.TabStop = false;
            this.UsersGroupBox.Text = "Utilizadores";
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AllowUserToAddRows = false;
            this.UsersDataGridView.AllowUserToDeleteRows = false;
            this.UsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersDataGridView.Location = new System.Drawing.Point(4, 19);
            this.UsersDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.ReadOnly = true;
            this.UsersDataGridView.RowHeadersWidth = 51;
            this.UsersDataGridView.Size = new System.Drawing.Size(1007, 584);
            this.UsersDataGridView.TabIndex = 0;
            this.UsersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGridView_CellDoubleClick);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 638);
            this.Controls.Add(this.UsersGroupBox);
            this.Controls.Add(this.ShowPassowrdCheckBox);
            this.Controls.Add(this.CleanFieldButton);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.SaveUserButton);
            this.Controls.Add(this.UserRadioButton);
            this.Controls.Add(this.AdminRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserPasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsersForm";
            this.Text = "Gestão de Utilizadores";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.UsersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox UserPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton AdminRadioButton;
        private System.Windows.Forms.RadioButton UserRadioButton;
        private System.Windows.Forms.Button SaveUserButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button CleanFieldButton;
        private System.Windows.Forms.CheckBox ShowPassowrdCheckBox;
        private System.Windows.Forms.GroupBox UsersGroupBox;
        private System.Windows.Forms.DataGridView UsersDataGridView;
    }
}