
namespace VentaViajes.Presentacion
{
    partial class FormConsultaGlobalDestinos
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
            this.dtgDestinos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDestinos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDestinos
            // 
            this.dtgDestinos.AllowUserToAddRows = false;
            this.dtgDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDestinos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgDestinos.Location = new System.Drawing.Point(0, 105);
            this.dtgDestinos.Margin = new System.Windows.Forms.Padding(4);
            this.dtgDestinos.Name = "dtgDestinos";
            this.dtgDestinos.RowHeadersWidth = 51;
            this.dtgDestinos.Size = new System.Drawing.Size(593, 457);
            this.dtgDestinos.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(250, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(90, 24);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Destinos";
            // 
            // FormConsultaGlobalDestinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 562);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtgDestinos);
            this.Name = "FormConsultaGlobalDestinos";
            this.Text = "FormConsultaGlobalDestinos";
            this.Load += new System.EventHandler(this.FormConsultaGlobalDestinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDestinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDestinos;
        private System.Windows.Forms.Label lblTitulo;
    }
}