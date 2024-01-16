namespace Projeto_loja_de_roupa_com_Rafael_Cordeiro
{
    partial class Registar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registar));
            label1 = new Label();
            REGISTARbtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NUtxt = new TextBox();
            PASStxt = new TextBox();
            CPASStxt = new TextBox();
            checkPASS1 = new CheckBox();
            checkPASS2 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(458, 68);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "Registar";
            // 
            // REGISTARbtn
            // 
            REGISTARbtn.BackColor = Color.Transparent;
            REGISTARbtn.Location = new Point(428, 425);
            REGISTARbtn.Name = "REGISTARbtn";
            REGISTARbtn.Size = new Size(165, 37);
            REGISTARbtn.TabIndex = 1;
            REGISTARbtn.Text = "Registar";
            REGISTARbtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(416, 119);
            label2.Name = "label2";
            label2.Size = new Size(186, 21);
            label2.TabIndex = 2;
            label2.Text = "Nome de Utilizador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(458, 209);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Purple;
            label4.Location = new Point(407, 292);
            label4.Name = "label4";
            label4.Size = new Size(204, 21);
            label4.TabIndex = 5;
            label4.Text = "Confirmar Password";
            // 
            // NUtxt
            // 
            NUtxt.Location = new Point(416, 155);
            NUtxt.Multiline = true;
            NUtxt.Name = "NUtxt";
            NUtxt.Size = new Size(186, 29);
            NUtxt.TabIndex = 6;
            NUtxt.TextChanged += textBox1_TextChanged;
            // 
            // PASStxt
            // 
            PASStxt.Location = new Point(416, 246);
            PASStxt.Multiline = true;
            PASStxt.Name = "PASStxt";
            PASStxt.Size = new Size(186, 30);
            PASStxt.TabIndex = 7;
            // 
            // CPASStxt
            // 
            CPASStxt.Location = new Point(416, 328);
            CPASStxt.Multiline = true;
            CPASStxt.Name = "CPASStxt";
            CPASStxt.Size = new Size(186, 35);
            CPASStxt.TabIndex = 8;
            // 
            // checkPASS1
            // 
            checkPASS1.AutoSize = true;
            checkPASS1.BackColor = Color.Transparent;
            checkPASS1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkPASS1.ForeColor = Color.Purple;
            checkPASS1.Location = new Point(637, 246);
            checkPASS1.Name = "checkPASS1";
            checkPASS1.Size = new Size(153, 19);
            checkPASS1.TabIndex = 9;
            checkPASS1.Text = "Mostrar Password";
            checkPASS1.UseVisualStyleBackColor = false;
            // 
            // checkPASS2
            // 
            checkPASS2.AutoSize = true;
            checkPASS2.BackColor = Color.Transparent;
            checkPASS2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkPASS2.ForeColor = Color.Purple;
            checkPASS2.Location = new Point(637, 329);
            checkPASS2.Name = "checkPASS2";
            checkPASS2.Size = new Size(153, 19);
            checkPASS2.TabIndex = 10;
            checkPASS2.Text = "Mostrar Password";
            checkPASS2.UseVisualStyleBackColor = false;
            // 
            // Registar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(884, 572);
            Controls.Add(checkPASS2);
            Controls.Add(checkPASS1);
            Controls.Add(CPASStxt);
            Controls.Add(PASStxt);
            Controls.Add(NUtxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(REGISTARbtn);
            Controls.Add(label1);
            Name = "Registar";
            Text = "Registar";
            Load += Registar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button REGISTARbtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NUtxt;
        private TextBox PASStxt;
        private TextBox CPASStxt;
        private CheckBox checkPASS1;
        private CheckBox checkPASS2;
    }
}