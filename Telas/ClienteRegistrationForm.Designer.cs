namespace Financeiro_2.Telas
{
    partial class ClientRegistrationForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnRemove = new Button();
            groupBox1 = new GroupBox();
            tbIdCliente = new TextBox();
            lblCodCliente = new Label();
            tbContact = new TextBox();
            lblContact = new Label();
            label3 = new Label();
            tbEmail = new TextBox();
            lblEmail = new Label();
            tbSalary = new TextBox();
            lblSalary = new Label();
            tbIncomeSource = new TextBox();
            lblFonteRenda = new Label();
            tbAddress = new TextBox();
            lblAddress = new Label();
            tbLastName = new TextBox();
            lblLastName = new Label();
            tbName = new TextBox();
            lblName = new Label();
            btnSave = new Button();
            DataRegisto = new DateTimePicker();
            lblRegistLoan = new GroupBox();
            btnClean = new Button();
            label4 = new Label();
            btnUpdate = new Button();
            panel1 = new Panel();
            lblRegistrationData = new Label();
            dgvDadosCliente = new DataGridView();
            groupBox1.SuspendLayout();
            lblRegistLoan.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDadosCliente).BeginInit();
            SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Maroon;
            btnRemove.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(73, 274);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(167, 49);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remover";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(tbIdCliente);
            groupBox1.Controls.Add(lblCodCliente);
            groupBox1.Controls.Add(tbContact);
            groupBox1.Controls.Add(lblContact);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dgvDadosCliente);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(tbSalary);
            groupBox1.Controls.Add(lblSalary);
            groupBox1.Controls.Add(tbIncomeSource);
            groupBox1.Controls.Add(lblFonteRenda);
            groupBox1.Controls.Add(tbAddress);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(tbLastName);
            groupBox1.Controls.Add(lblLastName);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(lblName);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(722, 517);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Cliente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tbIdCliente
            // 
            tbIdCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbIdCliente.Location = new Point(105, 40);
            tbIdCliente.Name = "tbIdCliente";
            tbIdCliente.ReadOnly = true;
            tbIdCliente.Size = new Size(600, 27);
            tbIdCliente.TabIndex = 19;
            // 
            // lblCodCliente
            // 
            lblCodCliente.AutoSize = true;
            lblCodCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodCliente.Location = new Point(4, 45);
            lblCodCliente.Name = "lblCodCliente";
            lblCodCliente.Size = new Size(85, 17);
            lblCodCliente.TabIndex = 18;
            lblCodCliente.Text = "Id do Cliente:";
            // 
            // tbContact
            // 
            tbContact.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbContact.Location = new Point(105, 140);
            tbContact.Name = "tbContact";
            tbContact.Size = new Size(338, 27);
            tbContact.TabIndex = 17;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblContact.Location = new Point(4, 145);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(63, 17);
            lblContact.TabIndex = 16;
            lblContact.Text = "Contacto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(678, 312);
            label3.Name = "label3";
            label3.Size = new Size(27, 17);
            label3.TabIndex = 15;
            label3.Text = "MT";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.Location = new Point(105, 196);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(338, 27);
            tbEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(4, 201);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 17);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "E-Mail:";
            // 
            // tbSalary
            // 
            tbSalary.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbSalary.Location = new Point(467, 302);
            tbSalary.Name = "tbSalary";
            tbSalary.Size = new Size(205, 27);
            tbSalary.TabIndex = 11;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalary.Location = new Point(367, 312);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(94, 17);
            lblSalary.TabIndex = 10;
            lblSalary.Text = "Renda Mensal:";
            // 
            // tbIncomeSource
            // 
            tbIncomeSource.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbIncomeSource.Location = new Point(105, 302);
            tbIncomeSource.Name = "tbIncomeSource";
            tbIncomeSource.Size = new Size(256, 27);
            tbIncomeSource.TabIndex = 9;
            // 
            // lblFonteRenda
            // 
            lblFonteRenda.AutoSize = true;
            lblFonteRenda.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFonteRenda.Location = new Point(4, 307);
            lblFonteRenda.Name = "lblFonteRenda";
            lblFonteRenda.Size = new Size(103, 17);
            lblFonteRenda.TabIndex = 8;
            lblFonteRenda.Text = "Fonte de Renda:";
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbAddress.Location = new Point(105, 252);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(600, 27);
            tbAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.Location = new Point(4, 257);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(66, 17);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Endereço:";
            // 
            // tbLastName
            // 
            tbLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbLastName.Location = new Point(467, 90);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(238, 27);
            tbLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(367, 90);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(56, 17);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Apelido:";
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(105, 90);
            tbName.Name = "tbName";
            tbName.Size = new Size(226, 27);
            tbName.TabIndex = 1;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(4, 95);
            lblName.Name = "lblName";
            lblName.Size = new Size(47, 17);
            lblName.TabIndex = 0;
            lblName.Text = "Nome:";
            lblName.Click += lblName_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkCyan;
            btnSave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(73, 94);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(167, 51);
            btnSave.TabIndex = 1;
            btnSave.Text = "Gravar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // DataRegisto
            // 
            DataRegisto.Location = new Point(3, 21);
            DataRegisto.Name = "DataRegisto";
            DataRegisto.Size = new Size(299, 22);
            DataRegisto.TabIndex = 2;
            DataRegisto.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblRegistLoan
            // 
            lblRegistLoan.BackColor = Color.White;
            lblRegistLoan.Controls.Add(btnClean);
            lblRegistLoan.Controls.Add(label4);
            lblRegistLoan.Controls.Add(btnRemove);
            lblRegistLoan.Controls.Add(btnUpdate);
            lblRegistLoan.Controls.Add(btnSave);
            lblRegistLoan.Location = new Point(749, 64);
            lblRegistLoan.Name = "lblRegistLoan";
            lblRegistLoan.Size = new Size(308, 473);
            lblRegistLoan.TabIndex = 2;
            lblRegistLoan.TabStop = false;
            lblRegistLoan.Text = "Operações";
            lblRegistLoan.Enter += groupBox2_Enter;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.Navy;
            btnClean.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(73, 212);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(167, 54);
            btnClean.TabIndex = 14;
            btnClean.Text = "Limpar";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(101, 448);
            label4.Name = "label4";
            label4.Size = new Size(192, 17);
            label4.TabIndex = 13;
            label4.Text = "Registar Dados do Empréstimo";
            label4.Click += label4_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(73, 152);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(167, 54);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblRegistrationData);
            panel1.Controls.Add(DataRegisto);
            panel1.Location = new Point(751, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 46);
            panel1.TabIndex = 3;
            // 
            // lblRegistrationData
            // 
            lblRegistrationData.AutoSize = true;
            lblRegistrationData.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistrationData.Location = new Point(0, 0);
            lblRegistrationData.Name = "lblRegistrationData";
            lblRegistrationData.Size = new Size(106, 17);
            lblRegistrationData.TabIndex = 3;
            lblRegistrationData.Text = "Data do Registo:";
            // 
            // dgvDadosCliente
            // 
            dgvDadosCliente.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDadosCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDadosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosCliente.Location = new Point(7, 359);
            dgvDadosCliente.Name = "dgvDadosCliente";
            dgvDadosCliente.RowTemplate.Height = 25;
            dgvDadosCliente.Size = new Size(698, 144);
            dgvDadosCliente.TabIndex = 14;
            dgvDadosCliente.CellContentClick += dataGridView1_CellContentClick;
            dgvDadosCliente.RowHeaderMouseClick += dgvDadosCliente_RowHeaderMouseClick;
            // 
            // ClientRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1060, 549);
            Controls.Add(panel1);
            Controls.Add(lblRegistLoan);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ClientRegistrationForm";
            Text = "Registo de Cliente";
            Load += ClientRegistrationForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            lblRegistLoan.ResumeLayout(false);
            lblRegistLoan.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDadosCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbEmail;
        private Label lblEmail;
        private TextBox tbSalary;
        private Label lblSalary;
        private TextBox tbIncomeSource;
        private Label lblFonteRenda;
        private TextBox textBox3;
        private Label lblIdCliente;
        private TextBox tbAddress;
        private Label lblAddress;
        private TextBox tbLastName;
        private Label lblLastName;
        private TextBox tbName;
        private Label lblName;
        private Button btnSave;
        private DateTimePicker DataRegisto;
        private GroupBox lblRegistLoan;
        private Label label3;
        private Button btnRemove;
        private Button btnUpdate;
        private Label label4;
        private Button btnClean;
        private TextBox tbContact;
        private Label lblContact;
        private Panel panel1;
        private Label lblRegistrationData;
        private TextBox tbIdCliente;
        private Label lblCodCliente;
        private DataGridView dgvDadosCliente;
    }
}