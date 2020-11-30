namespace Form1
{
    partial class FrmNuevaVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvProductosElegidos = new System.Windows.Forms.DataGridView();
            this.lblProductosElegidos = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.BtnVender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosElegidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.AllowUserToResizeColumns = false;
            this.dgvListaProductos.AllowUserToResizeRows = false;
            this.dgvListaProductos.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaProductos.ColumnHeadersHeight = 40;
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvListaProductos.EnableHeadersVisualStyles = false;
            this.dgvListaProductos.GridColor = System.Drawing.Color.ForestGreen;
            this.dgvListaProductos.Location = new System.Drawing.Point(11, 54);
            this.dgvListaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.ReadOnly = true;
            this.dgvListaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaProductos.RowHeadersVisible = false;
            this.dgvListaProductos.RowHeadersWidth = 72;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListaProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaProductos.RowTemplate.Height = 31;
            this.dgvListaProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProductos.Size = new System.Drawing.Size(545, 180);
            this.dgvListaProductos.TabIndex = 2;
            this.dgvListaProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProductos_CellDoubleClick);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(11, 9);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(206, 20);
            this.lblCantidad.TabIndex = 17;
            this.lblCantidad.Text = "Elija producto y cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(397, 30);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(86, 20);
            this.txtCantidad.TabIndex = 18;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvProductosElegidos
            // 
            this.dgvProductosElegidos.AllowUserToResizeColumns = false;
            this.dgvProductosElegidos.AllowUserToResizeRows = false;
            this.dgvProductosElegidos.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvProductosElegidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosElegidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosElegidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductosElegidos.ColumnHeadersHeight = 40;
            this.dgvProductosElegidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductosElegidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProductosElegidos.EnableHeadersVisualStyles = false;
            this.dgvProductosElegidos.GridColor = System.Drawing.Color.ForestGreen;
            this.dgvProductosElegidos.Location = new System.Drawing.Point(571, 54);
            this.dgvProductosElegidos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductosElegidos.Name = "dgvProductosElegidos";
            this.dgvProductosElegidos.ReadOnly = true;
            this.dgvProductosElegidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosElegidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductosElegidos.RowHeadersVisible = false;
            this.dgvProductosElegidos.RowHeadersWidth = 72;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductosElegidos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductosElegidos.RowTemplate.Height = 31;
            this.dgvProductosElegidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductosElegidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosElegidos.Size = new System.Drawing.Size(545, 180);
            this.dgvProductosElegidos.TabIndex = 19;
            this.dgvProductosElegidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosElegidos_CellDoubleClick);
            // 
            // lblProductosElegidos
            // 
            this.lblProductosElegidos.AutoSize = true;
            this.lblProductosElegidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosElegidos.Location = new System.Drawing.Point(567, 9);
            this.lblProductosElegidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductosElegidos.Name = "lblProductosElegidos";
            this.lblProductosElegidos.Size = new System.Drawing.Size(162, 20);
            this.lblProductosElegidos.TabIndex = 20;
            this.lblProductosElegidos.Text = "Productos elegidos";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(811, 263);
            this.lblPrecioTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(75, 16);
            this.lblPrecioTotal.TabIndex = 21;
            this.lblPrecioTotal.Text = "Precio total";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(394, 9);
            this.lblCant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(62, 16);
            this.lblCant.TabIndex = 22;
            this.lblCant.Text = "Cantidad";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(922, 327);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 33);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BtnVender
            // 
            this.BtnVender.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVender.Location = new System.Drawing.Point(766, 327);
            this.BtnVender.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(120, 33);
            this.BtnVender.TabIndex = 24;
            this.BtnVender.Text = "Vender";
            this.BtnVender.UseVisualStyleBackColor = false;
            this.BtnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // FrmNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1127, 388);
            this.ControlBox = false;
            this.Controls.Add(this.BtnVender);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.lblProductosElegidos);
            this.Controls.Add(this.dgvProductosElegidos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dgvListaProductos);
            this.Name = "FrmNuevaVenta";
            this.Text = "FrmNuevaVenta";
            this.Load += new System.EventHandler(this.FrmNuevaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosElegidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvProductosElegidos;
        private System.Windows.Forms.Label lblProductosElegidos;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button BtnVender;
    }
}