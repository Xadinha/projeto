namespace Projeto_loja_de_roupa_com_Rafael_Cordeiro
{
    partial class Men
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Men));
            TSbtn = new Button();
            CCbtn = new Button();
            bttn_sair = new Button();
            bttn_anterior = new Button();
            LabelUtilizador = new Label();
            bttn_carrinho = new Button();
            numero_itens = new Label();
            SuspendLayout();
            // 
            // TSbtn
            // 
            TSbtn.BackgroundImage = (Image)resources.GetObject("TSbtn.BackgroundImage");
            TSbtn.BackgroundImageLayout = ImageLayout.Zoom;
            TSbtn.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            TSbtn.ForeColor = Color.DarkOrchid;
            TSbtn.Location = new Point(117, 182);
            TSbtn.Name = "TSbtn";
            TSbtn.Size = new Size(310, 339);
            TSbtn.TabIndex = 0;
            TSbtn.Text = "Tshirts\r\nSweats\r\n";
            TSbtn.UseVisualStyleBackColor = true;
            TSbtn.Click += TSbtn_Click;
            // 
            // CCbtn
            // 
            CCbtn.BackgroundImage = (Image)resources.GetObject("CCbtn.BackgroundImage");
            CCbtn.BackgroundImageLayout = ImageLayout.Stretch;
            CCbtn.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            CCbtn.ForeColor = Color.DarkOrchid;
            CCbtn.Location = new Point(484, 183);
            CCbtn.Name = "CCbtn";
            CCbtn.Size = new Size(316, 334);
            CCbtn.TabIndex = 1;
            CCbtn.Text = "Calças\r\nCalções\r\n";
            CCbtn.UseVisualStyleBackColor = true;
            CCbtn.Click += CCbtn_Click;
            // 
            // bttn_sair
            // 
            bttn_sair.BackColor = Color.Transparent;
            bttn_sair.Location = new Point(688, 66);
            bttn_sair.Name = "bttn_sair";
            bttn_sair.Size = new Size(112, 34);
            bttn_sair.TabIndex = 2;
            bttn_sair.Text = "Sair";
            bttn_sair.UseVisualStyleBackColor = false;
            bttn_sair.Click += bttn_sair_Click;
            // 
            // bttn_anterior
            // 
            bttn_anterior.Location = new Point(558, 66);
            bttn_anterior.Name = "bttn_anterior";
            bttn_anterior.Size = new Size(112, 34);
            bttn_anterior.TabIndex = 3;
            bttn_anterior.Text = "Anterior";
            bttn_anterior.UseVisualStyleBackColor = true;
            bttn_anterior.Click += bttn_anterior_Click;
            // 
            // LabelUtilizador
            // 
            LabelUtilizador.AutoSize = true;
            LabelUtilizador.BackColor = Color.Transparent;
            LabelUtilizador.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LabelUtilizador.ForeColor = Color.FromArgb(192, 0, 192);
            LabelUtilizador.Location = new Point(409, 100);
            LabelUtilizador.Name = "LabelUtilizador";
            LabelUtilizador.Size = new Size(88, 28);
            LabelUtilizador.TabIndex = 7;
            LabelUtilizador.Text = "label3";
            // 
            // bttn_carrinho
            // 
            bttn_carrinho.BackColor = Color.Black;
            bttn_carrinho.BackgroundImage = (Image)resources.GetObject("bttn_carrinho.BackgroundImage");
            bttn_carrinho.BackgroundImageLayout = ImageLayout.Stretch;
            bttn_carrinho.FlatAppearance.BorderColor = Color.Black;
            bttn_carrinho.FlatStyle = FlatStyle.Popup;
            bttn_carrinho.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bttn_carrinho.ForeColor = Color.FromArgb(192, 0, 192);
            bttn_carrinho.Location = new Point(160, 100);
            bttn_carrinho.Name = "bttn_carrinho";
            bttn_carrinho.Size = new Size(81, 74);
            bttn_carrinho.TabIndex = 8;
            bttn_carrinho.UseVisualStyleBackColor = false;
            bttn_carrinho.Click += bttn_carrinho_Click;
            // 
            // numero_itens
            // 
            numero_itens.AutoSize = true;
            numero_itens.BackColor = Color.Transparent;
            numero_itens.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numero_itens.ForeColor = Color.FromArgb(192, 0, 192);
            numero_itens.Location = new Point(247, 146);
            numero_itens.Name = "numero_itens";
            numero_itens.Size = new Size(23, 28);
            numero_itens.TabIndex = 16;
            numero_itens.Text = "?";
            // 
            // Men
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(884, 572);
            Controls.Add(numero_itens);
            Controls.Add(bttn_carrinho);
            Controls.Add(LabelUtilizador);
            Controls.Add(bttn_anterior);
            Controls.Add(bttn_sair);
            Controls.Add(CCbtn);
            Controls.Add(TSbtn);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Men";
            Text = "Men";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TSbtn;
        private Button CCbtn;
        private Button bttn_sair;
        private Button bttn_anterior;
        private Label LabelUtilizador;
        private Button bttn_carrinho;
        private Label numero_itens;
    }
}