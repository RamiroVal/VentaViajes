
namespace VentaViajes.Presentacion
{
    partial class FormAgregaBoleto
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
            this.lblNoBoleto = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblPasajero = new System.Windows.Forms.Label();
            this.txtBoleto = new System.Windows.Forms.TextBox();
            this.txtPasajero = new System.Windows.Forms.TextBox();
            this.cmbDestinos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.rdbEstudiante = new System.Windows.Forms.RadioButton();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.numAsiento = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAsiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoBoleto
            // 
            this.lblNoBoleto.AutoSize = true;
            this.lblNoBoleto.Location = new System.Drawing.Point(17, 20);
            this.lblNoBoleto.Name = "lblNoBoleto";
            this.lblNoBoleto.Size = new System.Drawing.Size(92, 13);
            this.lblNoBoleto.TabIndex = 0;
            this.lblNoBoleto.Text = "Número de Boleto";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(17, 55);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de asiento";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(17, 274);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 4;
            this.lblCosto.Text = "Costo";
            // 
            // lblPasajero
            // 
            this.lblPasajero.AutoSize = true;
            this.lblPasajero.Location = new System.Drawing.Point(17, 90);
            this.lblPasajero.Name = "lblPasajero";
            this.lblPasajero.Size = new System.Drawing.Size(105, 13);
            this.lblPasajero.TabIndex = 5;
            this.lblPasajero.Text = "Nombre del Pasajero";
            // 
            // txtBoleto
            // 
            this.txtBoleto.Location = new System.Drawing.Point(204, 17);
            this.txtBoleto.MaxLength = 4;
            this.txtBoleto.Name = "txtBoleto";
            this.txtBoleto.Size = new System.Drawing.Size(121, 20);
            this.txtBoleto.TabIndex = 0;
            this.txtBoleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoleto_KeyPress);
            this.txtBoleto.Validated += new System.EventHandler(this.txtBoleto_Validated);
            // 
            // txtPasajero
            // 
            this.txtPasajero.Location = new System.Drawing.Point(204, 87);
            this.txtPasajero.Name = "txtPasajero";
            this.txtPasajero.Size = new System.Drawing.Size(121, 20);
            this.txtPasajero.TabIndex = 2;
            this.txtPasajero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasajero_KeyPress);
            this.txtPasajero.Validated += new System.EventHandler(this.txtPasajero_Validated);
            // 
            // cmbDestinos
            // 
            this.cmbDestinos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinos.FormattingEnabled = true;
            this.cmbDestinos.Location = new System.Drawing.Point(204, 52);
            this.cmbDestinos.Name = "cmbDestinos";
            this.cmbDestinos.Size = new System.Drawing.Size(121, 21);
            this.cmbDestinos.TabIndex = 1;
            this.cmbDestinos.SelectedIndexChanged += new System.EventHandler(this.cmbDestinos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNormal);
            this.groupBox1.Controls.Add(this.rdbEstudiante);
            this.groupBox1.Location = new System.Drawing.Point(20, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Boleto";
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Checked = true;
            this.rdbNormal.Location = new System.Drawing.Point(15, 41);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(58, 17);
            this.rdbNormal.TabIndex = 1;
            this.rdbNormal.TabStop = true;
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            this.rdbNormal.CheckedChanged += new System.EventHandler(this.rdbNormal_CheckedChanged);
            // 
            // rdbEstudiante
            // 
            this.rdbEstudiante.AutoSize = true;
            this.rdbEstudiante.Location = new System.Drawing.Point(204, 41);
            this.rdbEstudiante.Name = "rdbEstudiante";
            this.rdbEstudiante.Size = new System.Drawing.Size(75, 17);
            this.rdbEstudiante.TabIndex = 2;
            this.rdbEstudiante.Text = "Estudiante";
            this.rdbEstudiante.UseVisualStyleBackColor = true;
            this.rdbEstudiante.CheckedChanged += new System.EventHandler(this.rdbNormal_CheckedChanged);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(204, 271);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(121, 20);
            this.txtCosto.TabIndex = 12;
            this.txtCosto.TabStop = false;
            // 
            // numAsiento
            // 
            this.numAsiento.Location = new System.Drawing.Point(204, 128);
            this.numAsiento.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numAsiento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAsiento.Name = "numAsiento";
            this.numAsiento.Size = new System.Drawing.Size(120, 20);
            this.numAsiento.TabIndex = 3;
            this.numAsiento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAsiento.ValueChanged += new System.EventHandler(this.numAsiento_ValueChanged);
            this.numAsiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numAsiento_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(20, 308);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(151, 41);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(173, 308);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(151, 41);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAgregaBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(348, 356);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.numAsiento);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbDestinos);
            this.Controls.Add(this.txtPasajero);
            this.Controls.Add(this.txtBoleto);
            this.Controls.Add(this.lblPasajero);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblNoBoleto);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(364, 395);
            this.MinimumSize = new System.Drawing.Size(364, 395);
            this.Name = "FormAgregaBoleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Boleto";
            this.Load += new System.EventHandler(this.FormAgregaBoleto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAsiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoBoleto;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblPasajero;
        private System.Windows.Forms.TextBox txtBoleto;
        private System.Windows.Forms.TextBox txtPasajero;
        private System.Windows.Forms.ComboBox cmbDestinos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.RadioButton rdbEstudiante;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.NumericUpDown numAsiento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}