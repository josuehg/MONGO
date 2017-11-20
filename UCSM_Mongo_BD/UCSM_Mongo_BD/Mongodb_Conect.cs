using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using System.ComponentModel;

namespace UCSM_Mongo_BD
{
    public class Mongodb_Conect
    {
        private MongoClient MongoClient_Cliente;
        private MongoServer MongoServer_Servidores;
        private MongoDatabase MongoDatabase_DB;
        private MongoCollection MongoCollection_Clientes;
        // CONSTRUCTOR
        public Mongodb_Conect()
        {
            this.MongoClient_Cliente = new MongoClient("mongodb://localhost");
            this.MongoServer_Servidores = this.MongoClient_Cliente.GetServer();
        }
        // GET BASE DATOS
        public IEnumerable<string> get_BaseDatos()
        { 
            IEnumerable<string> Lista_DB = MongoServer_Servidores.GetDatabaseNames();
            return Lista_DB;
        }
        // GET COLEECIONES
        public IEnumerable<string> get_Colleciones(string BaseDatos)
        {
            this.MongoDatabase_DB = this.MongoServer_Servidores.GetDatabase(BaseDatos);
            IEnumerable<string> Lista_Colleciones = this.MongoDatabase_DB.GetCollectionNames();
            return Lista_Colleciones;
        }
        // GET DOCUMENTOS
        public IEnumerable<string> get_Documentos(string BaseDatos)
        {
            this.MongoDatabase_DB = this.MongoServer_Servidores.GetDatabase(BaseDatos);
            IEnumerable<string> Lista_Colleciones = this.MongoDatabase_DB.GetCollectionNames();
            return Lista_Colleciones;
        }
        // INSERTAR CLIENTE
        public void Insertar_Cliente(string BaseDatos, string Nombre_Coll, string DNI, string Nombre, string Direccion, string Telefono)
        {
            this.MongoDatabase_DB = this.MongoServer_Servidores.GetDatabase(BaseDatos);
            MongoCollection_Clientes = this.MongoDatabase_DB.GetCollection<Clientes>(Nombre_Coll);
            MongoCollection_Clientes.Insert<Clientes>(new Clientes(DNI, Nombre, Direccion, Telefono));
        }
        // ACTUALIZAR CLIENTE
        public void Actualizar_Cliente(string BaseDatos, string Nombre_Coll, string DNI, string Nombre)
        {
            
        }
        // ELIMINAR CLIENTE
        public void Eliminar_Cliente(string BaseDatos, string Nombre_Coll, string Key)
        {
            this.MongoDatabase_DB = this.MongoServer_Servidores.GetDatabase(BaseDatos);
            MongoCollection_Clientes = this.MongoDatabase_DB.GetCollection<Clientes>(Nombre_Coll);
            var query = Query.EQ("DNI_Cliente", Key);
            MongoCollection_Clientes.Remove(query);
        }
        // BUSCAR CLIENTES
        public string Buscar_Cliente(string BaseDatos, string Coleccion, string Key)
        {
            string Documentos;
            this.MongoDatabase_DB = this.MongoServer_Servidores.GetDatabase(BaseDatos);
            MongoCollection_Clientes = this.MongoDatabase_DB.GetCollection<Clientes>(Coleccion);
            var Consulta_clientes = MongoCollection_Clientes.AsQueryable<Clientes>();
            var Documentos_encontrados = from DB_Clientes in Consulta_clientes
                where DB_Clientes.DNI_Cliente.Contains(Key) || DB_Clientes.Nombres_Cliente.Contains(Key) select DB_Clientes;
            Documentos = string.Empty;
            foreach (Clientes Cli in Documentos_encontrados)
                Documentos += Cli.ToJson() + "\n";
            return Documentos;
        }
        // GET ALL CLIENTES
        public List<string> Get_Clientes_Coleccion(string BaseDatos, string Coleccion)
        {
            List<string> Documentos = new List<string>();
            this.MongoDatabase_DB = this.MongoServer_Servidores.GetDatabase(BaseDatos);
            MongoCollection_Clientes = this.MongoDatabase_DB.GetCollection<Clientes>(Coleccion);
            var Consulta_clientes = MongoCollection_Clientes.AsQueryable<Clientes>();
            var Documentos_encontrados = from DB_Clientes in Consulta_clientes
                                         where DB_Clientes.DNI_Cliente.Contains("") || DB_Clientes.Nombres_Cliente.Contains("")
                                         select DB_Clientes;
            foreach (Clientes Cli in Documentos_encontrados)
                Documentos.Add("DNI: " + Cli.DNI_Cliente.ToString() + " - Nombres: " + Cli.Nombres_Cliente.ToString());
            return Documentos;
        }

    }
}
