using System;
using MongoDB.Bson;
using System.ComponentModel;

namespace UCSM_Mongo_BD
{
    public class Clientes
    {
        public ObjectId _id;
        public string DNI_Cliente;
        public string Nombres_Cliente;
        public string Direccion_Cliente;
        public string Telefono_Cliente;

        public Clientes()
        { }
        public Clientes(string DNI_Cliente, string Nombres_Cliente, string Direccion_Cliente, string Telefono_Cliente)
        {
            this.DNI_Cliente = DNI_Cliente;
            this.Nombres_Cliente = Nombres_Cliente;
            this.Direccion_Cliente = Direccion_Cliente;
            this.Telefono_Cliente = Telefono_Cliente;
        }

    }
}
