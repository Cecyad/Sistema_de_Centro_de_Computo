namespace FCEATCC
{
    partial class frmcontraseña
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
            this.txtcontraactual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcontranueva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcontraconfirmacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNOK = new System.Windows.Forms.Button();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcontraactual
            // 
            this.txtcontraactual.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraactual.Location = new System.Drawing.Point(142, 28);
            this.txtcontraactual.MaxLength = 50;
            this.txtcontraactual.Name = "txtcontraactual";
            this.txtcontraactual.Size = new System.Drawing.Size(126, 22);
            this.txtcontraactual.TabIndex = 9;
            this.txtcontraactual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontraactual_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña actual:";
            // 
            // txtcontranueva
            // 
            this.txtcontranueva.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontranueva.Location = new System.Drawing.Point(142, 78);
            this.txtcontranueva.MaxLength = 50;
            this.txtcontranueva.Name = "txtcontranueva";
            this.txtcontranueva.Size = new System.Drawing.Size(126, 22);
            this.txtcontranueva.TabIndex = 11;
            this.txtcontranueva.TextChanged += new System.EventHandler(this.txtcontranueva_TextChanged);
            this.txtcontranueva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontranueva_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Contraseña nueva:";
            // 
            // txtcontraconfirmacion
            // 
            this.txtcontraconfirmacion.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraconfirmacion.Location = new System.Drawing.Point(142, 131);
            this.txtcontraconfirmacion.MaxLength = 50;
            this.txtcontraconfirmacion.Name = "txtcontraconfirmacion";
            this.txtcontraconfirmacion.Size = new System.Drawing.Size(126, 22);
            this.txtcontraconfirmacion.TabIndex = 13;
            this.txtcontraconfirmacion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Confirme su \r\n  contraseña:";
            // 
            // BTNOK
            // 
            this.BTNOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNOK.Location = new System.Drawing.Point(43, 187);
            this.BTNOK.Name = "BTNOK";
            this.BTNOK.Size = new System.Drawing.Size(75, 23);
            this.BTNOK.TabIndex = 14;
            this.BTNOK.Text = "OK";
            this.BTNOK.UseVisualStyleBackColor = true;
            this.BTNOK.Click += new System.EventHandler(this.BTNOK_Click);
            // 
            // BTNCANCELAR
            // 
            this.BTNCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCANCELAR.Location = new System.Drawing.Point(182, 187);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(80, 23);
            this.BTNCANCELAR.TabIndex = 15;
            this.BTNCANCELAR.Text = "Cancelar";
            this.BTNCANCELAR.UseVisualStyleBackColor = true;
            this.BTNCANCELAR.Click += new System.EventHandler(this.BTNCANCELAR_Click);
            // 
            // frmcontraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 227);
            this.ControlBox = false;
            this.Controls.Add(this.BTNCANCELAR);
            this.Controls.Add(this.BTNOK);
            this.Controls.Add(this.txtcontraconfirmacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcontranueva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcontraactual);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcontraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmcontraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcontraactual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcontranueva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcontraconfirmacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNOK;
        private System.Windows.Forms.Button BTNCANCELAR;
    }
}