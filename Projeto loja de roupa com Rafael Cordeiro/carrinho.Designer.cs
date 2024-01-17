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
            LBC = new ListBox();
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
            SuspendLayout();
            // 
            // LBC
            // 
            LBC.BorderStyle = BorderStyle.FixedSingle;
            LBC.ForeColor = Color.Black;
            LBC.FormattingEnabled = true;
            LBC.ItemHeight = 25;
            LBC.Location = new Point(129, 230);
            LBC.Margin = new Padding(4, 5, 4, 5);
            LBC.Name = "LBC";
            LBC.Size = new Size(383, 527);
            LBC.TabIndex = 0;
            // 
            // NCtxt
            // 
            NCtxt.Location = new Point(783, 230);
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
            MPbtn.Location = new Point(879, 700);
            MPbtn.Margin = new Padding(4, 5, 4, 5);
            MPbtn.Name = "MPbtn";
            MPbtn.Size = new Size(254, 58);
            MPbtn.TabIndex = 2;
            MPbtn.Text = " Confirmar";
            MPbtn.UseVisualStyleBackColor = false;
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
            label2.Location = new Point(560, 230);
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
            label3.Location = new Point(573, 352);
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
            label4.Location = new Point(614, 465);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 23);
            label4.TabIndex = 6;
            label4.Text = "CVC";
            // 
            // DVtxt
            // 
            DVtxt.Location = new Point(783, 352);
            DVtxt.Margin = new Padding(4, 5, 4, 5);
            DVtxt.Name = "DVtxt";
            DVtxt.Size = new Size(434, 31);
            DVtxt.TabIndex = 7;
            // 
            // CVCtxt
            // 
            CVCtxt.Location = new Point(783, 465);
            CVCtxt.Margin = new Padding(4, 5, 4, 5);
            CVCtxt.Name = "CVCtxt";
            CVCtxt.Size = new Size(434, 31);
            CVCtxt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 763);
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
            label6.Location = new Point(611, 465);
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
            label7.Location = new Point(553, 592);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(194, 23);
            label7.TabIndex = 12;
            label7.Text = "Morada de Entrega";
            // 
            // MEtxt
            // 
            MEtxt.Location = new Point(783, 588);
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
            // carrinho
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1429, 838);
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
            Controls.Add(LBC);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "carrinho";
            Text = "carrinho";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LBC;
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
    }
}