namespace SuperMercado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            gpbDadosCliente = new GroupBox();
            msbCpf = new MaskedTextBox();
            checkBox1 = new CheckBox();
            btnAbreCupom = new Button();
            gpbProdutoAtual = new GroupBox();
            btnAddProduto = new Button();
            txtPrecoUnitario = new TextBox();
            txtDesc = new TextBox();
            txtQuant = new TextBox();
            txtCodBarras = new TextBox();
            lblPreco = new Label();
            lblDesc = new Label();
            lblQuant = new Label();
            lblCodBarra = new Label();
            gpbCupom = new GroupBox();
            rtbCupom = new RichTextBox();
            groupBox1 = new GroupBox();
            btnVerificar = new Button();
            lblCodApaga = new Label();
            txtCodigoApagar = new TextBox();
            lblSenha = new Label();
            txtRemoverProduto = new TextBox();
            btnRemove = new Button();
            gpbTotal = new GroupBox();
            lblTotalCompra = new Label();
            btnIrPagamento = new Button();
            gpbFormaPagamento = new GroupBox();
            btnCalcular = new Button();
            txtTroco = new TextBox();
            lblTroco = new Label();
            lblValorRecebido = new Label();
            txtValorRecebido = new TextBox();
            btnFinalizar = new Button();
            rdbDinheiro = new RadioButton();
            rdbCredito = new RadioButton();
            rdbDebito = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            gpbDadosCliente.SuspendLayout();
            gpbProdutoAtual.SuspendLayout();
            gpbCupom.SuspendLayout();
            groupBox1.SuspendLayout();
            gpbTotal.SuspendLayout();
            gpbFormaPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(265, 9);
            label1.Name = "label1";
            label1.Size = new Size(343, 40);
            label1.TabIndex = 0;
            label1.Text = "Supermercado Tabajara";
            // 
            // gpbDadosCliente
            // 
            gpbDadosCliente.Controls.Add(msbCpf);
            gpbDadosCliente.Controls.Add(checkBox1);
            gpbDadosCliente.Controls.Add(btnAbreCupom);
            gpbDadosCliente.Location = new Point(12, 53);
            gpbDadosCliente.Name = "gpbDadosCliente";
            gpbDadosCliente.Size = new Size(200, 214);
            gpbDadosCliente.TabIndex = 1;
            gpbDadosCliente.TabStop = false;
            gpbDadosCliente.Text = "Dados do cliente";
            // 
            // msbCpf
            // 
            msbCpf.Location = new Point(24, 59);
            msbCpf.Mask = "999.999.999-99";
            msbCpf.Name = "msbCpf";
            msbCpf.Size = new Size(148, 23);
            msbCpf.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 34);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Nota fiscal paulista";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnAbreCupom
            // 
            btnAbreCupom.Location = new Point(52, 146);
            btnAbreCupom.Name = "btnAbreCupom";
            btnAbreCupom.Size = new Size(86, 29);
            btnAbreCupom.TabIndex = 0;
            btnAbreCupom.Text = "Abre Cupom";
            btnAbreCupom.UseVisualStyleBackColor = true;
            btnAbreCupom.Click += btnAbreCupom_Click;
            // 
            // gpbProdutoAtual
            // 
            gpbProdutoAtual.Controls.Add(btnAddProduto);
            gpbProdutoAtual.Controls.Add(txtPrecoUnitario);
            gpbProdutoAtual.Controls.Add(txtDesc);
            gpbProdutoAtual.Controls.Add(txtQuant);
            gpbProdutoAtual.Controls.Add(txtCodBarras);
            gpbProdutoAtual.Controls.Add(lblPreco);
            gpbProdutoAtual.Controls.Add(lblDesc);
            gpbProdutoAtual.Controls.Add(lblQuant);
            gpbProdutoAtual.Controls.Add(lblCodBarra);
            gpbProdutoAtual.Enabled = false;
            gpbProdutoAtual.Location = new Point(218, 100);
            gpbProdutoAtual.Name = "gpbProdutoAtual";
            gpbProdutoAtual.Size = new Size(471, 167);
            gpbProdutoAtual.TabIndex = 2;
            gpbProdutoAtual.TabStop = false;
            gpbProdutoAtual.Text = "Produto Atual";
            // 
            // btnAddProduto
            // 
            btnAddProduto.Location = new Point(368, 34);
            btnAddProduto.Name = "btnAddProduto";
            btnAddProduto.Size = new Size(75, 42);
            btnAddProduto.TabIndex = 8;
            btnAddProduto.Text = "Adicionar Produto";
            btnAddProduto.UseVisualStyleBackColor = true;
            btnAddProduto.Click += btnAddProduto_Click;
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.Location = new Point(119, 125);
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.Size = new Size(66, 23);
            txtPrecoUnitario.TabIndex = 7;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(96, 96);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(265, 23);
            txtDesc.TabIndex = 6;
            // 
            // txtQuant
            // 
            txtQuant.Location = new Point(107, 61);
            txtQuant.Name = "txtQuant";
            txtQuant.Size = new Size(70, 23);
            txtQuant.TabIndex = 5;
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(135, 24);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(146, 23);
            txtCodBarras.TabIndex = 4;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(32, 128);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(81, 15);
            lblPreco.TabIndex = 3;
            lblPreco.Text = "Preço unitário";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(32, 99);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(58, 15);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Descrição";
            // 
            // lblQuant
            // 
            lblQuant.AutoSize = true;
            lblQuant.Location = new Point(32, 64);
            lblQuant.Name = "lblQuant";
            lblQuant.Size = new Size(69, 15);
            lblQuant.TabIndex = 1;
            lblQuant.Text = "Quantidade";
            // 
            // lblCodBarra
            // 
            lblCodBarra.AutoSize = true;
            lblCodBarra.Location = new Point(32, 27);
            lblCodBarra.Name = "lblCodBarra";
            lblCodBarra.Size = new Size(97, 15);
            lblCodBarra.TabIndex = 0;
            lblCodBarra.Text = "Código de barras";
            // 
            // gpbCupom
            // 
            gpbCupom.Controls.Add(rtbCupom);
            gpbCupom.Controls.Add(groupBox1);
            gpbCupom.Enabled = false;
            gpbCupom.Location = new Point(201, 273);
            gpbCupom.Name = "gpbCupom";
            gpbCupom.Size = new Size(488, 211);
            gpbCupom.TabIndex = 3;
            gpbCupom.TabStop = false;
            gpbCupom.Text = "Cupom Fiscal";
            // 
            // rtbCupom
            // 
            rtbCupom.Location = new Point(17, 22);
            rtbCupom.Name = "rtbCupom";
            rtbCupom.Size = new Size(295, 183);
            rtbCupom.TabIndex = 2;
            rtbCupom.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVerificar);
            groupBox1.Controls.Add(lblCodApaga);
            groupBox1.Controls.Add(txtCodigoApagar);
            groupBox1.Controls.Add(lblSenha);
            groupBox1.Controls.Add(txtRemoverProduto);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Location = new Point(318, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(164, 188);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Remover produto";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(47, 69);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(76, 30);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "Verficar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblCodApaga
            // 
            lblCodApaga.AutoSize = true;
            lblCodApaga.Location = new Point(6, 113);
            lblCodApaga.Name = "lblCodApaga";
            lblCodApaga.Size = new Size(101, 15);
            lblCodApaga.TabIndex = 3;
            lblCodApaga.Text = "Código De Barras:";
            lblCodApaga.Visible = false;
            // 
            // txtCodigoApagar
            // 
            txtCodigoApagar.Location = new Point(33, 130);
            txtCodigoApagar.Name = "txtCodigoApagar";
            txtCodigoApagar.Size = new Size(100, 23);
            txtCodigoApagar.TabIndex = 0;
            txtCodigoApagar.Visible = false;
            txtCodigoApagar.TextChanged += txtCodigoApagar_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(6, 25);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // txtRemoverProduto
            // 
            txtRemoverProduto.Location = new Point(33, 40);
            txtRemoverProduto.Name = "txtRemoverProduto";
            txtRemoverProduto.Size = new Size(100, 23);
            txtRemoverProduto.TabIndex = 1;
            txtRemoverProduto.UseSystemPasswordChar = true;
            txtRemoverProduto.TextChanged += txtRemoverProduto_TextChanged;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(47, 159);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(74, 29);
            btnRemove.TabIndex = 0;
            btnRemove.Text = "Remover";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Visible = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // gpbTotal
            // 
            gpbTotal.Controls.Add(lblTotalCompra);
            gpbTotal.Controls.Add(btnIrPagamento);
            gpbTotal.Location = new Point(695, 134);
            gpbTotal.Name = "gpbTotal";
            gpbTotal.Size = new Size(267, 167);
            gpbTotal.TabIndex = 4;
            gpbTotal.TabStop = false;
            gpbTotal.Text = "Total da compra";
            // 
            // lblTotalCompra
            // 
            lblTotalCompra.AutoSize = true;
            lblTotalCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCompra.Location = new Point(98, 59);
            lblTotalCompra.Name = "lblTotalCompra";
            lblTotalCompra.Size = new Size(57, 21);
            lblTotalCompra.TabIndex = 1;
            lblTotalCompra.Text = "label2";
            lblTotalCompra.Visible = false;
            // 
            // btnIrPagamento
            // 
            btnIrPagamento.Location = new Point(85, 109);
            btnIrPagamento.Name = "btnIrPagamento";
            btnIrPagamento.Size = new Size(86, 43);
            btnIrPagamento.TabIndex = 0;
            btnIrPagamento.Text = "Ir para pagamento";
            btnIrPagamento.UseVisualStyleBackColor = true;
            btnIrPagamento.Click += btnIrPagamento_Click;
            // 
            // gpbFormaPagamento
            // 
            gpbFormaPagamento.Controls.Add(btnCalcular);
            gpbFormaPagamento.Controls.Add(txtTroco);
            gpbFormaPagamento.Controls.Add(lblTroco);
            gpbFormaPagamento.Controls.Add(lblValorRecebido);
            gpbFormaPagamento.Controls.Add(txtValorRecebido);
            gpbFormaPagamento.Controls.Add(btnFinalizar);
            gpbFormaPagamento.Controls.Add(rdbDinheiro);
            gpbFormaPagamento.Controls.Add(rdbCredito);
            gpbFormaPagamento.Controls.Add(rdbDebito);
            gpbFormaPagamento.Enabled = false;
            gpbFormaPagamento.Location = new Point(696, 307);
            gpbFormaPagamento.Name = "gpbFormaPagamento";
            gpbFormaPagamento.Size = new Size(267, 177);
            gpbFormaPagamento.TabIndex = 5;
            gpbFormaPagamento.TabStop = false;
            gpbFormaPagamento.Text = "Forma de pagamento";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(97, 139);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(57, 23);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtTroco
            // 
            txtTroco.Enabled = false;
            txtTroco.Location = new Point(172, 139);
            txtTroco.Name = "txtTroco";
            txtTroco.Size = new Size(64, 23);
            txtTroco.TabIndex = 7;
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.Location = new Point(172, 121);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(36, 15);
            lblTroco.TabIndex = 6;
            lblTroco.Text = "Troco";
            // 
            // lblValorRecebido
            // 
            lblValorRecebido.AutoSize = true;
            lblValorRecebido.Location = new Point(10, 121);
            lblValorRecebido.Name = "lblValorRecebido";
            lblValorRecebido.Size = new Size(82, 15);
            lblValorRecebido.TabIndex = 5;
            lblValorRecebido.Text = "Valor recebido";
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.Enabled = false;
            txtValorRecebido.Location = new Point(10, 139);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.Size = new Size(64, 23);
            txtValorRecebido.TabIndex = 4;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(139, 47);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(101, 51);
            btnFinalizar.TabIndex = 3;
            btnFinalizar.Text = "Finalizar Compra";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // rdbDinheiro
            // 
            rdbDinheiro.AutoSize = true;
            rdbDinheiro.Location = new Point(22, 88);
            rdbDinheiro.Name = "rdbDinheiro";
            rdbDinheiro.Size = new Size(70, 19);
            rdbDinheiro.TabIndex = 2;
            rdbDinheiro.TabStop = true;
            rdbDinheiro.Text = "Dinheiro";
            rdbDinheiro.UseVisualStyleBackColor = true;
            rdbDinheiro.CheckedChanged += rdbDinheiro_CheckedChanged;
            // 
            // rdbCredito
            // 
            rdbCredito.AutoSize = true;
            rdbCredito.Location = new Point(22, 63);
            rdbCredito.Name = "rdbCredito";
            rdbCredito.Size = new Size(64, 19);
            rdbCredito.TabIndex = 1;
            rdbCredito.TabStop = true;
            rdbCredito.Text = "Crédito";
            rdbCredito.UseVisualStyleBackColor = true;
            // 
            // rdbDebito
            // 
            rdbDebito.AutoSize = true;
            rdbDebito.Location = new Point(22, 38);
            rdbDebito.Name = "rdbDebito";
            rdbDebito.Size = new Size(60, 19);
            rdbDebito.TabIndex = 0;
            rdbDebito.TabStop = true;
            rdbDebito.Text = "Débito";
            rdbDebito.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(714, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 315);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(181, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 496);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(gpbFormaPagamento);
            Controls.Add(gpbTotal);
            Controls.Add(gpbCupom);
            Controls.Add(gpbProdutoAtual);
            Controls.Add(gpbDadosCliente);
            Controls.Add(label1);
            Name = "Form1";
            Text = "SUPERMERCADO TABAJARA";
            gpbDadosCliente.ResumeLayout(false);
            gpbDadosCliente.PerformLayout();
            gpbProdutoAtual.ResumeLayout(false);
            gpbProdutoAtual.PerformLayout();
            gpbCupom.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gpbTotal.ResumeLayout(false);
            gpbTotal.PerformLayout();
            gpbFormaPagamento.ResumeLayout(false);
            gpbFormaPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gpbDadosCliente;
        private Button btnAbreCupom;
        private GroupBox gpbProdutoAtual;
        private Button btnAddProduto;
        private TextBox txtPrecoUnitario;
        private TextBox txtDesc;
        private TextBox txtQuant;
        private TextBox txtCodBarras;
        private Label lblPreco;
        private Label lblDesc;
        private Label lblQuant;
        private Label lblCodBarra;
        private GroupBox gpbCupom;
        private Button btnRemove;
        private GroupBox gpbTotal;
        private Label lblTotalCompra;
        private Button btnIrPagamento;
        private GroupBox gpbFormaPagamento;
        private TextBox txtTroco;
        private Label lblTroco;
        private Label lblValorRecebido;
        private TextBox txtValorRecebido;
        private Button btnFinalizar;
        private RadioButton rdbDinheiro;
        private RadioButton rdbCredito;
        private RadioButton rdbDebito;
        private GroupBox groupBox1;
        private TextBox txtRemoverProduto;
        private MaskedTextBox msbCpf;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private RichTextBox rtbCupom;
        private PictureBox pictureBox2;
        private TextBox txtCodigoApagar;
        private Button btnVerificar;
        private Label lblCodApaga;
        private Label lblSenha;
        private Button btnCalcular;
    }
}