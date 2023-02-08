using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();
        public string nombre { get; set; }
        public string desc { get; set; }
        public string marca { get; set; }
        public string precio { get; set; }
        public string stock { get; set; }
        public int id { get; set; }
        public DataTable MostrarProd() {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPRod ( string nombre,string desc,string marca,string precio, string stock){

            objetoCD.Insertar(nombre,desc,marca,Convert.ToDouble(precio),Convert.ToInt32(stock));
    }

        public void EditarProd(string nombre, string desc, string marca, string precio, string stock,string id)
        {
            objetoCD.Editar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock),Convert.ToInt32(id));
        }

        public void EliminarPRod(string id) {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

        public void ConsultarProd (string id)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Consultar(Convert.ToInt32(id));


            foreach (DataRow dr in tabla.Rows)
            {
              
                id = dr[0].ToString();
                nombre = dr[1].ToString();
                desc = dr[2].ToString();
                marca = dr[3].ToString();
                precio = dr[4].ToString();
                stock = dr[5].ToString();
            }

        }

    }
}
