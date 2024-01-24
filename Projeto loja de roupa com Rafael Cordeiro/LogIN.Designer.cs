namespace Projeto_loja_de_roupa_com_Rafael_Cordeiro
{
    partial class LogIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIN));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkPASS = new CheckBox();
            CONFIRMARbtn = new Button();
            ANTCRbtn = new Button();
            NUtxt = new TextBox();
            PASStxt = new TextBox();
            bttn_anterior = new Button();
            bttn_sair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(507, 238);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(280, 33);
            label1.TabIndex = 0;
            label1.Text = "Nome de Utilizador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(569, 397);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 33);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(599, 147);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 33);
            label3.TabIndex = 4;
            label3.Text = "Log In";
            // 
            // checkPASS
            // 
            checkPASS.AutoSize = true;
            checkPASS.BackColor = Color.Transparent;
            checkPASS.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkPASS.ForeColor = Color.Purple;
            checkPASS.Location = new Point(804, 477);
            checkPASS.Margin = new Padding(4, 5, 4, 5);
            checkPASS.Name = "checkPASS";
            checkPASS.Size = new Size(309, 37);
            checkPASS.TabIndex = 5;
            checkPASS.Text = "Mostrar Password";
            checkPASS.UseVisualStyleBackColor = false;
            checkPASS.CheckedChanged += checkPASS_CheckedChanged;
            // 
            // CONFIRMARbtn
            // 
            CONFIRMARbtn.BackColor = Color.Transparent;
            CONFIRMARbtn.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            CONFIRMARbtn.ForeColor = Color.Purple;
            CONFIRMARbtn.Location = new Point(569, 572);
            CONFIRMARbtn.Margin = new Padding(4, 5, 4, 5);
            CONFIRMARbtn.Name = "CONFIRMARbtn";
            CONFIRMARbtn.Size = new Size(171, 65);
            CONFIRMARbtn.TabIndex = 6;
            CONFIRMARbtn.Text = "confirmar";
            CONFIRMARbtn.UseVisualStyleBackColor = false;
            CONFIRMARbtn.Click += CONFIRMARbtn_Click;
            // 
            // ANTCRbtn
            // 
            ANTCRbtn.BackColor = Color.Transparent;
            ANTCRbtn.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ANTCRbtn.ForeColor = Color.Purple;
            ANTCRbtn.Location = new Point(804, 570);
            ANTCRbtn.Margin = new Padding(4, 5, 4, 5);
            ANTCRbtn.Name = "ANTCRbtn";
            ANTCRbtn.Size = new Size(267, 75);
            ANTCRbtn.TabIndex = 7;
            ANTCRbtn.Text = "Ainda não tem conta? Registar";
            ANTCRbtn.UseVisualStyleBackColor = false;
            ANTCRbtn.Click += ANTCRbtn_Click;
            // 
            // NUtxt
            // 
            NUtxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            NUtxt.Location = new Point(507, 313);
            NUtxt.Margin = new Padding(4, 5, 4, 5);
            NUtxt.Name = "NUtxt";
            NUtxt.Size = new Size(264, 42);
            NUtxt.TabIndex = 8;
            // 
            // PASStxt
            // 
            PASStxt.Location = new Point(507, 477);
            PASStxt.Margin = new Padding(4, 5, 4, 5);
            PASStxt.Name = "PASStxt";
            PASStxt.Size = new Size(264, 31);
            PASStxt.TabIndex = 9;
            PASStxt.TextChanged += PASStxt_TextChanged;
            // 
            // bttn_anterior
            // 
            bttn_anterior.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bttn_anterior.Location = new Point(907, 147);
            bttn_anterior.Name = "bttn_anterior";
            bttn_anterior.Size = new Size(112, 34);
            bttn_anterior.TabIndex = 11;
            bttn_anterior.Text = "Anterior";
            bttn_anterior.UseVisualStyleBackColor = true;
            bttn_anterior.Click += bttn_anterior_Click;
            // 
            // bttn_sair
            // 
            bttn_sair.BackColor = Color.Transparent;
            bttn_sair.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bttn_sair.Location = new Point(1037, 147);
            bttn_sair.Name = "bttn_sair";
            bttn_sair.Size = new Size(112, 34);
            bttn_sair.TabIndex = 10;
            bttn_sair.Text = "Sair";
            bttn_sair.UseVisualStyleBackColor = false;
            bttn_sair.Click += bttn_sair_Click;
            // 
            // LogIN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1496, 997);
            Controls.Add(bttn_anterior);
            Controls.Add(bttn_sair);
            Controls.Add(PASStxt);
            Controls.Add(NUtxt);
            Controls.Add(ANTCRbtn);
            Controls.Add(CONFIRMARbtn);
            Controls.Add(checkPASS);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "LogIN";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkPASS;
        private Button CONFIRMARbtn;
        private Button ANTCRbtn;
        private TextBox NUtxt;
        private TextBox PASStxt;
        private Button bttn_anterior;
        private Button bttn_sair;
    }
}