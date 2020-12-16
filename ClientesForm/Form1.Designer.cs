namespace ClientesForm
{
    partial class Form1
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtMasc = new System.Windows.Forms.RadioButton();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcodigoo = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblVarones = new System.Windows.Forms.Label();
            this.lblMujeres = new System.Windows.Forms.Label();
            this.lblPorcVaron = new System.Windows.Forms.Label();
            this.lblPorcMujer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblMayorEdad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(108, 264);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Casado";
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.Location = new System.Drawing.Point(113, 231);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(15, 14);
            this.chkCasado.TabIndex = 29;
            this.chkCasado.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(113, 196);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 28;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sexo";
            // 
            // rbtMasc
            // 
            this.rbtMasc.AutoSize = true;
            this.rbtMasc.Location = new System.Drawing.Point(113, 173);
            this.rbtMasc.Name = "rbtMasc";
            this.rbtMasc.Size = new System.Drawing.Size(73, 17);
            this.rbtMasc.TabIndex = 26;
            this.rbtMasc.TabStop = true;
            this.rbtMasc.Text = "Masculino";
            this.rbtMasc.UseVisualStyleBackColor = true;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(28, 143);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(60, 13);
            this.lblFechaNac.TabIndex = 25;
            this.lblFechaNac.Text = "Fecha Nac";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(102, 136);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNac.TabIndex = 24;
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Items.AddRange(new object[] {
            "LC",
            "LE",
            "DNI",
            "PASAPORTE"});
            this.cboTipoDoc.Location = new System.Drawing.Point(102, 75);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.cboTipoDoc.TabIndex = 23;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(28, 108);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 22;
            this.lblDocumento.Text = "Documento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "TipoDocumento";
            // 
            // lblcodigoo
            // 
            this.lblcodigoo.AutoSize = true;
            this.lblcodigoo.Location = new System.Drawing.Point(46, 19);
            this.lblcodigoo.Name = "lblcodigoo";
            this.lblcodigoo.Size = new System.Drawing.Size(39, 13);
            this.lblcodigoo.TabIndex = 19;
            this.lblcodigoo.Text = "codigo";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(102, 101);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(102, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(102, 19);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 16;
            // 
            // lblVarones
            // 
            this.lblVarones.AutoSize = true;
            this.lblVarones.Location = new System.Drawing.Point(187, 175);
            this.lblVarones.Name = "lblVarones";
            this.lblVarones.Size = new System.Drawing.Size(13, 13);
            this.lblVarones.TabIndex = 32;
            this.lblVarones.Text = "0";
            // 
            // lblMujeres
            // 
            this.lblMujeres.AutoSize = true;
            this.lblMujeres.Location = new System.Drawing.Point(190, 198);
            this.lblMujeres.Name = "lblMujeres";
            this.lblMujeres.Size = new System.Drawing.Size(13, 13);
            this.lblMujeres.TabIndex = 33;
            this.lblMujeres.Text = "0";
            // 
            // lblPorcVaron
            // 
            this.lblPorcVaron.AutoSize = true;
            this.lblPorcVaron.Location = new System.Drawing.Point(209, 177);
            this.lblPorcVaron.Name = "lblPorcVaron";
            this.lblPorcVaron.Size = new System.Drawing.Size(13, 13);
            this.lblPorcVaron.TabIndex = 34;
            this.lblPorcVaron.Text = "0";
            // 
            // lblPorcMujer
            // 
            this.lblPorcMujer.AutoSize = true;
            this.lblPorcMujer.Location = new System.Drawing.Point(209, 196);
            this.lblPorcMujer.Name = "lblPorcMujer";
            this.lblPorcMujer.Size = new System.Drawing.Size(13, 13);
            this.lblPorcMujer.TabIndex = 35;
            this.lblPorcMujer.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "%";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(320, 142);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(13, 13);
            this.lblEdad.TabIndex = 38;
            this.lblEdad.Text = "0";
            // 
            // lblMayorEdad
            // 
            this.lblMayorEdad.AutoSize = true;
            this.lblMayorEdad.Location = new System.Drawing.Point(359, 143);
            this.lblMayorEdad.Name = "lblMayorEdad";
            this.lblMayorEdad.Size = new System.Drawing.Size(13, 13);
            this.lblMayorEdad.TabIndex = 39;
            this.lblMayorEdad.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 365);
            this.Controls.Add(this.lblMayorEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPorcMujer);
            this.Controls.Add(this.lblPorcVaron);
            this.Controls.Add(this.lblMujeres);
            this.Controls.Add(this.lblVarones);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkCasado);
            this.Controls.Add(this.rbtFemenino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtMasc);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcodigoo);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkCasado;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtMasc;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcodigoo;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblVarones;
        private System.Windows.Forms.Label lblMujeres;
        private System.Windows.Forms.Label lblPorcVaron;
        private System.Windows.Forms.Label lblPorcMujer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblMayorEdad;
    }
}

