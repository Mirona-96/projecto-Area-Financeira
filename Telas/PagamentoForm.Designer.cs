namespace Financeiro_V3
{
    partial class PagamentoForm
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
            groupBox1 = new GroupBox();
            dgvDadosPagamento = new DataGridView();
            label8 = new Label();
            label5 = new Label();
            idEmprestimoComboBox = new ComboBox();
            label1 = new Label();
            ClientesComboBox = new ComboBox();
            label2 = new Label();
            tbxNumPrestacao = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblIdEmprestimo = new Label();
            lblValorPrestacao = new Label();
            tbxValorPrestacao = new TextBox();
            tbxValorJuros = new TextBox();
            tbxValorTotal = new TextBox();
            label6 = new Label();
            lblNomeCliente = new Label();
            lblName = new Label();
            lblRegistLoan = new GroupBox();
            btnClean = new Button();
            btnCancel = new Button();
            btnValidarPgto = new Button();
            panel1 = new Panel();
            lblRegistrationData = new Label();
            DataRegisto = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDadosPagamento).BeginInit();
            lblRegistLoan.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dgvDadosPagamento);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(idEmprestimoComboBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ClientesComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbxNumPrestacao);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(lblIdEmprestimo);
            groupBox1.Controls.Add(lblValorPrestacao);
            groupBox1.Controls.Add(tbxValorPrestacao);
            groupBox1.Controls.Add(tbxValorJuros);
            groupBox1.Controls.Add(tbxValorTotal);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblNomeCliente);
            groupBox1.Controls.Add(lblName);
            groupBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(15, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 532);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados de Pagamento";
            // 
            // dgvDadosPagamento
            // 
            dgvDadosPagamento.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDadosPagamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDadosPagamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosPagamento.Location = new Point(13, 348);
            dgvDadosPagamento.Name = "dgvDadosPagamento";
            dgvDadosPagamento.RowTemplate.Height = 25;
            dgvDadosPagamento.Size = new Size(756, 151);
            dgvDadosPagamento.TabIndex = 59;
            dgvDadosPagamento.RowHeaderMouseClick += dgvDadosPagamento_RowHeaderMouseClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(340, 247);
            label8.Name = "label8";
            label8.Size = new Size(27, 17);
            label8.TabIndex = 58;
            label8.Text = "MT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(487, 296);
            label5.Name = "label5";
            label5.Size = new Size(27, 17);
            label5.TabIndex = 57;
            label5.Text = "MT";
            // 
            // idEmprestimoComboBox
            // 
            idEmprestimoComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            idEmprestimoComboBox.FormattingEnabled = true;
            idEmprestimoComboBox.Location = new Point(147, 99);
            idEmprestimoComboBox.Name = "idEmprestimoComboBox";
            idEmprestimoComboBox.Size = new Size(367, 28);
            idEmprestimoComboBox.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 247);
            label1.Name = "label1";
            label1.Size = new Size(102, 17);
            label1.TabIndex = 43;
            label1.Text = "Valor dos Juros:";
            // 
            // ClientesComboBox
            // 
            ClientesComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ClientesComboBox.FormattingEnabled = true;
            ClientesComboBox.Location = new Point(147, 50);
            ClientesComboBox.Name = "ClientesComboBox";
            ClientesComboBox.Size = new Size(367, 28);
            ClientesComboBox.TabIndex = 53;
            ClientesComboBox.SelectedIndexChanged += ClientesComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 206);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 52;
            label2.Text = "Prestação No.:";
            // 
            // tbxNumPrestacao
            // 
            tbxNumPrestacao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxNumPrestacao.Location = new Point(147, 201);
            tbxNumPrestacao.Name = "tbxNumPrestacao";
            tbxNumPrestacao.Size = new Size(39, 27);
            tbxNumPrestacao.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(487, 206);
            label4.Name = "label4";
            label4.Size = new Size(27, 17);
            label4.TabIndex = 50;
            label4.Text = "MT";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(147, 157);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 27);
            dateTimePicker1.TabIndex = 49;
            // 
            // lblIdEmprestimo
            // 
            lblIdEmprestimo.AutoSize = true;
            lblIdEmprestimo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdEmprestimo.Location = new Point(13, 112);
            lblIdEmprestimo.Name = "lblIdEmprestimo";
            lblIdEmprestimo.Size = new Size(116, 17);
            lblIdEmprestimo.TabIndex = 47;
            lblIdEmprestimo.Text = "Id do Empréstimo:";
            // 
            // lblValorPrestacao
            // 
            lblValorPrestacao.AutoSize = true;
            lblValorPrestacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorPrestacao.Location = new Point(213, 206);
            lblValorPrestacao.Name = "lblValorPrestacao";
            lblValorPrestacao.Size = new Size(121, 17);
            lblValorPrestacao.TabIndex = 45;
            lblValorPrestacao.Text = "Valor da Prestacao:";
            // 
            // tbxValorPrestacao
            // 
            tbxValorPrestacao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxValorPrestacao.Location = new Point(340, 201);
            tbxValorPrestacao.Name = "tbxValorPrestacao";
            tbxValorPrestacao.Size = new Size(141, 27);
            tbxValorPrestacao.TabIndex = 41;
            // 
            // tbxValorJuros
            // 
            tbxValorJuros.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxValorJuros.Location = new Point(147, 242);
            tbxValorJuros.Name = "tbxValorJuros";
            tbxValorJuros.Size = new Size(187, 27);
            tbxValorJuros.TabIndex = 40;
            // 
            // tbxValorTotal
            // 
            tbxValorTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxValorTotal.Location = new Point(147, 283);
            tbxValorTotal.Name = "tbxValorTotal";
            tbxValorTotal.Size = new Size(334, 27);
            tbxValorTotal.TabIndex = 38;
            tbxValorTotal.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 296);
            label6.Name = "label6";
            label6.Size = new Size(121, 17);
            label6.TabIndex = 20;
            label6.Text = "Valor total a pagar:";
            label6.Click += label6_Click;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeCliente.Location = new Point(13, 60);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(110, 17);
            lblNomeCliente.TabIndex = 6;
            lblNomeCliente.Text = "Nome do Cliente:";
            lblNomeCliente.Click += lblIdCliente_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(13, 164);
            lblName.Name = "lblName";
            lblName.Size = new Size(128, 17);
            lblName.TabIndex = 0;
            lblName.Text = "Data de pagamento:";
            // 
            // lblRegistLoan
            // 
            lblRegistLoan.BackColor = Color.White;
            lblRegistLoan.Controls.Add(btnClean);
            lblRegistLoan.Controls.Add(btnCancel);
            lblRegistLoan.Controls.Add(btnValidarPgto);
            lblRegistLoan.Location = new Point(800, 61);
            lblRegistLoan.Name = "lblRegistLoan";
            lblRegistLoan.Size = new Size(306, 470);
            lblRegistLoan.TabIndex = 5;
            lblRegistLoan.TabStop = false;
            lblRegistLoan.Text = "Operações";
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.Navy;
            btnClean.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(72, 165);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(167, 49);
            btnClean.TabIndex = 15;
            btnClean.Text = "Limpar";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Maroon;
            btnCancel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(72, 230);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(167, 49);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnRemove_Click;
            // 
            // btnValidarPgto
            // 
            btnValidarPgto.BackColor = Color.DarkCyan;
            btnValidarPgto.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnValidarPgto.ForeColor = Color.White;
            btnValidarPgto.Location = new Point(72, 98);
            btnValidarPgto.Name = "btnValidarPgto";
            btnValidarPgto.Size = new Size(167, 51);
            btnValidarPgto.TabIndex = 1;
            btnValidarPgto.Text = "Validar pagamento";
            btnValidarPgto.UseVisualStyleBackColor = false;
            btnValidarPgto.Click += btnValidarPgto_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblRegistrationData);
            panel1.Controls.Add(DataRegisto);
            panel1.Location = new Point(800, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 46);
            panel1.TabIndex = 6;
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
            // DataRegisto
            // 
            DataRegisto.Location = new Point(3, 21);
            DataRegisto.Name = "DataRegisto";
            DataRegisto.Size = new Size(299, 23);
            DataRegisto.TabIndex = 2;
            // 
            // PagamentoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1121, 539);
            Controls.Add(panel1);
            Controls.Add(lblRegistLoan);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PagamentoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagamento";
            Load += PagamentoForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDadosPagamento).EndInit();
            lblRegistLoan.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label lblNomeCliente;
        private Label lblName;
        private GroupBox lblRegistLoan;
        private Button btnClean;
        private Label lblIdEmprestimo;
        private Button btnCancel;
        private Button btnValidarPgto;
        private TextBox tbxValorTotal;
        private Label lblValorPrestacao;
        private Label label3;
        private Label label1;
        private TextBox tbxValorPrestacao;
        private TextBox tbxValorJuros;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox tbxNumPrestacao;
        private Label label4;
        private Panel panel1;
        private Label lblRegistrationData;
        private DateTimePicker DataRegisto;
        private TextBox tbxMulta;
        private ComboBox idEmprestimoComboBox;
        private ComboBox ClientesComboBox;
        private Label label8;
        private Label label5;
        private DataGridView dgvDadosPagamento;
    }
}