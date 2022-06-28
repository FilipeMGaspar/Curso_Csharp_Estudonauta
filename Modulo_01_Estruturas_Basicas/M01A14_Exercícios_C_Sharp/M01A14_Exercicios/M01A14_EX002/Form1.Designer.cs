namespace M01A14_EX002
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
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblMeu = new System.Windows.Forms.Label();
            this.lblBr = new System.Windows.Forms.Label();
            this.lblBrleiro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(74, 108);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(152, 37);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblMeu
            // 
            this.lblMeu.AutoSize = true;
            this.lblMeu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMeu.Location = new System.Drawing.Point(74, 48);
            this.lblMeu.Name = "lblMeu";
            this.lblMeu.Size = new System.Drawing.Size(38, 20);
            this.lblMeu.TabIndex = 1;
            this.lblMeu.Text = "Meu";
            this.lblMeu.Visible = false;
            // 
            // lblBr
            // 
            this.lblBr.AutoSize = true;
            this.lblBr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBr.Location = new System.Drawing.Point(120, 48);
            this.lblBr.Name = "lblBr";
            this.lblBr.Size = new System.Drawing.Size(45, 20);
            this.lblBr.TabIndex = 2;
            this.lblBr.Text = "Brasil";
            this.lblBr.Visible = false;
            // 
            // lblBrleiro
            // 
            this.lblBrleiro.AutoSize = true;
            this.lblBrleiro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrleiro.Location = new System.Drawing.Point(171, 48);
            this.lblBrleiro.Name = "lblBrleiro";
            this.lblBrleiro.Size = new System.Drawing.Size(71, 20);
            this.lblBrleiro.TabIndex = 3;
            this.lblBrleiro.Text = "Brasileiro";
            this.lblBrleiro.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnInicio;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 187);
            this.Controls.Add(this.lblBrleiro);
            this.Controls.Add(this.lblBr);
            this.Controls.Add(this.lblMeu);
            this.Controls.Add(this.btnInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brasil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnInicio;
        private Label lblMeu;
        private Label lblBr;
        private Label lblBrleiro;
    }
}