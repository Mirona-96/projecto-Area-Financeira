namespace Financeiro_2.Telas
{
    partial class DashboardForm
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
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            emprestimosToolStripMenuItem = new ToolStripMenuItem();
            pagamentosToolStripMenuItem = new ToolStripMenuItem();
            utlizadoresToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            UsersLabel = new Label();
            TotalUsersCountLabel = new Label();
            panel3 = new Panel();
            label1 = new Label();
            TotalCustomersLabel = new Label();
            panel4 = new Panel();
            label3 = new Label();
            SumEmprestimosLabel = new Label();
            panel5 = new Panel();
            SumPagamentosLabel = new Label();
            label6 = new Label();
            panel6 = new Panel();
            UserTypeLabel = new Label();
            UsersButton = new Button();
            CustomersButton = new Button();
            EmprestimosButton = new Button();
            PagamentosButton = new Button();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, emprestimosToolStripMenuItem, pagamentosToolStripMenuItem, utlizadoresToolStripMenuItem, infoToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1199, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // emprestimosToolStripMenuItem
            // 
            emprestimosToolStripMenuItem.Name = "emprestimosToolStripMenuItem";
            emprestimosToolStripMenuItem.Size = new Size(88, 20);
            emprestimosToolStripMenuItem.Text = "Emprestimos";
            emprestimosToolStripMenuItem.Click += emprestimosToolStripMenuItem_Click;
            // 
            // pagamentosToolStripMenuItem
            // 
            pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            pagamentosToolStripMenuItem.Size = new Size(85, 20);
            pagamentosToolStripMenuItem.Text = "Pagamentos";
            pagamentosToolStripMenuItem.Click += pagamentosToolStripMenuItem_Click;
            // 
            // utlizadoresToolStripMenuItem
            // 
            utlizadoresToolStripMenuItem.Name = "utlizadoresToolStripMenuItem";
            utlizadoresToolStripMenuItem.Size = new Size(77, 20);
            utlizadoresToolStripMenuItem.Text = "Utlizadores";
            utlizadoresToolStripMenuItem.Click += utlizadoresToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(40, 20);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 24);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 514);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Brown;
            panel2.Controls.Add(UsersLabel);
            panel2.Controls.Add(TotalUsersCountLabel);
            panel2.Location = new Point(289, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 123);
            panel2.TabIndex = 2;
            // 
            // UsersLabel
            // 
            UsersLabel.AutoSize = true;
            UsersLabel.BackColor = Color.Transparent;
            UsersLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            UsersLabel.ForeColor = Color.White;
            UsersLabel.Location = new Point(25, 73);
            UsersLabel.Name = "UsersLabel";
            UsersLabel.Size = new Size(98, 18);
            UsersLabel.TabIndex = 1;
            UsersLabel.Text = "Utilizadores";
            // 
            // TotalUsersCountLabel
            // 
            TotalUsersCountLabel.AutoSize = true;
            TotalUsersCountLabel.BackColor = Color.Transparent;
            TotalUsersCountLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            TotalUsersCountLabel.ForeColor = Color.White;
            TotalUsersCountLabel.Location = new Point(24, 19);
            TotalUsersCountLabel.Name = "TotalUsersCountLabel";
            TotalUsersCountLabel.Size = new Size(25, 26);
            TotalUsersCountLabel.TabIndex = 0;
            TotalUsersCountLabel.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Chocolate;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(TotalCustomersLabel);
            panel3.Location = new Point(578, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(232, 123);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 73);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // TotalCustomersLabel
            // 
            TotalCustomersLabel.AutoSize = true;
            TotalCustomersLabel.BackColor = Color.Transparent;
            TotalCustomersLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            TotalCustomersLabel.ForeColor = Color.White;
            TotalCustomersLabel.Location = new Point(24, 19);
            TotalCustomersLabel.Name = "TotalCustomersLabel";
            TotalCustomersLabel.Size = new Size(25, 26);
            TotalCustomersLabel.TabIndex = 0;
            TotalCustomersLabel.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SeaGreen;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(SumEmprestimosLabel);
            panel4.Location = new Point(870, 132);
            panel4.Name = "panel4";
            panel4.Size = new Size(242, 123);
            panel4.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 73);
            label3.Name = "label3";
            label3.Size = new Size(174, 18);
            label3.TabIndex = 1;
            label3.Text = "Total de Emprestimos";
            // 
            // SumEmprestimosLabel
            // 
            SumEmprestimosLabel.AutoSize = true;
            SumEmprestimosLabel.BackColor = Color.Transparent;
            SumEmprestimosLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            SumEmprestimosLabel.ForeColor = Color.White;
            SumEmprestimosLabel.Location = new Point(24, 19);
            SumEmprestimosLabel.Name = "SumEmprestimosLabel";
            SumEmprestimosLabel.Size = new Size(58, 26);
            SumEmprestimosLabel.TabIndex = 0;
            SumEmprestimosLabel.Text = "0.00";
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSeaGreen;
            panel5.Controls.Add(SumPagamentosLabel);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(1307, 125);
            panel5.Name = "panel5";
            panel5.Size = new Size(242, 123);
            panel5.TabIndex = 4;
            // 
            // SumPagamentosLabel
            // 
            SumPagamentosLabel.AutoSize = true;
            SumPagamentosLabel.BackColor = Color.Transparent;
            SumPagamentosLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            SumPagamentosLabel.ForeColor = Color.White;
            SumPagamentosLabel.Location = new Point(25, 73);
            SumPagamentosLabel.Name = "SumPagamentosLabel";
            SumPagamentosLabel.Size = new Size(168, 18);
            SumPagamentosLabel.TabIndex = 1;
            SumPagamentosLabel.Text = "Total de Pagamentos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 19);
            label6.Name = "label6";
            label6.Size = new Size(58, 26);
            label6.TabIndex = 0;
            label6.Text = "0.00";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.AppWorkspace;
            panel6.Controls.Add(UserTypeLabel);
            panel6.Dock = DockStyle.Top;
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(259, 24);
            panel6.Name = "panel6";
            panel6.Size = new Size(940, 51);
            panel6.TabIndex = 5;
            // 
            // UserTypeLabel
            // 
            UserTypeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UserTypeLabel.AutoSize = true;
            UserTypeLabel.BackColor = Color.Transparent;
            UserTypeLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            UserTypeLabel.ForeColor = Color.White;
            UserTypeLabel.Location = new Point(823, 14);
            UserTypeLabel.Name = "UserTypeLabel";
            UserTypeLabel.Size = new Size(52, 17);
            UserTypeLabel.TabIndex = 2;
            UserTypeLabel.Text = "Admin";
            // 
            // UsersButton
            // 
            UsersButton.BackColor = Color.Transparent;
            UsersButton.FlatAppearance.BorderSize = 2;
            UsersButton.FlatStyle = FlatStyle.Flat;
            UsersButton.ForeColor = Color.Maroon;
            UsersButton.Location = new Point(289, 260);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(232, 44);
            UsersButton.TabIndex = 6;
            UsersButton.Text = "Utitlizadores";
            UsersButton.UseVisualStyleBackColor = false;
            UsersButton.Click += UsersButton_Click;
            // 
            // CustomersButton
            // 
            CustomersButton.BackColor = Color.Transparent;
            CustomersButton.FlatAppearance.BorderSize = 2;
            CustomersButton.FlatStyle = FlatStyle.Flat;
            CustomersButton.ForeColor = Color.Chocolate;
            CustomersButton.Location = new Point(578, 260);
            CustomersButton.Name = "CustomersButton";
            CustomersButton.Size = new Size(232, 44);
            CustomersButton.TabIndex = 7;
            CustomersButton.Text = "Clientes";
            CustomersButton.UseVisualStyleBackColor = false;
            // 
            // EmprestimosButton
            // 
            EmprestimosButton.BackColor = Color.Transparent;
            EmprestimosButton.FlatAppearance.BorderSize = 2;
            EmprestimosButton.FlatStyle = FlatStyle.Flat;
            EmprestimosButton.ForeColor = Color.SeaGreen;
            EmprestimosButton.Location = new Point(870, 260);
            EmprestimosButton.Name = "EmprestimosButton";
            EmprestimosButton.Size = new Size(242, 44);
            EmprestimosButton.TabIndex = 8;
            EmprestimosButton.Text = "Emprestimos";
            EmprestimosButton.UseVisualStyleBackColor = false;
            // 
            // PagamentosButton
            // 
            PagamentosButton.BackColor = Color.Transparent;
            PagamentosButton.FlatAppearance.BorderSize = 2;
            PagamentosButton.FlatStyle = FlatStyle.Flat;
            PagamentosButton.ForeColor = Color.LightSeaGreen;
            PagamentosButton.Location = new Point(1307, 253);
            PagamentosButton.Name = "PagamentosButton";
            PagamentosButton.Size = new Size(242, 44);
            PagamentosButton.TabIndex = 9;
            PagamentosButton.Text = "Pagamentos";
            PagamentosButton.UseVisualStyleBackColor = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 538);
            Controls.Add(PagamentosButton);
            Controls.Add(EmprestimosButton);
            Controls.Add(CustomersButton);
            Controls.Add(UsersButton);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "DashboardForm";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += DashboardForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprestimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.Label TotalUsersCountLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalCustomersLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SumEmprestimosLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label SumPagamentosLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label UserTypeLabel;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utlizadoresToolStripMenuItem;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button EmprestimosButton;
        private System.Windows.Forms.Button PagamentosButton;
    }
}

