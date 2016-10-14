using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BLL
{
    public class UsuariosBLL
    {
        public static bool Insertar(Usuarios nuevo)
        {
            bool resultado = false;
            using (var conexion = new ProyectoFinalDataBase())
            {
                try
                {
                    conexion.Usuario.Add(nuevo);
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
            using (var conexion = new ProyectoFinalDataBase())
            {
                try
                {
                    usuario = conexion.Usuario.Find(UsuarioId);
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
            using (var conexion = new ProyectoFinalDataBase())
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
            using (var conexion = new ProyectoFinalDataBase())
            {
                try
                {
                    lista = conexion.Usuario.ToList();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return lista;
        }

        public static Usuarios Buscar(string User)
        {
            var usuario = new Usuarios();
            using (var conexion = new ProyectoFinalDataBase())
            {
                try
                {
                    usuario = conexion.Usuario.Where(x => x.Usuario.Equals(User)).SingleOrDefault();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return usuario;
        }
    }
}
