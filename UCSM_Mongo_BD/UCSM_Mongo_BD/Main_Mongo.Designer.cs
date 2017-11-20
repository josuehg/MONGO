namespace UCSM_Mongo_BD
{
    partial class Main_Mongo
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
            this.LB_Bases_de_Datos = new System.Windows.Forms.ListBox();
            this.LB_Colecciones = new System.Windows.Forms.ListBox();
            this.GB_Nuevo_Cliente = new System.Windows.Forms.GroupBox();
            this.TB_DNI_Cliente = new System.Windows.Forms.TextBox();
            this.TB_Nombres_Cliente = new System.Windows.Forms.TextBox();
            this.Label_DNI = new System.Windows.Forms.Label();
            this.Label_Nombres = new System.Windows.Forms.Label();
            this.SB_Guardar = new System.Windows.Forms.Button();
            this.TB_Nueva_BD = new System.Windows.Forms.TextBox();
            this.Label_BD = new System.Windows.Forms.Label();
            this.GB_Base_Datos = new System.Windows.Forms.GroupBox();
            this.GB_Colleciones = new System.Windows.Forms.GroupBox();
            this.Label_Coll = new System.Windows.Forms.Label();
            this.TB_Nueva_Coll = new System.Windows.Forms.TextBox();
            this.Label_Indicacion = new System.Windows.Forms.Label();
            this.Label_Notficiacion_Coll = new System.Windows.Forms.Label();
            this.GB_Buscar_Cliente = new System.Windows.Forms.GroupBox();
            this.SB_Buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Busqueda = new System.Windows.Forms.TextBox();
            this.Label_BD_Actual = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SB_Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Eliminar = new System.Windows.Forms.TextBox();
            this.TB_Direccion = new System.Windows.Forms.TextBox();
            this.TB_Telefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GB_Documentos = new System.Windows.Forms.GroupBox();
            this.LB_Documentos = new System.Windows.Forms.ListBox();
            this.SB_Modificar = new System.Windows.Forms.Button();
            this.SB_Mostrar_Todos = new System.Windows.Forms.Button();
            this.RTB_Clientes = new System.Windows.Forms.RichTextBox();
            this.GB_Nuevo_Cliente.SuspendLayout();
            this.GB_Base_Datos.SuspendLayout();
            this.GB_Colleciones.SuspendLayout();
            this.GB_Buscar_Cliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GB_Documentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Bases_de_Datos
            // 
            this.LB_Bases_de_Datos.FormattingEnabled = true;
            this.LB_Bases_de_Datos.Location = new System.Drawing.Point(6, 55);
            this.LB_Bases_de_Datos.Name = "LB_Bases_de_Datos";
            this.LB_Bases_de_Datos.Size = new System.Drawing.Size(188, 160);
            this.LB_Bases_de_Datos.TabIndex = 0;
            this.LB_Bases_de_Datos.SelectedIndexChanged += new System.EventHandler(this.LB_Bases_de_Datos_SelectedIndexChanged);
            // 
            // LB_Colecciones
            // 
            this.LB_Colecciones.FormattingEnabled = true;
            this.LB_Colecciones.Location = new System.Drawing.Point(6, 55);
            this.LB_Colecciones.Name = "LB_Colecciones";
            this.LB_Colecciones.Size = new System.Drawing.Size(188, 160);
            this.LB_Colecciones.TabIndex = 0;
            this.LB_Colecciones.SelectedIndexChanged += new System.EventHandler(this.LB_Colecciones_SelectedIndexChanged);
            // 
            // GB_Nuevo_Cliente
            // 
            this.GB_Nuevo_Cliente.Controls.Add(this.label4);
            this.GB_Nuevo_Cliente.Controls.Add(this.label2);
            this.GB_Nuevo_Cliente.Controls.Add(this.TB_Telefono);
            this.GB_Nuevo_Cliente.Controls.Add(this.TB_Direccion);
            this.GB_Nuevo_Cliente.Controls.Add(this.SB_Guardar);
            this.GB_Nuevo_Cliente.Controls.Add(this.Label_Nombres);
            this.GB_Nuevo_Cliente.Controls.Add(this.Label_DNI);
            this.GB_Nuevo_Cliente.Controls.Add(this.TB_Nombres_Cliente);
            this.GB_Nuevo_Cliente.Controls.Add(this.TB_DNI_Cliente);
            this.GB_Nuevo_Cliente.Location = new System.Drawing.Point(663, 12);
            this.GB_Nuevo_Cliente.Name = "GB_Nuevo_Cliente";
            this.GB_Nuevo_Cliente.Size = new System.Drawing.Size(302, 178);
            this.GB_Nuevo_Cliente.TabIndex = 3;
            this.GB_Nuevo_Cliente.TabStop = false;
            this.GB_Nuevo_Cliente.Text = "Agergar o modificar cliente";
            // 
            // TB_DNI_Cliente
            // 
            this.TB_DNI_Cliente.Location = new System.Drawing.Point(67, 19);
            this.TB_DNI_Cliente.Name = "TB_DNI_Cliente";
            this.TB_DNI_Cliente.Size = new System.Drawing.Size(60, 20);
            this.TB_DNI_Cliente.TabIndex = 0;
            // 
            // TB_Nombres_Cliente
            // 
            this.TB_Nombres_Cliente.Location = new System.Drawing.Point(67, 45);
            this.TB_Nombres_Cliente.Name = "TB_Nombres_Cliente";
            this.TB_Nombres_Cliente.Size = new System.Drawing.Size(229, 20);
            this.TB_Nombres_Cliente.TabIndex = 1;
            // 
            // Label_DNI
            // 
            this.Label_DNI.AutoSize = true;
            this.Label_DNI.Location = new System.Drawing.Point(6, 22);
            this.Label_DNI.Name = "Label_DNI";
            this.Label_DNI.Size = new System.Drawing.Size(29, 13);
            this.Label_DNI.TabIndex = 2;
            this.Label_DNI.Text = "DNI:";
            // 
            // Label_Nombres
            // 
            this.Label_Nombres.AutoSize = true;
            this.Label_Nombres.Location = new System.Drawing.Point(6, 48);
            this.Label_Nombres.Name = "Label_Nombres";
            this.Label_Nombres.Size = new System.Drawing.Size(52, 13);
            this.Label_Nombres.TabIndex = 3;
            this.Label_Nombres.Text = "Nombres:";
            // 
            // SB_Guardar
            // 
            this.SB_Guardar.Location = new System.Drawing.Point(6, 149);
            this.SB_Guardar.Name = "SB_Guardar";
            this.SB_Guardar.Size = new System.Drawing.Size(290, 23);
            this.SB_Guardar.TabIndex = 4;
            this.SB_Guardar.Text = "Guardar";
            this.SB_Guardar.UseVisualStyleBackColor = true;
            this.SB_Guardar.Click += new System.EventHandler(this.SB_Guardar_Click);
            // 
            // TB_Nueva_BD
            // 
            this.TB_Nueva_BD.Location = new System.Drawing.Point(54, 217);
            this.TB_Nueva_BD.Name = "TB_Nueva_BD";
            this.TB_Nueva_BD.Size = new System.Drawing.Size(140, 20);
            this.TB_Nueva_BD.TabIndex = 1;
            // 
            // Label_BD
            // 
            this.Label_BD.AutoSize = true;
            this.Label_BD.Location = new System.Drawing.Point(6, 220);
            this.Label_BD.Name = "Label_BD";
            this.Label_BD.Size = new System.Drawing.Size(42, 13);
            this.Label_BD.TabIndex = 6;
            this.Label_BD.Text = "Nueva:";
            // 
            // GB_Base_Datos
            // 
            this.GB_Base_Datos.Controls.Add(this.Label_Indicacion);
            this.GB_Base_Datos.Controls.Add(this.LB_Bases_de_Datos);
            this.GB_Base_Datos.Controls.Add(this.Label_BD);
            this.GB_Base_Datos.Controls.Add(this.TB_Nueva_BD);
            this.GB_Base_Datos.Location = new System.Drawing.Point(12, 27);
            this.GB_Base_Datos.Name = "GB_Base_Datos";
            this.GB_Base_Datos.Size = new System.Drawing.Size(200, 243);
            this.GB_Base_Datos.TabIndex = 0;
            this.GB_Base_Datos.TabStop = false;
            this.GB_Base_Datos.Text = "Bases de datos";
            // 
            // GB_Colleciones
            // 
            this.GB_Colleciones.Controls.Add(this.Label_Notficiacion_Coll);
            this.GB_Colleciones.Controls.Add(this.Label_Coll);
            this.GB_Colleciones.Controls.Add(this.TB_Nueva_Coll);
            this.GB_Colleciones.Controls.Add(this.LB_Colecciones);
            this.GB_Colleciones.Location = new System.Drawing.Point(218, 27);
            this.GB_Colleciones.Name = "GB_Colleciones";
            this.GB_Colleciones.Size = new System.Drawing.Size(200, 243);
            this.GB_Colleciones.TabIndex = 1;
            this.GB_Colleciones.TabStop = false;
            this.GB_Colleciones.Text = "Colecciones";
            // 
            // Label_Coll
            // 
            this.Label_Coll.AutoSize = true;
            this.Label_Coll.Location = new System.Drawing.Point(6, 220);
            this.Label_Coll.Name = "Label_Coll";
            this.Label_Coll.Size = new System.Drawing.Size(42, 13);
            this.Label_Coll.TabIndex = 6;
            this.Label_Coll.Text = "Nueva:";
            // 
            // TB_Nueva_Coll
            // 
            this.TB_Nueva_Coll.Location = new System.Drawing.Point(54, 217);
            this.TB_Nueva_Coll.Name = "TB_Nueva_Coll";
            this.TB_Nueva_Coll.Size = new System.Drawing.Size(140, 20);
            this.TB_Nueva_Coll.TabIndex = 1;
            // 
            // Label_Indicacion
            // 
            this.Label_Indicacion.Location = new System.Drawing.Point(6, 16);
            this.Label_Indicacion.Name = "Label_Indicacion";
            this.Label_Indicacion.Size = new System.Drawing.Size(188, 36);
            this.Label_Indicacion.TabIndex = 7;
            this.Label_Indicacion.Text = "Seleccione una base de datos o agrege una nueva.";
            // 
            // Label_Notficiacion_Coll
            // 
            this.Label_Notficiacion_Coll.Location = new System.Drawing.Point(6, 16);
            this.Label_Notficiacion_Coll.Name = "Label_Notficiacion_Coll";
            this.Label_Notficiacion_Coll.Size = new System.Drawing.Size(188, 36);
            this.Label_Notficiacion_Coll.TabIndex = 8;
            this.Label_Notficiacion_Coll.Text = "Seleccione una coleccion o agrege una nueva.";
            // 
            // GB_Buscar_Cliente
            // 
            this.GB_Buscar_Cliente.Controls.Add(this.RTB_Clientes);
            this.GB_Buscar_Cliente.Controls.Add(this.SB_Mostrar_Todos);
            this.GB_Buscar_Cliente.Controls.Add(this.SB_Buscar);
            this.GB_Buscar_Cliente.Controls.Add(this.label3);
            this.GB_Buscar_Cliente.Controls.Add(this.TB_Busqueda);
            this.GB_Buscar_Cliente.Location = new System.Drawing.Point(12, 276);
            this.GB_Buscar_Cliente.Name = "GB_Buscar_Cliente";
            this.GB_Buscar_Cliente.Size = new System.Drawing.Size(953, 173);
            this.GB_Buscar_Cliente.TabIndex = 5;
            this.GB_Buscar_Cliente.TabStop = false;
            this.GB_Buscar_Cliente.Text = "Buscar cliente";
            // 
            // SB_Buscar
            // 
            this.SB_Buscar.Location = new System.Drawing.Point(300, 17);
            this.SB_Buscar.Name = "SB_Buscar";
            this.SB_Buscar.Size = new System.Drawing.Size(123, 23);
            this.SB_Buscar.TabIndex = 1;
            this.SB_Buscar.Text = "Buscar documento";
            this.SB_Buscar.UseVisualStyleBackColor = true;
            this.SB_Buscar.Click += new System.EventHandler(this.SB_Buscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI/Nombre:";
            // 
            // TB_Busqueda
            // 
            this.TB_Busqueda.Location = new System.Drawing.Point(83, 19);
            this.TB_Busqueda.Name = "TB_Busqueda";
            this.TB_Busqueda.Size = new System.Drawing.Size(211, 20);
            this.TB_Busqueda.TabIndex = 0;
            // 
            // Label_BD_Actual
            // 
            this.Label_BD_Actual.AutoSize = true;
            this.Label_BD_Actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BD_Actual.ForeColor = System.Drawing.Color.Red;
            this.Label_BD_Actual.Location = new System.Drawing.Point(12, 9);
            this.Label_BD_Actual.Name = "Label_BD_Actual";
            this.Label_BD_Actual.Size = new System.Drawing.Size(187, 15);
            this.Label_BD_Actual.TabIndex = 11;
            this.Label_BD_Actual.Text = "Base de datos: , coleccion: .";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SB_Eliminar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_Eliminar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(663, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar cliente";
            // 
            // SB_Eliminar
            // 
            this.SB_Eliminar.Location = new System.Drawing.Point(6, 45);
            this.SB_Eliminar.Name = "SB_Eliminar";
            this.SB_Eliminar.Size = new System.Drawing.Size(290, 23);
            this.SB_Eliminar.TabIndex = 1;
            this.SB_Eliminar.Text = "Eliminar";
            this.SB_Eliminar.UseVisualStyleBackColor = true;
            this.SB_Eliminar.Click += new System.EventHandler(this.SB_Eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eliminar mediante DNI:";
            // 
            // TB_Eliminar
            // 
            this.TB_Eliminar.Location = new System.Drawing.Point(126, 19);
            this.TB_Eliminar.Name = "TB_Eliminar";
            this.TB_Eliminar.Size = new System.Drawing.Size(170, 20);
            this.TB_Eliminar.TabIndex = 0;
            // 
            // TB_Direccion
            // 
            this.TB_Direccion.Location = new System.Drawing.Point(67, 71);
            this.TB_Direccion.Multiline = true;
            this.TB_Direccion.Name = "TB_Direccion";
            this.TB_Direccion.Size = new System.Drawing.Size(229, 46);
            this.TB_Direccion.TabIndex = 2;
            // 
            // TB_Telefono
            // 
            this.TB_Telefono.Location = new System.Drawing.Point(67, 123);
            this.TB_Telefono.Name = "TB_Telefono";
            this.TB_Telefono.Size = new System.Drawing.Size(60, 20);
            this.TB_Telefono.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefono:";
            // 
            // GB_Documentos
            // 
            this.GB_Documentos.Controls.Add(this.SB_Modificar);
            this.GB_Documentos.Controls.Add(this.LB_Documentos);
            this.GB_Documentos.Location = new System.Drawing.Point(424, 27);
            this.GB_Documentos.Name = "GB_Documentos";
            this.GB_Documentos.Size = new System.Drawing.Size(233, 243);
            this.GB_Documentos.TabIndex = 2;
            this.GB_Documentos.TabStop = false;
            this.GB_Documentos.Text = "Documentos de clientes (Solo nombre)";
            // 
            // LB_Documentos
            // 
            this.LB_Documentos.FormattingEnabled = true;
            this.LB_Documentos.Location = new System.Drawing.Point(6, 19);
            this.LB_Documentos.Name = "LB_Documentos";
            this.LB_Documentos.Size = new System.Drawing.Size(221, 186);
            this.LB_Documentos.TabIndex = 0;
            // 
            // SB_Modificar
            // 
            this.SB_Modificar.Location = new System.Drawing.Point(6, 214);
            this.SB_Modificar.Name = "SB_Modificar";
            this.SB_Modificar.Size = new System.Drawing.Size(221, 23);
            this.SB_Modificar.TabIndex = 1;
            this.SB_Modificar.Text = "Modificar";
            this.SB_Modificar.UseVisualStyleBackColor = true;
            // 
            // SB_Mostrar_Todos
            // 
            this.SB_Mostrar_Todos.Location = new System.Drawing.Point(429, 17);
            this.SB_Mostrar_Todos.Name = "SB_Mostrar_Todos";
            this.SB_Mostrar_Todos.Size = new System.Drawing.Size(193, 23);
            this.SB_Mostrar_Todos.TabIndex = 2;
            this.SB_Mostrar_Todos.Text = "Mostrar todos los documenentos";
            this.SB_Mostrar_Todos.UseVisualStyleBackColor = true;
            this.SB_Mostrar_Todos.Click += new System.EventHandler(this.SB_Mostrar_Todos_Click);
            // 
            // RTB_Clientes
            // 
            this.RTB_Clientes.BackColor = System.Drawing.Color.White;
            this.RTB_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTB_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_Clientes.Location = new System.Drawing.Point(6, 46);
            this.RTB_Clientes.Name = "RTB_Clientes";
            this.RTB_Clientes.ReadOnly = true;
            this.RTB_Clientes.Size = new System.Drawing.Size(941, 121);
            this.RTB_Clientes.TabIndex = 3;
            this.RTB_Clientes.Text = "Clientes:";
            // 
            // Main_Mongo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 461);
            this.Controls.Add(this.GB_Documentos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label_BD_Actual);
            this.Controls.Add(this.GB_Buscar_Cliente);
            this.Controls.Add(this.GB_Colleciones);
            this.Controls.Add(this.GB_Base_Datos);
            this.Controls.Add(this.GB_Nuevo_Cliente);
            this.Name = "Main_Mongo";
            this.Text = "Mongodb y C#";
            this.Load += new System.EventHandler(this.Main_Mongo_Load);
            this.GB_Nuevo_Cliente.ResumeLayout(false);
            this.GB_Nuevo_Cliente.PerformLayout();
            this.GB_Base_Datos.ResumeLayout(false);
            this.GB_Base_Datos.PerformLayout();
            this.GB_Colleciones.ResumeLayout(false);
            this.GB_Colleciones.PerformLayout();
            this.GB_Buscar_Cliente.ResumeLayout(false);
            this.GB_Buscar_Cliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GB_Documentos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Bases_de_Datos;
        private System.Windows.Forms.ListBox LB_Colecciones;
        private System.Windows.Forms.GroupBox GB_Nuevo_Cliente;
        private System.Windows.Forms.Button SB_Guardar;
        private System.Windows.Forms.Label Label_Nombres;
        private System.Windows.Forms.Label Label_DNI;
        private System.Windows.Forms.TextBox TB_Nombres_Cliente;
        private System.Windows.Forms.TextBox TB_DNI_Cliente;
        private System.Windows.Forms.TextBox TB_Nueva_BD;
        private System.Windows.Forms.Label Label_BD;
        private System.Windows.Forms.GroupBox GB_Base_Datos;
        private System.Windows.Forms.GroupBox GB_Colleciones;
        private System.Windows.Forms.Label Label_Coll;
        private System.Windows.Forms.TextBox TB_Nueva_Coll;
        private System.Windows.Forms.Label Label_Indicacion;
        private System.Windows.Forms.Label Label_Notficiacion_Coll;
        private System.Windows.Forms.GroupBox GB_Buscar_Cliente;
        private System.Windows.Forms.Button SB_Buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Busqueda;
        private System.Windows.Forms.Label Label_BD_Actual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Telefono;
        private System.Windows.Forms.TextBox TB_Direccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SB_Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Eliminar;
        private System.Windows.Forms.GroupBox GB_Documentos;
        private System.Windows.Forms.ListBox LB_Documentos;
        private System.Windows.Forms.Button SB_Modificar;
        private System.Windows.Forms.Button SB_Mostrar_Todos;
        private System.Windows.Forms.RichTextBox RTB_Clientes;
    }
}

