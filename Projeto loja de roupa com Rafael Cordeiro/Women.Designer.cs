namespace Projeto_loja_de_roupa_com_Rafael_Cordeiro
{
    partial class Women
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Women));
            CSCbtn = new Button();
            TTTbtn = new Button();
            bttn_anterior = new Button();
            bttn_sair = new Button();
            LabelUtilizador = new Label();
            bttn_carrinho = new Button();
            numero_itens = new Label();
            SuspendLayout();
            // 
            // CSCbtn
            // 
            CSCbtn.BackgroundImage = (Image)resources.GetObject("CSCbtn.BackgroundImage");
            CSCbtn.BackgroundImageLayout = ImageLayout.Zoom;
            CSCbtn.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            CSCbtn.ForeColor = Color.FromArgb(192, 0, 192);
            CSCbtn.Location = new Point(760, 258);
            CSCbtn.Margin = new Padding(4, 5, 4, 5);
            CSCbtn.Name = "CSCbtn";
            CSCbtn.Size = new Size(424, 580);
            CSCbtn.TabIndex = 0;
            CSCbtn.Text = "Calças\r\nSaias\r\nCalções\r\n";
            CSCbtn.UseVisualStyleBackColor = true;
            CSCbtn.Click += CSCbtn_Click;
            // 
            // TTTbtn
            // 
            TTTbtn.BackgroundImage = (Image)resources.GetObject("TTTbtn.BackgroundImage");
            TTTbtn.BackgroundImageLayout = ImageLayout.Zoom;
            TTTbtn.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            TTTbtn.ForeColor = Color.FromArgb(192, 0, 192);
            TTTbtn.Location = new Point(143, 258);
            TTTbtn.Margin = new Padding(4, 5, 4, 5);
            TTTbtn.Name = "TTTbtn";
            TTTbtn.Size = new Size(434, 580);
            TTTbtn.TabIndex = 1;
            TTTbtn.Text = "Tops\r\nTshirts\r\nsweats\r\n\r\n";
            TTTbtn.UseVisualStyleBackColor = true;
            TTTbtn.Click += TTTbtn_Click;
            // 
            // bttn_anterior
            // 
            bttn_anterior.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bttn_anterior.Location = new Point(942, 186);
            bttn_anterior.Name = "bttn_anterior";
            bttn_anterior.Size = new Size(112, 34);
            bttn_anterior.TabIndex = 7;
            bttn_anterior.Text = "Anterior";
            bttn_anterior.UseVisualStyleBackColor = true;
            bttn_anterior.Click += bttn_anterior_Click;
            // 
            // bttn_sair
            // 
            bttn_sair.BackColor = Color.Transparent;
            bttn_sair.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bttn_sair.Location = new Point(1072, 186);
            bttn_sair.Name = "bttn_sair";
            bttn_sair.Size = new Size(112, 34);
            bttn_sair.TabIndex = 6;
            bttn_sair.Text = "Sair";
            bttn_sair.UseVisualStyleBackColor = false;
            bttn_sair.Click += bttn_sair_Click;
            // 
            // LabelUtilizador
            // 
            LabelUtilizador.AutoSize = true;
            LabelUtilizador.BackColor = Color.Transparent;
            LabelUtilizador.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LabelUtilizador.ForeColor = Color.FromArgb(192, 0, 192);
            LabelUtilizador.Location = new Point(624, 187);
            LabelUtilizador.Name = "LabelUtilizador";
            LabelUtilizador.Size = new Size(88, 28);
            LabelUtilizador.TabIndex = 16;
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
            bttn_carrinho.Location = new Point(143, 121);
            bttn_carrinho.Name = "bttn_carrinho";
            bttn_carrinho.Size = new Size(81, 74);
            bttn_carrinho.TabIndex = 17;
            bttn_carrinho.UseVisualStyleBackColor = false;
            bttn_carrinho.Click += bttn_carrinho_Click;
            // 
            // numero_itens
            // 
            numero_itens.AutoSize = true;
            numero_itens.BackColor = Color.Transparent;
            numero_itens.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numero_itens.ForeColor = Color.FromArgb(192, 0, 192);
            numero_itens.Location = new Point(230, 167);
            numero_itens.Name = "numero_itens";
            numero_itens.Size = new Size(23, 28);
            numero_itens.TabIndex = 18;
            numero_itens.Text = "?";
            // 
            // Women
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1263, 953);
            Controls.Add(numero_itens);
            Controls.Add(bttn_carrinho);
            Controls.Add(LabelUtilizador);
            Controls.Add(bttn_anterior);
            Controls.Add(bttn_sair);
            Controls.Add(TTTbtn);
            Controls.Add(CSCbtn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Women";
            Text = "Women";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CSCbtn;
        private Button TTTbtn;
        private Button bttn_anterior;
        private Button bttn_sair;
        private Label LabelUtilizador;
        private Button bttn_carrinho;
        private Label numero_itens;
    }
}