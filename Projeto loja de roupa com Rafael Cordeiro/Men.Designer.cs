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
            // Men
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(884, 572);
            Controls.Add(CCbtn);
            Controls.Add(TSbtn);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Men";
            Text = "Men";
            ResumeLayout(false);
        }

        #endregion

        private Button TSbtn;
        private Button CCbtn;
    }
}