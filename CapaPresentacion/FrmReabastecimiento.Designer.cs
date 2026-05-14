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
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaltantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFaltantes
            // 
            this.dgvFaltantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvFaltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaltantes.Location = new System.Drawing.Point(29, 67);
            this.dgvFaltantes.Name = "dgvFaltantes";
            this.dgvFaltantes.RowHeadersWidth = 51;
            this.dgvFaltantes.RowTemplate.Height = 24;
            this.dgvFaltantes.Size = new System.Drawing.Size(1023, 310);
            this.dgvFaltantes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos Faltantes";
            // 
            // btnAtendido
            // 
            this.btnAtendido.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtendido.Location = new System.Drawing.Point(801, 399);
            this.btnAtendido.Name = "btnAtendido";
            this.btnAtendido.Size = new System.Drawing.Size(251, 40);
            this.btnAtendido.TabIndex = 2;
            this.btnAtendido.Text = "Marcar como atendido";
            this.btnAtendido.UseVisualStyleBackColor = true;
            this.btnAtendido.Click += new System.EventHandler(this.btnAtendido_Click);
            // 
            // btnPedir
            // 
            this.btnPedir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedir.Location = new System.Drawing.Point(632, 399);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(163, 40);
            this.btnPedir.TabIndex = 3;
            this.btnPedir.Text = "Hacer pedido";
            this.btnPedir.UseVisualStyleBackColor = true;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 42);
            this.label4.TabIndex = 14;
            this.label4.Text = "🍽RestoPOS";
            // 
            // FrmReabastecimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1079, 454);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
    }
}