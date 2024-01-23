namespace Projeto_loja_de_roupa_com_Rafael_Cordeiro
{
    partial class carrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carrinho));
            NCtxt = new TextBox();
            MPbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DVtxt = new TextBox();
            CVCtxt = new TextBox();
            label5 = new Label();
            PTlbl = new Label();
            label6 = new Label();
            label7 = new Label();
            MEtxt = new TextBox();
            bttn_anterior = new Button();
            bttn_sair = new Button();
            LBC = new ListBox();
            Limpar_bttn = new Button();
            Apagar = new Button();
            SuspendLayout();
            // 
            // NCtxt
            // 
            NCtxt.Location = new Point(952, 230);
            NCtxt.Margin = new Padding(4, 5, 4, 5);
            NCtxt.Name = "NCtxt";
            NCtxt.Size = new Size(434, 31);
            NCtxt.TabIndex = 1;
            NCtxt.TextChanged += textBox1_TextChanged;
            // 
            // MPbtn
            // 
            MPbtn.BackColor = Color.White;
            MPbtn.BackgroundImageLayout = ImageLayout.Zoom;
            MPbtn.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MPbtn.ForeColor = Color.FromArgb(192, 0, 192);
            MPbtn.Location = new Point(1048, 700);
            MPbtn.Margin = new Padding(4, 5, 4, 5);
            MPbtn.Name = "MPbtn";
            MPbtn.Size = new Size(254, 58);
            MPbtn.TabIndex = 2;
            MPbtn.Text = " Confirmar";
            MPbtn.UseVisualStyleBackColor = false;
            MPbtn.Click += MPbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(720, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(562, 33);
            label1.TabIndex = 3;
            label1.Text = "Informações antes do ato de Pagamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 0, 192);
            label2.Location = new Point(729, 230);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 23);
            label2.TabIndex = 4;
            label2.Text = "Numero do cartão";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(192, 0, 192);
            label3.Location = new Point(742, 352);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(172, 46);
            label3.TabIndex = 5;
            label3.Text = "Data de Validade\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(192, 0, 192);
            label4.Location = new Point(783, 465);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 23);
            label4.TabIndex = 6;
            label4.Text = "CVC";
            // 
            // DVtxt
            // 
            DVtxt.Location = new Point(952, 352);
            DVtxt.Margin = new Padding(4, 5, 4, 5);
            DVtxt.Name = "DVtxt";
            DVtxt.Size = new Size(434, 31);
            DVtxt.TabIndex = 7;
            // 
            // CVCtxt
            // 
            CVCtxt.Location = new Point(952, 465);
            CVCtxt.Margin = new Padding(4, 5, 4, 5);
            CVCtxt.Name = "CVCtxt";
            CVCtxt.Size = new Size(434, 31);
            CVCtxt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(720, 679);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 9;
            label5.Text = "Total:";
            // 
            // PTlbl
            // 
            PTlbl.AutoSize = true;
            PTlbl.Location = new Point(213, 763);
            PTlbl.Margin = new Padding(4, 0, 4, 0);
            PTlbl.Name = "PTlbl";
            PTlbl.Size = new Size(0, 25);
            PTlbl.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(192, 0, 192);
            label6.Location = new Point(780, 465);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 23);
            label6.TabIndex = 11;
            label6.Text = "CVC";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(192, 0, 192);
            label7.Location = new Point(722, 592);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(194, 23);
            label7.TabIndex = 12;
            label7.Text = "Morada de Entrega";
            // 
            // MEtxt
            // 
            MEtxt.Location = new Point(952, 588);
            MEtxt.Margin = new Padding(4, 5, 4, 5);
            MEtxt.Name = "MEtxt";
            MEtxt.Size = new Size(434, 31);
            MEtxt.TabIndex = 13;
            // 
            // bttn_anterior
            // 
            bttn_anterior.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bttn_anterior.Location = new Point(129, 133);
            bttn_anterior.Name = "bttn_anterior";
            bttn_anterior.Size = new Size(112, 34);
            bttn_anterior.TabIndex = 15;
            bttn_anterior.Text = "Anterior";
            bttn_anterior.UseVisualStyleBackColor = true;
            bttn_anterior.Click += bttn_anterior_Click;
            // 
            // bttn_sair
            // 
            bttn_sair.BackColor = Color.Transparent;
            bttn_sair.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bttn_sair.Location = new Point(259, 133);
            bttn_sair.Name = "bttn_sair";
            bttn_sair.Size = new Size(112, 34);
            bttn_sair.TabIndex = 14;
            bttn_sair.Text = "Sair";
            bttn_sair.UseVisualStyleBackColor = false;
            bttn_sair.Click += bttn_sair_Click;
            // 
            // LBC
            // 
            LBC.FormattingEnabled = true;
            LBC.ItemHeight = 25;
            LBC.Location = new Point(119, 200);
            LBC.Name = "LBC";
            LBC.Size = new Size(594, 504);
            LBC.TabIndex = 16;
            // 
            // Limpar_bttn
            // 
            Limpar_bttn.BackColor = Color.White;
            Limpar_bttn.BackgroundImageLayout = ImageLayout.Zoom;
            Limpar_bttn.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Limpar_bttn.ForeColor = Color.FromArgb(192, 0, 192);
            Limpar_bttn.Location = new Point(119, 744);
            Limpar_bttn.Margin = new Padding(4, 5, 4, 5);
            Limpar_bttn.Name = "Limpar_bttn";
            Limpar_bttn.Size = new Size(254, 58);
            Limpar_bttn.TabIndex = 17;
            Limpar_bttn.Text = "Limpar";
            Limpar_bttn.UseVisualStyleBackColor = false;
            Limpar_bttn.Click += Limpar_bttn_Click;
            // 
            // Apagar
            // 
            Apagar.BackColor = Color.White;
            Apagar.BackgroundImageLayout = ImageLayout.Zoom;
            Apagar.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Apagar.ForeColor = Color.FromArgb(192, 0, 192);
            Apagar.Location = new Point(437, 744);
            Apagar.Margin = new Padding(4, 5, 4, 5);
            Apagar.Name = "Apagar";
            Apagar.Size = new Size(276, 58);
            Apagar.TabIndex = 18;
            Apagar.Text = "Apagar Último Item";
            Apagar.UseVisualStyleBackColor = false;
            Apagar.Click += Apagar_Click;
            // 
            // carrinho
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1429, 838);
            Controls.Add(Apagar);
            Controls.Add(Limpar_bttn);
            Controls.Add(LBC);
            Controls.Add(bttn_anterior);
            Controls.Add(bttn_sair);
            Controls.Add(MEtxt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(PTlbl);
            Controls.Add(label5);
            Controls.Add(CVCtxt);
            Controls.Add(DVtxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MPbtn);
            Controls.Add(NCtxt);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "carrinho";
            Text = "carrinho";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox NCtxt;
        private Button MPbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox DVtxt;
        private TextBox CVCtxt;
        private Label label5;
        private Label PTlbl;
        private Label label6;
        private Label label7;
        private TextBox MEtxt;
        private Button bttn_anterior;
        private Button bttn_sair;
        private ListBox LBC;
        private Button Limpar_bttn;
        private Button Apagar;
    }
}