﻿namespace WindowsAppPubs
{
    partial class FormConMetodosAuthor
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gridAuthor = new System.Windows.Forms.DataGridView();
            this.btnTodos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAuthorAddress = new System.Windows.Forms.Label();
            this.txtAuthorAddress = new System.Windows.Forms.TextBox();
            this.lblAuthorFirstName = new System.Windows.Forms.Label();
            this.txtAuthorFirstName = new System.Windows.Forms.TextBox();
            this.lblAuthorId = new System.Windows.Forms.Label();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.btnBuscarUno = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblAuthorPhone = new System.Windows.Forms.Label();
            this.txtAuthorPhone = new System.Windows.Forms.TextBox();
            this.txtContract = new System.Windows.Forms.TextBox();
            this.lblContract = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(240, 289);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(112, 27);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(468, 287);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(96, 29);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(579, 287);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 27);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(49, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(85, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Busqueda por Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(52, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(207, 20);
            this.txtId.TabIndex = 4;
            // 
            // gridAuthor
            // 
            this.gridAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthor.Location = new System.Drawing.Point(22, 322);
            this.gridAuthor.Name = "gridAuthor";
            this.gridAuthor.Size = new System.Drawing.Size(783, 194);
            this.gridAuthor.TabIndex = 5;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(698, 287);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(107, 27);
            this.btnTodos.TabIndex = 6;
            this.btnTodos.Text = "Traer Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContract);
            this.groupBox1.Controls.Add(this.lblContract);
            this.groupBox1.Controls.Add(this.txtAuthorPhone);
            this.groupBox1.Controls.Add(this.lblAuthorPhone);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Controls.Add(this.lblZip);
            this.groupBox1.Controls.Add(this.txtZip);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.lblAuthorAddress);
            this.groupBox1.Controls.Add(this.txtAuthorAddress);
            this.groupBox1.Controls.Add(this.lblAuthorFirstName);
            this.groupBox1.Controls.Add(this.txtAuthorFirstName);
            this.groupBox1.Controls.Add(this.lblAuthorId);
            this.groupBox1.Controls.Add(this.txtAuthorId);
            this.groupBox1.Location = new System.Drawing.Point(306, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 208);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AUTHOR";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(22, 165);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 19;
            this.lblState.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(137, 162);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 18;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(22, 136);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(22, 13);
            this.lblZip.TabIndex = 17;
            this.lblZip.Text = "Zip";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(137, 136);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 16;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(22, 109);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(136, 110);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 14;
            // 
            // lblAuthorAddress
            // 
            this.lblAuthorAddress.AutoSize = true;
            this.lblAuthorAddress.Location = new System.Drawing.Point(22, 84);
            this.lblAuthorAddress.Name = "lblAuthorAddress";
            this.lblAuthorAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAuthorAddress.TabIndex = 13;
            this.lblAuthorAddress.Text = "Address";
            // 
            // txtAuthorAddress
            // 
            this.txtAuthorAddress.Location = new System.Drawing.Point(136, 84);
            this.txtAuthorAddress.Name = "txtAuthorAddress";
            this.txtAuthorAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorAddress.TabIndex = 12;
            // 
            // lblAuthorFirstName
            // 
            this.lblAuthorFirstName.AutoSize = true;
            this.lblAuthorFirstName.Location = new System.Drawing.Point(21, 56);
            this.lblAuthorFirstName.Name = "lblAuthorFirstName";
            this.lblAuthorFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblAuthorFirstName.TabIndex = 11;
            this.lblAuthorFirstName.Text = "First Name";
            // 
            // txtAuthorFirstName
            // 
            this.txtAuthorFirstName.Location = new System.Drawing.Point(136, 56);
            this.txtAuthorFirstName.Name = "txtAuthorFirstName";
            this.txtAuthorFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorFirstName.TabIndex = 10;
            // 
            // lblAuthorId
            // 
            this.lblAuthorId.AutoSize = true;
            this.lblAuthorId.Location = new System.Drawing.Point(21, 29);
            this.lblAuthorId.Name = "lblAuthorId";
            this.lblAuthorId.Size = new System.Drawing.Size(50, 13);
            this.lblAuthorId.TabIndex = 9;
            this.lblAuthorId.Text = "Author Id";
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Location = new System.Drawing.Point(136, 29);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorId.TabIndex = 8;
            // 
            // btnBuscarUno
            // 
            this.btnBuscarUno.Location = new System.Drawing.Point(22, 289);
            this.btnBuscarUno.Name = "btnBuscarUno";
            this.btnBuscarUno.Size = new System.Drawing.Size(112, 27);
            this.btnBuscarUno.TabIndex = 9;
            this.btnBuscarUno.Text = "Buscar por Id";
            this.btnBuscarUno.UseVisualStyleBackColor = true;
            this.btnBuscarUno.Click += new System.EventHandler(this.btnBuscarUno_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(251, 56);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 21;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(315, 56);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 20;
            // 
            // lblAuthorPhone
            // 
            this.lblAuthorPhone.AutoSize = true;
            this.lblAuthorPhone.Location = new System.Drawing.Point(251, 91);
            this.lblAuthorPhone.Name = "lblAuthorPhone";
            this.lblAuthorPhone.Size = new System.Drawing.Size(38, 13);
            this.lblAuthorPhone.TabIndex = 22;
            this.lblAuthorPhone.Text = "Phone";
            // 
            // txtAuthorPhone
            // 
            this.txtAuthorPhone.Location = new System.Drawing.Point(315, 88);
            this.txtAuthorPhone.Name = "txtAuthorPhone";
            this.txtAuthorPhone.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorPhone.TabIndex = 23;
            // 
            // txtContract
            // 
            this.txtContract.Location = new System.Drawing.Point(315, 125);
            this.txtContract.Name = "txtContract";
            this.txtContract.Size = new System.Drawing.Size(100, 20);
            this.txtContract.TabIndex = 25;
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(251, 128);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(47, 13);
            this.lblContract.TabIndex = 24;
            this.lblContract.Text = "Contract";
            // 
            // FormConMetodosAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 537);
            this.Controls.Add(this.btnBuscarUno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.gridAuthor);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Name = "FormConMetodosAuthor";
            this.Text = "FORM CON METODOS - AUTHOR";
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView gridAuthor;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAuthorAddress;
        private System.Windows.Forms.TextBox txtAuthorAddress;
        private System.Windows.Forms.Label lblAuthorFirstName;
        private System.Windows.Forms.TextBox txtAuthorFirstName;
        private System.Windows.Forms.Label lblAuthorId;
        private System.Windows.Forms.TextBox txtAuthorId;
        private System.Windows.Forms.Button btnBuscarUno;
        private System.Windows.Forms.TextBox txtAuthorPhone;
        private System.Windows.Forms.Label lblAuthorPhone;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtContract;
        private System.Windows.Forms.Label lblContract;
    }
}

