﻿namespace FCEATCC
{
    partial class Frmgrupo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbcarrera = new System.Windows.Forms.ComboBox();
            this.lblcarrera = new System.Windows.Forms.Label();
            this.cmbturno = new System.Windows.Forms.ComboBox();
            this.lblgrupo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgrado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.dgvgrupo = new System.Windows.Forms.DataGridView();
            this.txtgrupo = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbcarrera
            // 
            this.cmbcarrera.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcarrera.FormattingEnabled = true;
            this.cmbcarrera.Location = new System.Drawing.Point(102, 132);
            this.cmbcarrera.Name = "cmbcarrera";
            this.cmbcarrera.Size = new System.Drawing.Size(210, 26);
            this.cmbcarrera.TabIndex = 119;
            this.cmbcarrera.SelectedIndexChanged += new System.EventHandler(this.cmbcarrera_SelectedIndexChanged);
            // 
            // lblcarrera
            // 
            this.lblcarrera.AutoSize = true;
            this.lblcarrera.BackColor = System.Drawing.Color.Transparent;
            this.lblcarrera.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarrera.Location = new System.Drawing.Point(8, 132);
            this.lblcarrera.Name = "lblcarrera";
            this.lblcarrera.Size = new System.Drawing.Size(98, 25);
            this.lblcarrera.TabIndex = 118;
            this.lblcarrera.Text = "Carrera:";
            // 
            // cmbturno
            // 
            this.cmbturno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbturno.FormattingEnabled = true;
            this.cmbturno.Location = new System.Drawing.Point(102, 173);
            this.cmbturno.Name = "cmbturno";
            this.cmbturno.Size = new System.Drawing.Size(210, 26);
            this.cmbturno.TabIndex = 117;
            // 
            // lblgrupo
            // 
            this.lblgrupo.AutoSize = true;
            this.lblgrupo.BackColor = System.Drawing.Color.Transparent;
            this.lblgrupo.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrupo.Location = new System.Drawing.Point(26, 172);
            this.lblgrupo.Name = "lblgrupo";
            this.lblgrupo.Size = new System.Drawing.Size(80, 25);
            this.lblgrupo.TabIndex = 116;
            this.lblgrupo.Text = "Turno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 114;
            this.label1.Text = "Grado:";
            // 
            // txtgrado
            // 
            this.txtgrado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgrado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrado.Location = new System.Drawing.Point(240, 88);
            this.txtgrado.MaxLength = 10;
            this.txtgrado.Name = "txtgrado";
            this.txtgrado.Size = new System.Drawing.Size(72, 26);
            this.txtgrado.TabIndex = 112;
            this.txtgrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcvegrupo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 111;
            this.label5.Text = "Grupo:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(56, 56);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(1, 1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(261, 63);
            this.toolStrip1.TabIndex = 69;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::FCEATCC.Properties.Resources.nuevo;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton1.Text = "Nuevo";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 63);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = global::FCEATCC.Properties.Resources.guardar;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton2.Text = "Grabar";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 63);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.Image = global::FCEATCC.Properties.Resources.eliminar2;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton3.Text = "Eliminar";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 63);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton4.Image = global::FCEATCC.Properties.Resources.limpiar;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton4.Text = "Limpiar";
            this.toolStripButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton5.Image = global::FCEATCC.Properties.Resources.salirr;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton5.Text = "Salir";
            this.toolStripButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton5.Visible = false;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // dgvgrupo
            // 
            this.dgvgrupo.AllowUserToAddRows = false;
            this.dgvgrupo.AllowUserToDeleteRows = false;
            this.dgvgrupo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvgrupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvgrupo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvgrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvgrupo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvgrupo.Location = new System.Drawing.Point(1, 217);
            this.dgvgrupo.Name = "dgvgrupo";
            this.dgvgrupo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvgrupo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvgrupo.Size = new System.Drawing.Size(572, 201);
            this.dgvgrupo.TabIndex = 122;
            this.dgvgrupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgrupo_CellClick);
            // 
            // txtgrupo
            // 
            this.txtgrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgrupo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrupo.Location = new System.Drawing.Point(89, 85);
            this.txtgrupo.MaxLength = 10;
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(63, 26);
            this.txtgrupo.TabIndex = 123;
            this.txtgrupo.TextChanged += new System.EventHandler(this.txtgrupo_TextChanged);
            this.txtgrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgrupo_KeyPress);
            // 
            // Frmgrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FCEATCC.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(378, 418);
            this.Controls.Add(this.txtgrupo);
            this.Controls.Add(this.cmbcarrera);
            this.Controls.Add(this.lblcarrera);
            this.Controls.Add(this.cmbturno);
            this.Controls.Add(this.lblgrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgrado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvgrupo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frmgrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmgrupo";
            this.Load += new System.EventHandler(this.Frmgrupo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbcarrera;
        private System.Windows.Forms.Label lblcarrera;
        private System.Windows.Forms.ComboBox cmbturno;
        private System.Windows.Forms.Label lblgrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgrado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.DataGridView dgvgrupo;
        private System.Windows.Forms.TextBox txtgrupo;
    }
}