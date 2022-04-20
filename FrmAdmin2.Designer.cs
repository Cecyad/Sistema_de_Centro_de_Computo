namespace FCEATCC
{
    partial class FrmAdmin2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.butncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado de la computadora:";
            // 
            // cmbestado
            // 
            this.cmbestado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "RESPONSABLE"});
            this.cmbestado.Location = new System.Drawing.Point(8, 94);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(255, 26);
            this.cmbestado.TabIndex = 80;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Location = new System.Drawing.Point(28, 161);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(81, 35);
            this.btnaceptar.TabIndex = 81;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // butncancelar
            // 
            this.butncancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butncancelar.Location = new System.Drawing.Point(152, 161);
            this.butncancelar.Name = "butncancelar";
            this.butncancelar.Size = new System.Drawing.Size(91, 35);
            this.butncancelar.TabIndex = 82;
            this.butncancelar.Text = "Cancelar";
            this.butncancelar.UseVisualStyleBackColor = true;
            this.butncancelar.Click += new System.EventHandler(this.butncancelar_Click);
            // 
            // FrmAdmin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 234);
            this.ControlBox = false;
            this.Controls.Add(this.butncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.cmbestado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAdmin2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acción";
            this.Load += new System.EventHandler(this.FrmAdmin2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button butncancelar;
    }
}