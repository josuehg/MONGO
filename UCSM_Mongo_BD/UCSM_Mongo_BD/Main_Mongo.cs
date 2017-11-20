using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using System.ComponentModel;

namespace UCSM_Mongo_BD
{
    public partial class Main_Mongo : Form
    {
        private Mongodb_Conect New_Mongodb_Conect;
        public Main_Mongo()
        {
            InitializeComponent();
            this.New_Mongodb_Conect = new Mongodb_Conect();
        }
        //
        private void Main_Mongo_Load(object sender, EventArgs e)
        {
            this.Cargar_Data();
        }

        private void LB_Bases_de_Datos_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<string> Colleciones = New_Mongodb_Conect.get_Colleciones(this.LB_Bases_de_Datos.Text);
            this.LB_Colecciones.DataSource = Colleciones.ToList();
            this.Label_BD_Actual.Text = "Base de datos: " + this.LB_Bases_de_Datos.Text + ", coleccion: " + this.LB_Colecciones.Text + ".";
        }
        //
        private void LB_Colecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Label_BD_Actual.Text = "Base de datos: " + this.LB_Bases_de_Datos.Text + ", coleccion: " + this.LB_Colecciones.Text + ".";
            this.LB_Documentos.DataSource = this.New_Mongodb_Conect.Get_Clientes_Coleccion(this.LB_Bases_de_Datos.Text, this.LB_Colecciones.Text);
        }
        //
        private void Cargar_Data()
        {
            IEnumerable<string> Base_Datos = this.New_Mongodb_Conect.get_BaseDatos();
            this.LB_Bases_de_Datos.DataSource = Base_Datos.ToList();
        }
        //
        private void SB_Guardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.TB_Nueva_BD.Text) && string.IsNullOrEmpty(this.TB_Nueva_Coll.Text))
                this.New_Mongodb_Conect.Insertar_Cliente(this.LB_Bases_de_Datos.Text, this.LB_Colecciones.Text, 
                    this.TB_DNI_Cliente.Text, this.TB_Nombres_Cliente.Text, this.TB_Direccion.Text, this.TB_Telefono.Text);
            if (string.IsNullOrEmpty(this.TB_Nueva_BD.Text) && !string.IsNullOrEmpty(this.TB_Nueva_Coll.Text))
                this.New_Mongodb_Conect.Insertar_Cliente(this.LB_Bases_de_Datos.Text, this.TB_Nueva_Coll.Text, 
                    this.TB_DNI_Cliente.Text, this.TB_Nombres_Cliente.Text, this.TB_Direccion.Text, this.TB_Telefono.Text);
            if (!string.IsNullOrEmpty(this.TB_Nueva_BD.Text) && string.IsNullOrEmpty(this.TB_Nueva_Coll.Text))
                this.New_Mongodb_Conect.Insertar_Cliente(this.TB_Nueva_BD.Text, this.LB_Colecciones.Text, 
                    this.TB_DNI_Cliente.Text, this.TB_Nombres_Cliente.Text, this.TB_Direccion.Text, this.TB_Telefono.Text);
            if (!string.IsNullOrEmpty(this.TB_Nueva_BD.Text) && !string.IsNullOrEmpty(this.TB_Nueva_Coll.Text))
                this.New_Mongodb_Conect.Insertar_Cliente(this.TB_Nueva_BD.Text, this.TB_Nueva_Coll.Text, 
                    this.TB_DNI_Cliente.Text, this.TB_Nombres_Cliente.Text, this.TB_Direccion.Text, this.TB_Telefono.Text);
            this.Cargar_Data();
            this.TB_DNI_Cliente.Text = string.Empty;
            this.TB_Nombres_Cliente.Text = string.Empty;
            this.TB_Direccion.Text = string.Empty;
            this.TB_Telefono.Text = string.Empty;
        }

        private void SB_Buscar_Click(object sender, EventArgs e)
        {
            if(this.TB_Busqueda.Text.Length > 0)
                this.RTB_Clientes.Text = "Clientes:\n" + this.New_Mongodb_Conect.Buscar_Cliente(this.LB_Bases_de_Datos.Text, this.LB_Colecciones.Text,this.TB_Busqueda.Text);
        }

        private void SB_Eliminar_Click(object sender, EventArgs e)
        {
            this.New_Mongodb_Conect.Eliminar_Cliente(this.LB_Bases_de_Datos.Text, this.LB_Colecciones.Text, this.TB_Eliminar.Text);
            this.Cargar_Data();
            this.TB_Eliminar.Text = string.Empty;
        }

        private void SB_Mostrar_Todos_Click(object sender, EventArgs e)
        {
            this.RTB_Clientes.Text = "Clientes:\n" + this.New_Mongodb_Conect.Buscar_Cliente(this.LB_Bases_de_Datos.Text, this.LB_Colecciones.Text, "");
        }
    }
}
