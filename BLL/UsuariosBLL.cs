using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuariosBLL
    {
        public static bool Insertar(Usuarios nuevo)
        {
            bool resultado = false;
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    conexion.Users.Add(nuevo);
                    conexion.SaveChanges();
                    resultado = true;
                }catch(Exception)
                {
                    throw;
                }
            }
            return resultado;
        }
        public static Usuarios Buscar(int UsuarioId)
        {
            var usuario = new Usuarios();
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    usuario = conexion.Users.Find(UsuarioId);
                }catch(Exception)
                {
                    throw;
                }
            }
            return usuario;
        }
        public static bool Eliminar(Usuarios existente)
        {
            bool resultado = false;
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    conexion.Entry(existente).State = EntityState.Deleted;
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return resultado;
        }
        public static List<Usuarios> GetList()
        {
            var lista = new List<Usuarios>();
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    lista = conexion.Users.ToList();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return lista;
        }
    }
}
