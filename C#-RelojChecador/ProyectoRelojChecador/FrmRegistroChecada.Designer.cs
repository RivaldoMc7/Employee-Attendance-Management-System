namespace ProyectoRelojChecador
{
    partial class FrmRegistroChecada
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewRegistroChecada = new System.Windows.Forms.DataGridView();
            this.txtboxFecha = new System.Windows.Forms.Label();
            this.textBoxfecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxIdEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistroChecada)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(321, 224);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(174, 39);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridViewRegistroChecada
            // 
            this.dataGridViewRegistroChecada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistroChecada.Location = new System.Drawing.Point(16, 288);
            this.dataGridViewRegistroChecada.Name = "dataGridViewRegistroChecada";
            this.dataGridViewRegistroChecada.RowHeadersWidth = 62;
            this.dataGridViewRegistroChecada.RowTemplate.Height = 28;
            this.dataGridViewRegistroChecada.Size = new System.Drawing.Size(550, 231);
            this.dataGridViewRegistroChecada.TabIndex = 10;
            // 
            // txtboxFecha
            // 
            this.txtboxFecha.AutoSize = true;
            this.txtboxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFecha.Location = new System.Drawing.Point(107, 165);
            this.txtboxFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtboxFecha.Name = "txtboxFecha";
            this.txtboxFecha.Size = new System.Drawing.Size(109, 32);
            this.txtboxFecha.TabIndex = 9;
            this.txtboxFecha.Text = "FECHA";
            this.txtboxFecha.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBoxfecha
            // 
            this.textBoxfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfecha.Location = new System.Drawing.Point(240, 165);
            this.textBoxfecha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxfecha.Multiline = true;
            this.textBoxfecha.Name = "textBoxfecha";
            this.textBoxfecha.Size = new System.Drawing.Size(326, 41);
            this.textBoxfecha.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID EMPLEADO ";
            // 
            // txtboxIdEmpleado
            // 
            this.txtboxIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxIdEmpleado.Location = new System.Drawing.Point(240, 103);
            this.txtboxIdEmpleado.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtboxIdEmpleado.Multiline = true;
            this.txtboxIdEmpleado.Name = "txtboxIdEmpleado";
            this.txtboxIdEmpleado.Size = new System.Drawing.Size(326, 41);
            this.txtboxIdEmpleado.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "REGISTRO DE CHECADAS ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmRegistroChecada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(580, 565);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridViewRegistroChecada);
            this.Controls.Add(this.txtboxFecha);
            this.Controls.Add(this.textBoxfecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxIdEmpleado);
            this.Name = "FrmRegistroChecada";
            this.Text = "FrmRegistroChecada";
            this.Load += new System.EventHandler(this.FrmRegistroChecada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistroChecada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridViewRegistroChecada;
        private System.Windows.Forms.Label txtboxFecha;
        private System.Windows.Forms.TextBox textBoxfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxIdEmpleado;
        private System.Windows.Forms.Label label2;
    }
}