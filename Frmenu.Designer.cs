namespace FCEATCC
{
    partial class Frmenu
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
            this.btnacademicos = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnalumnos = new System.Windows.Forms.Button();
            this.btnciclo = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnmaquina = new System.Windows.Forms.Button();
            this.btnusuario = new System.Windows.Forms.Button();
            this.btnturno = new System.Windows.Forms.Button();
            this.btngrupo = new System.Windows.Forms.Button();
            this.btnadministrador = new System.Windows.Forms.Button();
            this.btnhorario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Manual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbladministrador = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.lblciclo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnacademicos
            // 
            this.btnacademicos.BackColor = System.Drawing.Color.Transparent;
            this.btnacademicos.BackgroundImage = global::FCEATCC.Properties.Resources.aacademico;
            this.btnacademicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnacademicos.Location = new System.Drawing.Point(84, 54);
            this.btnacademicos.Name = "btnacademicos";
            this.btnacademicos.Size = new System.Drawing.Size(89, 80);
            this.btnacademicos.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnacademicos, "Agregar Académicos");
            this.btnacademicos.UseVisualStyleBackColor = false;
            this.btnacademicos.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnalumnos
            // 
            this.btnalumnos.BackColor = System.Drawing.SystemColors.Control;
            this.btnalumnos.BackgroundImage = global::FCEATCC.Properties.Resources.aalumno;
            this.btnalumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnalumnos.Location = new System.Drawing.Point(209, 54);
            this.btnalumnos.Name = "btnalumnos";
            this.btnalumnos.Size = new System.Drawing.Size(87, 80);
            this.btnalumnos.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnalumnos, "Agregar Alumnos Primer Ingreso");
            this.btnalumnos.UseVisualStyleBackColor = false;
            this.btnalumnos.Click += new System.EventHandler(this.btnagregarexc_Click);
            // 
            // btnciclo
            // 
            this.btnciclo.BackgroundImage = global::FCEATCC.Properties.Resources.calendar;
            this.btnciclo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnciclo.Location = new System.Drawing.Point(331, 54);
            this.btnciclo.Name = "btnciclo";
            this.btnciclo.Size = new System.Drawing.Size(85, 78);
            this.btnciclo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnciclo, "Cambiar Ciclo Escolar");
            this.btnciclo.UseVisualStyleBackColor = true;
            this.btnciclo.Click += new System.EventHandler(this.btncambiar_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackgroundImage = global::FCEATCC.Properties.Resources.report;
            this.btnreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreport.Location = new System.Drawing.Point(446, 54);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(89, 78);
            this.btnreport.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnreport, "Reportes");
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.BackgroundImage = global::FCEATCC.Properties.Resources.admin;
            this.btnadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadmin.Location = new System.Drawing.Point(84, 194);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(85, 78);
            this.btnadmin.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnadmin, "Administración");
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnmaquina
            // 
            this.btnmaquina.BackgroundImage = global::FCEATCC.Properties.Resources.maquina;
            this.btnmaquina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmaquina.Location = new System.Drawing.Point(209, 194);
            this.btnmaquina.Name = "btnmaquina";
            this.btnmaquina.Size = new System.Drawing.Size(81, 78);
            this.btnmaquina.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnmaquina, "Agregar Máquinas");
            this.btnmaquina.UseVisualStyleBackColor = true;
            this.btnmaquina.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnusuario
            // 
            this.btnusuario.BackgroundImage = global::FCEATCC.Properties.Resources.usuario;
            this.btnusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnusuario.Location = new System.Drawing.Point(331, 194);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(85, 78);
            this.btnusuario.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnusuario, "Agregar Usuario");
            this.btnusuario.UseVisualStyleBackColor = true;
            this.btnusuario.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnturno
            // 
            this.btnturno.BackgroundImage = global::FCEATCC.Properties.Resources.turno;
            this.btnturno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnturno.Location = new System.Drawing.Point(446, 194);
            this.btnturno.Name = "btnturno";
            this.btnturno.Size = new System.Drawing.Size(85, 78);
            this.btnturno.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnturno, "Agregar Turno");
            this.btnturno.UseVisualStyleBackColor = true;
            this.btnturno.Click += new System.EventHandler(this.button6_Click);
            // 
            // btngrupo
            // 
            this.btngrupo.BackgroundImage = global::FCEATCC.Properties.Resources.grupo;
            this.btngrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngrupo.Location = new System.Drawing.Point(84, 323);
            this.btngrupo.Name = "btngrupo";
            this.btngrupo.Size = new System.Drawing.Size(85, 78);
            this.btngrupo.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btngrupo, "Agregar Grupo");
            this.btngrupo.UseVisualStyleBackColor = true;
            this.btngrupo.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnadministrador
            // 
            this.btnadministrador.BackgroundImage = global::FCEATCC.Properties.Resources.administrador;
            this.btnadministrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadministrador.Location = new System.Drawing.Point(446, 323);
            this.btnadministrador.Name = "btnadministrador";
            this.btnadministrador.Size = new System.Drawing.Size(76, 77);
            this.btnadministrador.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnadministrador, "Administrador");
            this.btnadministrador.UseVisualStyleBackColor = true;
            this.btnadministrador.Visible = false;
            this.btnadministrador.Click += new System.EventHandler(this.btnadministrador_Click);
            // 
            // btnhorario
            // 
            this.btnhorario.BackgroundImage = global::FCEATCC.Properties.Resources.horario;
            this.btnhorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhorario.Location = new System.Drawing.Point(209, 323);
            this.btnhorario.Name = "btnhorario";
            this.btnhorario.Size = new System.Drawing.Size(85, 78);
            this.btnhorario.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnhorario, "Horario de Clase");
            this.btnhorario.UseVisualStyleBackColor = true;
            this.btnhorario.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FCEATCC.Properties.Resources.carreras;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(330, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 78);
            this.button1.TabIndex = 22;
            this.toolTip1.SetToolTip(this.button1, "Agregar Carreras");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Manual
            // 
            this.Manual.AutoSize = true;
            this.Manual.BackColor = System.Drawing.Color.Transparent;
            this.Manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manual.ForeColor = System.Drawing.Color.White;
            this.Manual.Location = new System.Drawing.Point(347, 404);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(54, 13);
            this.Manual.TabIndex = 23;
            this.Manual.Text = "Carreras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Académico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(230, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alumnos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(334, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ciclo Escolar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(463, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Reportes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(92, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Administrar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(221, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Máquinas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(350, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(467, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Turnos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(106, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Grupo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(225, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Horario";
            // 
            // lbladministrador
            // 
            this.lbladministrador.AutoSize = true;
            this.lbladministrador.BackColor = System.Drawing.Color.Transparent;
            this.lbladministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladministrador.ForeColor = System.Drawing.Color.White;
            this.lbladministrador.Location = new System.Drawing.Point(431, 405);
            this.lbladministrador.Name = "lbladministrador";
            this.lbladministrador.Size = new System.Drawing.Size(111, 13);
            this.lbladministrador.TabIndex = 21;
            this.lbladministrador.Text = "ADMINISTRADOR";
            this.lbladministrador.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(633, 34);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.AutoSize = false;
            this.configuraciónToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.configuraciónToolStripMenuItem.BackgroundImage = global::FCEATCC.Properties.Resources.CONFIG;
            this.configuraciónToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.configuraciónToolStripMenuItem.CheckOnClick = true;
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualUsuarioToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.configuraciónToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(30, 31);
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // manualUsuarioToolStripMenuItem
            // 
            this.manualUsuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.manualUsuarioToolStripMenuItem.Name = "manualUsuarioToolStripMenuItem";
            this.manualUsuarioToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.manualUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            this.manualUsuarioToolStripMenuItem.Click += new System.EventHandler(this.manualUsuarioToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(172, 449);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "FCEAT, CICLO ESCOLAR: ";
            // 
            // lblciclo
            // 
            this.lblciclo.AutoSize = true;
            this.lblciclo.BackColor = System.Drawing.Color.Transparent;
            this.lblciclo.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblciclo.ForeColor = System.Drawing.Color.White;
            this.lblciclo.Location = new System.Drawing.Point(343, 449);
            this.lblciclo.Name = "lblciclo";
            this.lblciclo.Size = new System.Drawing.Size(0, 17);
            this.lblciclo.TabIndex = 27;
            // 
            // Frmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FCEATCC.Properties.Resources.menumarco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 470);
            this.Controls.Add(this.lblciclo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Manual);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbladministrador);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnhorario);
            this.Controls.Add(this.btnadministrador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btngrupo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnturno);
            this.Controls.Add(this.btnusuario);
            this.Controls.Add(this.btnmaquina);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnciclo);
            this.Controls.Add(this.btnalumnos);
            this.Controls.Add(this.btnacademicos);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Frmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnacademicos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnalumnos;
        private System.Windows.Forms.Button btnciclo;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnmaquina;
        private System.Windows.Forms.Button btnusuario;
        private System.Windows.Forms.Button btnturno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btngrupo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnadministrador;
        private System.Windows.Forms.Button btnhorario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbladministrador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Manual;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblciclo;
        private System.Windows.Forms.ToolStripMenuItem manualUsuarioToolStripMenuItem;
    }
}