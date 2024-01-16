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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(355, 143);
            label1.Name = "label1";
            label1.Size = new Size(186, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome de Utilizador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(398, 238);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(419, 88);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 4;
            label3.Text = "Log In";
            // 
            // checkPASS
            // 
            checkPASS.AutoSize = true;
            checkPASS.BackColor = Color.Transparent;
            checkPASS.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkPASS.ForeColor = Color.Purple;
            checkPASS.Location = new Point(563, 286);
            checkPASS.Name = "checkPASS";
            checkPASS.Size = new Size(206, 25);
            checkPASS.TabIndex = 5;
            checkPASS.Text = "Mostrar Password";
            checkPASS.UseVisualStyleBackColor = false;
            // 
            // CONFIRMARbtn
            // 
            CONFIRMARbtn.BackColor = Color.Transparent;
            CONFIRMARbtn.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            CONFIRMARbtn.ForeColor = Color.Purple;
            CONFIRMARbtn.Location = new Point(398, 343);
            CONFIRMARbtn.Name = "CONFIRMARbtn";
            CONFIRMARbtn.Size = new Size(120, 39);
            CONFIRMARbtn.TabIndex = 6;
            CONFIRMARbtn.Text = "confirmar";
            CONFIRMARbtn.UseVisualStyleBackColor = false;
            // 
            // ANTCRbtn
            // 
            ANTCRbtn.BackColor = Color.Transparent;
            ANTCRbtn.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ANTCRbtn.ForeColor = Color.Purple;
            ANTCRbtn.Location = new Point(563, 342);
            ANTCRbtn.Name = "ANTCRbtn";
            ANTCRbtn.Size = new Size(187, 45);
            ANTCRbtn.TabIndex = 7;
            ANTCRbtn.Text = "Ainda não tem conta? Registar";
            ANTCRbtn.UseVisualStyleBackColor = false;
            ANTCRbtn.Click += ANTCRbtn_Click;
            // 
            // NUtxt
            // 
            NUtxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            NUtxt.Location = new Point(355, 188);
            NUtxt.Name = "NUtxt";
            NUtxt.Size = new Size(186, 31);
            NUtxt.TabIndex = 8;
            // 
            // PASStxt
            // 
            PASStxt.Location = new Point(355, 286);
            PASStxt.Multiline = true;
            PASStxt.Name = "PASStxt";
            PASStxt.Size = new Size(186, 32);
            PASStxt.TabIndex = 9;
            // 
            // LogIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1047, 598);
            Controls.Add(PASStxt);
            Controls.Add(NUtxt);
            Controls.Add(ANTCRbtn);
            Controls.Add(CONFIRMARbtn);
            Controls.Add(checkPASS);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogIN";
            Text = "Form2";
            Load += LogIN_Load;
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
    }
}