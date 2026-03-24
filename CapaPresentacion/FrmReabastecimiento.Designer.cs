namespace CapaPresentacion
{
    partial class FrmReabastecimiento
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
            this.dgvFaltantes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtendido = new System.Windows.Forms.Button();
            this.btnPedir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaltantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFaltantes
            // 
            this.dgvFaltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaltantes.Location = new System.Drawing.Point(29, 67);
            this.dgvFaltantes.Name = "dgvFaltantes";
            this.dgvFaltantes.RowHeadersWidth = 51;
            this.dgvFaltantes.RowTemplate.Height = 24;
            this.dgvFaltantes.Size = new System.Drawing.Size(742, 287);
            this.dgvFaltantes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos Faltantes";
            // 
            // btnAtendido
            // 
            this.btnAtendido.Location = new System.Drawing.Point(588, 384);
            this.btnAtendido.Name = "btnAtendido";
            this.btnAtendido.Size = new System.Drawing.Size(183, 23);
            this.btnAtendido.TabIndex = 2;
            this.btnAtendido.Text = "Marcar como atendido";
            this.btnAtendido.UseVisualStyleBackColor = true;
            this.btnAtendido.Click += new System.EventHandler(this.btnAtendido_Click);
            // 
            // btnPedir
            // 
            this.btnPedir.Location = new System.Drawing.Point(334, 384);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(248, 23);
            this.btnPedir.TabIndex = 3;
            this.btnPedir.Text = "Hacer pedido a proveedor";
            this.btnPedir.UseVisualStyleBackColor = true;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // FrmReabastecimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.btnPedir);
            this.Controls.Add(this.btnAtendido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFaltantes);
            this.Name = "FrmReabastecimiento";
            this.Text = "FrmReabastecimiento";
            this.Load += new System.EventHandler(this.FrmReabastecimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaltantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFaltantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtendido;
        private System.Windows.Forms.Button btnPedir;
    }
}