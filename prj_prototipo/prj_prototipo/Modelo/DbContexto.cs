using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace prj_prototipo.Modelo
{
    public class DbContexto
    {
        private readonly SQLiteAsyncConnection cnx;
        // Constructor
        public DbContexto(string ruta)
        {
            cnx = new SQLiteAsyncConnection(ruta);
            // Crear la tabla
            cnx.CreateTableAsync<Terminal>().Wait();
        }
        //Ingresar reg (datos del un formulario xaml)
        public async Task<int> ingresar(Terminal reg)
        {
            return await cnx.InsertAsync(reg);
        }

        public async Task<int> eliminar(int id)
        {
            return await cnx.DeleteAsync(id);
        }
    }
}
