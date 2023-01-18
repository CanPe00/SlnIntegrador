namespace PresentacionEF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBuscarPorId = new System.Windows.Forms.Label();
            this.lblMsjEliminar = new System.Windows.Forms.Label();
            this.lblMsjModificar = new System.Windows.Forms.Label();
            this.lblMsjInsertar = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.grdMedicos = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarPorId
            // 
            this.lblBuscarPorId.AutoSize = true;
            this.lblBuscarPorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorId.Location = new System.Drawing.Point(759, 56);
            this.lblBuscarPorId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarPorId.Name = "lblBuscarPorId";
            this.lblBuscarPorId.Size = new System.Drawing.Size(0, 16);
            this.lblBuscarPorId.TabIndex = 25;
            // 
            // lblMsjEliminar
            // 
            this.lblMsjEliminar.AutoSize = true;
            this.lblMsjEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjEliminar.Location = new System.Drawing.Point(695, 18);
            this.lblMsjEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsjEliminar.Name = "lblMsjEliminar";
            this.lblMsjEliminar.Size = new System.Drawing.Size(0, 16);
            this.lblMsjEliminar.TabIndex = 24;
            // 
            // lblMsjModificar
            // 
            this.lblMsjModificar.AutoSize = true;
            this.lblMsjModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjModificar.Location = new System.Drawing.Point(447, 53);
            this.lblMsjModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsjModificar.Name = "lblMsjModificar";
            this.lblMsjModificar.Size = new System.Drawing.Size(0, 16);
            this.lblMsjModificar.TabIndex = 23;
            // 
            // lblMsjInsertar
            // 
            this.lblMsjInsertar.AutoSize = true;
            this.lblMsjInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjInsertar.Location = new System.Drawing.Point(447, 15);
            this.lblMsjInsertar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsjInsertar.Name = "lblMsjInsertar";
            this.lblMsjInsertar.Size = new System.Drawing.Size(0, 16);
            this.lblMsjInsertar.TabIndex = 22;
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(329, 50);
            this.btModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(100, 28);
            this.btModificar.TabIndex = 21;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(577, 12);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.Location = new System.Drawing.Point(577, 50);
            this.btnBuscarPorId.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(165, 28);
            this.btnBuscarPorId.TabIndex = 19;
            this.btnBuscarPorId.Text = "Buscar por ID";
            this.btnBuscarPorId.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(122, 65);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 22);
            this.txtNombre.TabIndex = 18;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(27, 69);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(122, 19);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(169, 22);
            this.txtId.TabIndex = 16;
            // 
            // grdMedicos
            // 
            this.grdMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMedicos.Location = new System.Drawing.Point(30, 126);
            this.grdMedicos.Margin = new System.Windows.Forms.Padding(4);
            this.grdMedicos.Name = "grdMedicos";
            this.grdMedicos.Size = new System.Drawing.Size(981, 256);
            this.grdMedicos.TabIndex = 15;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(27, 22);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Id:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(329, 9);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 28);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.lblBuscarPorId);
            this.Controls.Add(this.lblMsjEliminar);
            this.Controls.Add(this.lblMsjModificar);
            this.Controls.Add(this.lblMsjInsertar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscarPorId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.grdMedicos);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarPorId;
        private System.Windows.Forms.Label lblMsjEliminar;
        private System.Windows.Forms.Label lblMsjModificar;
        private System.Windows.Forms.Label lblMsjInsertar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView grdMedicos;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnInsertar;
    }
}

