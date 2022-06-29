namespace M01A14_EX004
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
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblVal = new System.Windows.Forms.Label();
            this.lbl_Int = new System.Windows.Forms.Label();
            this.lbl_IntRd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(285, 42);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(57, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite um número real";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(207, 42);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(58, 23);
            this.txtNum.TabIndex = 2;
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVal.Location = new System.Drawing.Point(65, 100);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(147, 20);
            this.lblVal.TabIndex = 3;
            this.lblVal.Text = "Você digitou o valor ";
            this.lblVal.Visible = false;
            // 
            // lbl_Int
            // 
            this.lbl_Int.AutoSize = true;
            this.lbl_Int.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Int.Location = new System.Drawing.Point(65, 137);
            this.lbl_Int.Name = "lbl_Int";
            this.lbl_Int.Size = new System.Drawing.Size(120, 20);
            this.lbl_Int.TabIndex = 4;
            this.lbl_Int.Text = "A parte inteira é ";
            this.lbl_Int.Visible = false;
            // 
            // lbl_IntRd
            // 
            this.lbl_IntRd.AutoSize = true;
            this.lbl_IntRd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_IntRd.Location = new System.Drawing.Point(65, 174);
            this.lbl_IntRd.Name = "lbl_IntRd";
            this.lbl_IntRd.Size = new System.Drawing.Size(162, 20);
            this.lbl_IntRd.TabIndex = 5;
            this.lbl_IntRd.Text = "Arredondando,  temos ";
            this.lbl_IntRd.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 232);
            this.Controls.Add(this.lbl_IntRd);
            this.Controls.Add(this.lbl_Int);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisador de Números";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOK;
        private Label label1;
        private TextBox txtNum;
        private Label lblVal;
        private Label lbl_Int;
        private Label lbl_IntRd;
    }
}