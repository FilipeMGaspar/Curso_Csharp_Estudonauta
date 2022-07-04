namespace M01A14_WinForm_EX008
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Inicio = new System.Windows.Forms.TextBox();
            this.txt_Fim = new System.Windows.Forms.TextBox();
            this.Btn_sorteia = new System.Windows.Forms.Button();
            this.lblSorte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fim";
            // 
            // txt_Inicio
            // 
            this.txt_Inicio.Location = new System.Drawing.Point(125, 51);
            this.txt_Inicio.Name = "txt_Inicio";
            this.txt_Inicio.Size = new System.Drawing.Size(71, 23);
            this.txt_Inicio.TabIndex = 2;
            // 
            // txt_Fim
            // 
            this.txt_Fim.Location = new System.Drawing.Point(125, 97);
            this.txt_Fim.Name = "txt_Fim";
            this.txt_Fim.Size = new System.Drawing.Size(71, 23);
            this.txt_Fim.TabIndex = 3;
            // 
            // Btn_sorteia
            // 
            this.Btn_sorteia.Location = new System.Drawing.Point(61, 153);
            this.Btn_sorteia.Name = "Btn_sorteia";
            this.Btn_sorteia.Size = new System.Drawing.Size(135, 33);
            this.Btn_sorteia.TabIndex = 4;
            this.Btn_sorteia.Text = "SORTEAR";
            this.Btn_sorteia.UseVisualStyleBackColor = true;
            this.Btn_sorteia.Click += new System.EventHandler(this.Btn_sorteia_Click);
            // 
            // lblSorte
            // 
            this.lblSorte.AutoSize = true;
            this.lblSorte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSorte.Location = new System.Drawing.Point(35, 213);
            this.lblSorte.Name = "lblSorte";
            this.lblSorte.Size = new System.Drawing.Size(87, 21);
            this.lblSorte.TabIndex = 5;
            this.lblSorte.Text = "Mensagem";
            this.lblSorte.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 304);
            this.Controls.Add(this.lblSorte);
            this.Controls.Add(this.Btn_sorteia);
            this.Controls.Add(this.txt_Fim);
            this.Controls.Add(this.txt_Inicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Inicio;
        private TextBox txt_Fim;
        private Button Btn_sorteia;
        private Label lblSorte;
    }
}