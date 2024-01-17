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
            SuspendLayout();
            // 
            // TSbtn
            // 
            TSbtn.BackgroundImage = (Image)resources.GetObject("TSbtn.BackgroundImage");
            TSbtn.BackgroundImageLayout = ImageLayout.Zoom;
            TSbtn.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            TSbtn.ForeColor = Color.DarkOrchid;
            TSbtn.Location = new Point(117, 158);
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
            CCbtn.Location = new Point(484, 163);
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
            // Men
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(884, 572);
            Controls.Add(bttn_anterior);
            Controls.Add(bttn_sair);
            Controls.Add(CCbtn);
            Controls.Add(TSbtn);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Men";
            Text = "Men";
            Load += Men_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button TSbtn;
        private Button CCbtn;
        private Button bttn_sair;
        private Button bttn_anterior;
    }
}