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
            SuspendLayout();
            // 
            // LBC
            // 
            LBC.BorderStyle = BorderStyle.FixedSingle;
            LBC.ForeColor = Color.Black;
            LBC.FormattingEnabled = true;
            LBC.ItemHeight = 15;
            LBC.Location = new Point(90, 138);
            LBC.Name = "LBC";
            LBC.Size = new Size(269, 317);
            LBC.TabIndex = 0;
            // 
            // NCtxt
            // 
            NCtxt.Location = new Point(548, 138);
            NCtxt.Name = "NCtxt";
            NCtxt.Size = new Size(305, 23);
            NCtxt.TabIndex = 1;
            NCtxt.TextChanged += textBox1_TextChanged;
            // 
            // MPbtn
            // 
            MPbtn.BackColor = Color.White;
            MPbtn.BackgroundImageLayout = ImageLayout.Zoom;
            MPbtn.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MPbtn.ForeColor = Color.FromArgb(192, 0, 192);
            MPbtn.Location = new Point(615, 420);
            MPbtn.Name = "MPbtn";
            MPbtn.Size = new Size(178, 35);
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
            label1.Location = new Point(504, 71);
            label1.Name = "label1";
            label1.Size = new Size(368, 21);
            label1.TabIndex = 3;
            label1.Text = "Informações antes do ato de Pagamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 0, 192);
            label2.Location = new Point(392, 138);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 4;
            label2.Text = "Numero do cartão";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(192, 0, 192);
            label3.Location = new Point(401, 211);
            label3.Name = "label3";
            label3.Size = new Size(119, 30);
            label3.TabIndex = 5;
            label3.Text = "Data de Validade\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(192, 0, 192);
            label4.Location = new Point(430, 279);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 6;
            label4.Text = "CVC";
            // 
            // DVtxt
            // 
            DVtxt.Location = new Point(548, 211);
            DVtxt.Name = "DVtxt";
            DVtxt.Size = new Size(305, 23);
            DVtxt.TabIndex = 7;
            // 
            // CVCtxt
            // 
            CVCtxt.Location = new Point(548, 279);
            CVCtxt.Name = "CVCtxt";
            CVCtxt.Size = new Size(305, 23);
            CVCtxt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 458);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 9;
            label5.Text = "Total:";
            // 
            // PTlbl
            // 
            PTlbl.AutoSize = true;
            PTlbl.Location = new Point(149, 458);
            PTlbl.Name = "PTlbl";
            PTlbl.Size = new Size(0, 15);
            PTlbl.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(192, 0, 192);
            label6.Location = new Point(428, 279);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 11;
            label6.Text = "CVC";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(192, 0, 192);
            label7.Location = new Point(387, 355);
            label7.Name = "label7";
            label7.Size = new Size(133, 15);
            label7.TabIndex = 12;
            label7.Text = "Morada de Entrega";
            // 
            // MEtxt
            // 
            MEtxt.Location = new Point(548, 353);
            MEtxt.Name = "MEtxt";
            MEtxt.Size = new Size(305, 23);
            MEtxt.TabIndex = 13;
            // 
            // carrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(884, 572);
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
    }
}