namespace FCEATCC
{
    partial class FRMADMINISTRADOR
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
            this.components = new System.ComponentModel.Container();
            this.btnestados = new System.Windows.Forms.Button();
            this.btnususis = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BTNAGREGAR = new System.Windows.Forms.Button();
            this.btnmaquina = new System.Windows.Forms.Button();
            this.BTNTUSU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnestados
            // 
            this.btnestados.BackColor = System.Drawing.Color.Transparent;
            this.btnestados.BackgroundImage = global::FCEATCC.Properties.Resources.status;
            this.btnestados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnestados.Location = new System.Drawing.Point(34, 54);
            this.btnestados.Name = "btnestados";
            this.btnestados.Size = new System.Drawing.Size(64, 62);
            this.btnestados.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnestados, "Agregar Estados del sistema");
            this.btnestados.UseVisualStyleBackColor = false;
            this.btnestados.Click += new System.EventHandler(this.btnestados_Click);
            // 
            // btnususis
            // 
            this.btnususis.BackColor = System.Drawing.Color.Transparent;
            this.btnususis.BackgroundImage = global::FCEATCC.Properties.Resources.ususis;
            this.btnususis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnususis.Location = new System.Drawing.Point(186, 54);
            this.btnususis.Name = "btnususis";
            this.btnususis.Size = new System.Drawing.Size(69, 62);
            this.btnususis.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnususis, "Usuarios Sistema");
            this.btnususis.UseVisualStyleBackColor = false;
            this.btnususis.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.Transparent;
            this.btnmenu.BackgroundImage = global::FCEATCC.Properties.Resources.MENUI;
            this.btnmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmenu.Location = new System.Drawing.Point(411, 54);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(64, 62);
            this.btnmenu.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnmenu, "Ir al Menu");
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTNAGREGAR
            // 
            this.BTNAGREGAR.BackColor = System.Drawing.Color.Transparent;
            this.BTNAGREGAR.BackgroundImage = global::FCEATCC.Properties.Resources.aalumno;
            this.BTNAGREGAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNAGREGAR.Location = new System.Drawing.Point(110, 54);
            this.BTNAGREGAR.Name = "BTNAGREGAR";
            this.BTNAGREGAR.Size = new System.Drawing.Size(64, 62);
            this.BTNAGREGAR.TabIndex = 5;
            this.toolTip1.SetToolTip(this.BTNAGREGAR, "Agregar todos los alumnos de la FCEAT");
            this.BTNAGREGAR.UseVisualStyleBackColor = false;
            this.BTNAGREGAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmaquina
            // 
            this.btnmaquina.BackColor = System.Drawing.Color.Transparent;
            this.btnmaquina.BackgroundImage = global::FCEATCC.Properties.Resources.maquina;
            this.btnmaquina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmaquina.Location = new System.Drawing.Point(267, 54);
            this.btnmaquina.Name = "btnmaquina";
            this.btnmaquina.Size = new System.Drawing.Size(64, 62);
            this.btnmaquina.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnmaquina, "Agregar todas las maquinas");
            this.btnmaquina.UseVisualStyleBackColor = false;
            this.btnmaquina.Click += new System.EventHandler(this.btnmaquina_Click);
            // 
            // BTNTUSU
            // 
            this.BTNTUSU.BackColor = System.Drawing.Color.Transparent;
            this.BTNTUSU.BackgroundImage = global::FCEATCC.Properties.Resources.TUSUARIO1;
            this.BTNTUSU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNTUSU.Location = new System.Drawing.Point(337, 54);
            this.BTNTUSU.Name = "BTNTUSU";
            this.BTNTUSU.Size = new System.Drawing.Size(69, 62);
            this.BTNTUSU.TabIndex = 7;
            this.toolTip1.SetToolTip(this.BTNTUSU, "Agregar tipo de usuario del CC");
            this.BTNTUSU.UseVisualStyleBackColor = false;
            this.BTNTUSU.Click += new System.EventHandler(this.BTNTUSU_Click);
            // 
            // FRMADMINISTRADOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FCEATCC.Properties.Resources.menumarco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 164);
            this.ControlBox = false;
            this.Controls.Add(this.BTNTUSU);
            this.Controls.Add(this.btnmaquina);
            this.Controls.Add(this.BTNAGREGAR);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btnususis);
            this.Controls.Add(this.btnestados);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMADMINISTRADOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reloj";
            this.Load += new System.EventHandler(this.reloj_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnestados;
        private System.Windows.Forms.Button btnususis;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BTNAGREGAR;
        private System.Windows.Forms.Button btnmaquina;
        private System.Windows.Forms.Button BTNTUSU;
    }
}