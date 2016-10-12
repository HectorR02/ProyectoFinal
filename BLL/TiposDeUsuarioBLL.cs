using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BLL
{
    public class TiposDeUsuarioBLL
    {
        public static bool Insertar(TiposDeUsuario nuevo)
        {
            bool resultado = false;
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    conexion.TypeUsers.Add(nuevo);
                    conexion.SaveChanges();
                    resultado = true;
                }catch(Exception)
                {
                    throw;
                }
            }
            return resultado;
        }
        public static TiposDeUsuario Buscar(int TipoDeUsuarioId)
        {
            var typeUser = new TiposDeUsuario();
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    typeUser = conexion.TypeUsers.Find(TipoDeUsuarioId);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return typeUser;
        }
        public static bool Eliminar(TiposDeUsuario existente)
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
        public static List<TiposDeUsuario> GetLista()
        {
            var lista = new List<TiposDeUsuario>();
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    lista = conexion.TypeUsers.ToList();
                }catch(Exception)
                {
                    throw;
                }
            }
            return lista;
        }
    }
}
