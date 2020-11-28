
namespace VentaViajes.Presentacion
{
    partial class FormConsultaIndBoletos
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
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtAsiento = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtPasajero = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblAsiento = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPasajero = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(12, 9);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(84, 13);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Clave del Boleto";
            // 
            // txtClave
            // 
            this.txtClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtClave.Location = new System.Drawing.Point(15, 25);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 0;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // txtAsiento
            // 
            this.txtAsiento.Location = new System.Drawing.Point(15, 123);
            this.txtAsiento.Name = "txtAsiento";
            this.txtAsiento.ReadOnly = true;
            this.txtAsiento.Size = new System.Drawing.Size(100, 20);
            this.txtAsiento.TabIndex = 3;
            this.txtAsiento.TabStop = false;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(15, 74);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(100, 20);
            this.txtDestino.TabIndex = 4;
            this.txtDestino.TabStop = false;
            // 
            // txtPasajero
            // 
            this.txtPasajero.Location = new System.Drawing.Point(168, 25);
            this.txtPasajero.Name = "txtPasajero";
            this.txtPasajero.ReadOnly = true;
            this.txtPasajero.Size = new System.Drawing.Size(100, 20);
            this.txtPasajero.TabIndex = 5;
            this.txtPasajero.TabStop = false;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(168, 74);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 6;
            this.txtTipo.TabStop = false;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(168, 123);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 7;
            this.txtCosto.TabStop = false;
            // 
            // lblAsiento
            // 
            this.lblAsiento.AutoSize = true;
            this.lblAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento.Location = new System.Drawing.Point(12, 107);
            this.lblAsiento.Name = "lblAsiento";
            this.lblAsiento.Size = new System.Drawing.Size(62, 13);
            this.lblAsiento.TabIndex = 8;
            this.lblAsiento.Text = "No. Asiento";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(165, 58);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(76, 13);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo de Boleto";
            // 
            // lblPasajero
            // 
            this.lblPasajero.AutoSize = true;
            this.lblPasajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasajero.Location = new System.Drawing.Point(165, 9);
            this.lblPasajero.Name = "lblPasajero";
            this.lblPasajero.Size = new System.Drawing.Size(48, 13);
            this.lblPasajero.TabIndex = 10;
            this.lblPasajero.Text = "Pasajero";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(165, 107);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 11;
            this.lblCosto.Text = "Costo";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(12, 58);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 12;
            this.lblDestino.Text = "Destino";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(15, 178);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(253, 46);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormConsultaIndBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(283, 236);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblPasajero);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblAsiento);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtPasajero);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtAsiento);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(299, 275);
            this.MinimumSize = new System.Drawing.Size(299, 275);
            this.Name = "FormConsultaIndBoletos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Boleto";
            this.Load += new System.EventHandler(this.FormConsultaIndBoletos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtAsiento;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtPasajero;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblAsiento;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPasajero;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}