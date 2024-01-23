namespace Projeto_loja_de_roupa_com_Rafael_Cordeiro
{
    partial class paginaprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paginaprincipal));
            label1 = new Label();
            label2 = new Label();
            loginbtn = new Button();
            menbtn = new Button();
            womenbtn = new Button();
            bttn_sair = new Button();
            LabelUtilizador = new Label();
            bttn_carrinho = new Button();
            numero_itens = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(646, 40);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 209);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.Transparent;
            loginbtn.BackgroundImageLayout = ImageLayout.Stretch;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            loginbtn.ForeColor = Color.FromArgb(192, 0, 192);
            loginbtn.Location = new Point(416, 66);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(136, 46);
            loginbtn.TabIndex = 2;
            loginbtn.Text = "Log In";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += button1_Click;
            // 
            // menbtn
            // 
            menbtn.BackgroundImage = (Image)resources.GetObject("menbtn.BackgroundImage");
            menbtn.BackgroundImageLayout = ImageLayout.Stretch;
            menbtn.FlatAppearance.BorderColor = Color.Black;
            menbtn.FlatStyle = FlatStyle.Popup;
            menbtn.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menbtn.ForeColor = Color.FromArgb(192, 0, 192);
            menbtn.Location = new Point(220, 188);
            menbtn.Name = "menbtn";
            menbtn.Size = new Size(236, 270);
            menbtn.TabIndex = 3;
            menbtn.Text = "Men";
            menbtn.UseVisualStyleBackColor = true;
            menbtn.Click += menbtn_Click;
            // 
            // womenbtn
            // 
            womenbtn.BackgroundImage = (Image)resources.GetObject("womenbtn.BackgroundImage");
            womenbtn.BackgroundImageLayout = ImageLayout.Stretch;
            womenbtn.FlatStyle = FlatStyle.Popup;
            womenbtn.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            womenbtn.ForeColor = Color.FromArgb(192, 0, 192);
            womenbtn.Location = new Point(532, 188);
            womenbtn.Name = "womenbtn";
            womenbtn.Size = new Size(227, 270);
            womenbtn.TabIndex = 4;
            womenbtn.Text = "Women";
            womenbtn.UseVisualStyleBackColor = true;
            womenbtn.Click += womenbtn_Click;
            // 
            // bttn_sair
            // 
            bttn_sair.BackColor = Color.Transparent;
            bttn_sair.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bttn_sair.Location = new Point(647, 76);
            bttn_sair.Name = "bttn_sair";
            bttn_sair.Size = new Size(112, 34);
            bttn_sair.TabIndex = 5;
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
            LabelUtilizador.Location = new Point(437, 76);
            LabelUtilizador.Name = "LabelUtilizador";
            LabelUtilizador.Size = new Size(88, 28);
            LabelUtilizador.TabIndex = 6;
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
            bttn_carrinho.Location = new Point(121, 93);
            bttn_carrinho.Name = "bttn_carrinho";
            bttn_carrinho.Size = new Size(81, 74);
            bttn_carrinho.TabIndex = 7;
            bttn_carrinho.UseVisualStyleBackColor = false;
            bttn_carrinho.Click += bttn_carrinho_Click_1;
            // 
            // numero_itens
            // 
            numero_itens.AutoSize = true;
            numero_itens.BackColor = Color.Transparent;
            numero_itens.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numero_itens.ForeColor = Color.FromArgb(192, 0, 192);
            numero_itens.Location = new Point(208, 139);
            numero_itens.Name = "numero_itens";
            numero_itens.Size = new Size(23, 28);
            numero_itens.TabIndex = 17;
            numero_itens.Text = "?";
            // 
            // paginaprincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 572);
            Controls.Add(numero_itens);
            Controls.Add(bttn_carrinho);
            Controls.Add(LabelUtilizador);
            Controls.Add(bttn_sair);
            Controls.Add(womenbtn);
            Controls.Add(menbtn);
            Controls.Add(loginbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "paginaprincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button loginbtn;
        private Button menbtn;
        private Button womenbtn;
        private Button bttn_sair;
        private Label LabelUtilizador;
        private Button bttn_carrinho;
        private Label numero_itens;
    }
}