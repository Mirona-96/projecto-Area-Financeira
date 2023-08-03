namespace FInanceiro_3._0
{
    partial class LoanRegistrationForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnRemove = new Button();
            groupBox1 = new GroupBox();
            label14 = new Label();
            TotalJurosTextBox = new TextBox();
            label15 = new Label();
            ClientesComboBox1 = new ComboBox();
            label12 = new Label();
            PrestacaoMensalTextBox = new TextBox();
            label13 = new Label();
            label10 = new Label();
            ValorGarantiaTextBox = new TextBox();
            label11 = new Label();
            label9 = new Label();
            DescricaoGarantiaTextBox = new TextBox();
            label5 = new Label();
            TotalPagarTextBox = new TextBox();
            label4 = new Label();
            DataAprovacaoDateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label8 = new Label();
            cmbStatus = new ComboBox();
            label7 = new Label();
            ValorEmprestimoTextBox = new TextBox();
            label6 = new Label();
            EmprestimoDataGridView = new DataGridView();
            TaxaJuroTextBox = new TextBox();
            lblEmail = new Label();
            lblIdCliente = new Label();
            label1 = new Label();
            lblApelido = new Label();
            PrazoTextBox = new TextBox();
            lblName = new Label();
            lblRegistLoan = new GroupBox();
            SimularEmprestimoButton = new Button();
            btnClean = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmprestimoDataGridView).BeginInit();
            lblRegistLoan.SuspendLayout();
            SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Maroon;
            btnRemove.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(72, 321);
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
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(TotalJurosTextBox);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(ClientesComboBox1);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(PrestacaoMensalTextBox);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(ValorGarantiaTextBox);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(DescricaoGarantiaTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TotalPagarTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(DataAprovacaoDateTimePicker2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(ValorEmprestimoTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(EmprestimoDataGridView);
            groupBox1.Controls.Add(TaxaJuroTextBox);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblIdCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblApelido);
            groupBox1.Controls.Add(PrazoTextBox);
            groupBox1.Controls.Add(lblName);
            groupBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(788, 525);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Empréstimo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(295, 345);
            label14.Name = "label14";
            label14.Size = new Size(27, 17);
            label14.TabIndex = 41;
            label14.Text = "MT";
            // 
            // TotalJurosTextBox
            // 
            TotalJurosTextBox.Enabled = false;
            TotalJurosTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TotalJurosTextBox.Location = new Point(139, 332);
            TotalJurosTextBox.Name = "TotalJurosTextBox";
            TotalJurosTextBox.Size = new Size(154, 27);
            TotalJurosTextBox.TabIndex = 40;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(8, 340);
            label15.Name = "label15";
            label15.Size = new Size(93, 17);
            label15.TabIndex = 39;
            label15.Text = "Total de Juros:";
            // 
            // ClientesComboBox1
            // 
            ClientesComboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ClientesComboBox1.FormattingEnabled = true;
            ClientesComboBox1.Location = new Point(139, 47);
            ClientesComboBox1.Name = "ClientesComboBox1";
            ClientesComboBox1.Size = new Size(613, 28);
            ClientesComboBox1.TabIndex = 38;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(295, 303);
            label12.Name = "label12";
            label12.Size = new Size(27, 17);
            label12.TabIndex = 37;
            label12.Text = "MT";
            // 
            // PrestacaoMensalTextBox
            // 
            PrestacaoMensalTextBox.Enabled = false;
            PrestacaoMensalTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PrestacaoMensalTextBox.Location = new Point(139, 290);
            PrestacaoMensalTextBox.Name = "PrestacaoMensalTextBox";
            PrestacaoMensalTextBox.Size = new Size(154, 27);
            PrestacaoMensalTextBox.TabIndex = 36;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(8, 298);
            label13.Name = "label13";
            label13.Size = new Size(114, 17);
            label13.TabIndex = 35;
            label13.Text = "Prestação Mensal:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(725, 298);
            label10.Name = "label10";
            label10.Size = new Size(27, 17);
            label10.TabIndex = 34;
            label10.Text = "MT";
            // 
            // ValorGarantiaTextBox
            // 
            ValorGarantiaTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ValorGarantiaTextBox.Location = new Point(528, 285);
            ValorGarantiaTextBox.Name = "ValorGarantiaTextBox";
            ValorGarantiaTextBox.Size = new Size(154, 27);
            ValorGarantiaTextBox.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(376, 290);
            label11.Name = "label11";
            label11.Size = new Size(113, 17);
            label11.TabIndex = 32;
            label11.Text = "Valor da Garantia:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(296, 250);
            label9.Name = "label9";
            label9.Size = new Size(27, 17);
            label9.TabIndex = 31;
            label9.Text = "MT";
            // 
            // DescricaoGarantiaTextBox
            // 
            DescricaoGarantiaTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DescricaoGarantiaTextBox.Location = new Point(528, 187);
            DescricaoGarantiaTextBox.Multiline = true;
            DescricaoGarantiaTextBox.Name = "DescricaoGarantiaTextBox";
            DescricaoGarantiaTextBox.Size = new Size(224, 86);
            DescricaoGarantiaTextBox.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(373, 194);
            label5.Name = "label5";
            label5.Size = new Size(140, 17);
            label5.TabIndex = 29;
            label5.Text = "Descrição da Garantia:";
            // 
            // TotalPagarTextBox
            // 
            TotalPagarTextBox.Enabled = false;
            TotalPagarTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TotalPagarTextBox.Location = new Point(140, 237);
            TotalPagarTextBox.Name = "TotalPagarTextBox";
            TotalPagarTextBox.Size = new Size(154, 27);
            TotalPagarTextBox.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 245);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 27;
            label4.Text = "Total a Pagar:";
            // 
            // DataAprovacaoDateTimePicker2
            // 
            DataAprovacaoDateTimePicker2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DataAprovacaoDateTimePicker2.Location = new Point(528, 96);
            DataAprovacaoDateTimePicker2.Name = "DataAprovacaoDateTimePicker2";
            DataAprovacaoDateTimePicker2.Size = new Size(224, 27);
            DataAprovacaoDateTimePicker2.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(222, 148);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 25;
            label3.Text = "Meses";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(222, 194);
            label8.Name = "label8";
            label8.Size = new Size(19, 17);
            label8.TabIndex = 24;
            label8.Text = "%";
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Activo", "Liquidado" });
            cmbStatus.Location = new Point(528, 146);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(224, 28);
            cmbStatus.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(296, 103);
            label7.Name = "label7";
            label7.Size = new Size(27, 17);
            label7.TabIndex = 22;
            label7.Text = "MT";
            // 
            // ValorEmprestimoTextBox
            // 
            ValorEmprestimoTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ValorEmprestimoTextBox.Location = new Point(139, 88);
            ValorEmprestimoTextBox.Name = "ValorEmprestimoTextBox";
            ValorEmprestimoTextBox.Size = new Size(155, 27);
            ValorEmprestimoTextBox.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 94);
            label6.Name = "label6";
            label6.Size = new Size(41, 17);
            label6.TabIndex = 20;
            label6.Text = "Valor:";
            // 
            // EmprestimoDataGridView
            // 
            EmprestimoDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EmprestimoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EmprestimoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            EmprestimoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            EmprestimoDataGridView.Location = new Point(10, 390);
            EmprestimoDataGridView.Name = "EmprestimoDataGridView";
            EmprestimoDataGridView.RowTemplate.Height = 25;
            EmprestimoDataGridView.Size = new Size(757, 129);
            EmprestimoDataGridView.TabIndex = 14;
            EmprestimoDataGridView.CellContentClick += EmprestimoDataGridView_CellContentClick;
            EmprestimoDataGridView.RowHeaderMouseClick += EmprestimoDataGridView_RowHeaderMouseClick;
            // 
            // TaxaJuroTextBox
            // 
            TaxaJuroTextBox.Enabled = false;
            TaxaJuroTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TaxaJuroTextBox.Location = new Point(140, 188);
            TaxaJuroTextBox.Name = "TaxaJuroTextBox";
            TaxaJuroTextBox.Size = new Size(61, 27);
            TaxaJuroTextBox.TabIndex = 13;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(10, 194);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(91, 17);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Taxa de Juros:";
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdCliente.Location = new Point(10, 60);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(110, 17);
            lblIdCliente.TabIndex = 6;
            lblIdCliente.Text = "Nome do Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(373, 151);
            label1.Name = "label1";
            label1.Size = new Size(46, 17);
            label1.TabIndex = 4;
            label1.Text = "Status:";
            // 
            // lblApelido
            // 
            lblApelido.AutoSize = true;
            lblApelido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblApelido.Location = new Point(376, 101);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(105, 17);
            lblApelido.TabIndex = 2;
            lblApelido.Text = "Data Aprovação:";
            // 
            // PrazoTextBox
            // 
            PrazoTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PrazoTextBox.Location = new Point(139, 138);
            PrazoTextBox.Name = "PrazoTextBox";
            PrazoTextBox.Size = new Size(62, 27);
            PrazoTextBox.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(10, 144);
            lblName.Name = "lblName";
            lblName.Size = new Size(44, 17);
            lblName.TabIndex = 0;
            lblName.Text = "Prazo:";
            // 
            // lblRegistLoan
            // 
            lblRegistLoan.BackColor = Color.White;
            lblRegistLoan.Controls.Add(SimularEmprestimoButton);
            lblRegistLoan.Controls.Add(btnClean);
            lblRegistLoan.Controls.Add(btnRemove);
            lblRegistLoan.Controls.Add(btnUpdate);
            lblRegistLoan.Controls.Add(btnSave);
            lblRegistLoan.Location = new Point(818, 13);
            lblRegistLoan.Name = "lblRegistLoan";
            lblRegistLoan.Size = new Size(299, 524);
            lblRegistLoan.TabIndex = 4;
            lblRegistLoan.TabStop = false;
            lblRegistLoan.Text = "Operações";
            // 
            // SimularEmprestimoButton
            // 
            SimularEmprestimoButton.BackColor = Color.LimeGreen;
            SimularEmprestimoButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            SimularEmprestimoButton.ForeColor = Color.White;
            SimularEmprestimoButton.Location = new Point(72, 86);
            SimularEmprestimoButton.Name = "SimularEmprestimoButton";
            SimularEmprestimoButton.Size = new Size(167, 51);
            SimularEmprestimoButton.TabIndex = 15;
            SimularEmprestimoButton.Text = "Simular";
            SimularEmprestimoButton.UseVisualStyleBackColor = false;
            SimularEmprestimoButton.Click += SimularEmprestimoButton_Click_1;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.Navy;
            btnClean.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(72, 259);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(167, 54);
            btnClean.TabIndex = 14;
            btnClean.Text = "Limpar";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(72, 199);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(167, 54);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkCyan;
            btnSave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(72, 141);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(167, 51);
            btnSave.TabIndex = 1;
            btnSave.Text = "Gravar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // LoanRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1135, 550);
            Controls.Add(lblRegistLoan);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoanRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registo do Empréstimo";
            Load += LoanRegistrationForm_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmprestimoDataGridView).EndInit();
            lblRegistLoan.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private TextBox ValorEmprestimoTextBox;
        private Label label6;
        private DataGridView EmprestimoDataGridView;
        private Label lblEmail;
        private Label lblIdCliente;
        private Label label1;
        private Label lblApelido;
        private TextBox PrazoTextBox;
        private Label lblName;
        private Label label8;
        private ComboBox cmbStatus;
        private DateTimePicker dateTimePicker1;
        private GroupBox lblRegistLoan;
        private Button btnClean;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnRemove;
        private Label label3;
        private DateTimePicker DataAprovacaoDateTimePicker2;
        private Label label9;
        private TextBox DescricaoGarantiaTextBox;
        private Label label5;
        private TextBox TotalPagarTextBox;
        private Label label4;
        private Label label12;
        private TextBox PrestacaoMensalTextBox;
        private Label label13;
        private Label label10;
        private TextBox ValorGarantiaTextBox;
        private Label label11;
        private TextBox TaxaJuroTextBox;
        private ComboBox ClientesComboBox1;
        private Label label14;
        private TextBox TotalJurosTextBox;
        private Label label15;
        private Button SimularEmprestimoButton;
    }
}