﻿namespace Projeto_loja_de_roupa_com_Rafael_Cordeiro
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
            SuspendLayout();
            // 
            // CSCbtn
            // 
            CSCbtn.BackgroundImage = (Image)resources.GetObject("CSCbtn.BackgroundImage");
            CSCbtn.BackgroundImageLayout = ImageLayout.Zoom;
            CSCbtn.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            CSCbtn.ForeColor = Color.FromArgb(192, 0, 192);
            CSCbtn.Location = new Point(532, 155);
            CSCbtn.Name = "CSCbtn";
            CSCbtn.Size = new Size(297, 348);
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
            TTTbtn.Location = new Point(100, 155);
            TTTbtn.Name = "TTTbtn";
            TTTbtn.Size = new Size(304, 348);
            TTTbtn.TabIndex = 1;
            TTTbtn.Text = "Tops\r\nTshirts\r\nsweats\r\n\r\n";
            TTTbtn.UseVisualStyleBackColor = true;
            TTTbtn.Click += TTTbtn_Click;
            // 
            // bttn_anterior
            // 
            bttn_anterior.BackColor = Color.Transparent;
            bttn_anterior.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bttn_anterior.ForeColor = Color.FromArgb(192, 0, 192);
            bttn_anterior.Location = new Point(720, 64);
            bttn_anterior.Name = "bttn_anterior";
            bttn_anterior.Size = new Size(109, 23);
            bttn_anterior.TabIndex = 2;
            bttn_anterior.Text = "Anterior";
            bttn_anterior.UseVisualStyleBackColor = false;
            bttn_anterior.Click += button1_Click;
            // 
            // Women
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(884, 572);
            Controls.Add(bttn_anterior);
            Controls.Add(TTTbtn);
            Controls.Add(CSCbtn);
            Name = "Women";
            Text = "Women";
            ResumeLayout(false);
        }

        #endregion

        private Button CSCbtn;
        private Button TTTbtn;
        private Button bttn_anterior;
    }
}