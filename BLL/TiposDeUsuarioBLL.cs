using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace BLL
{
    public class TiposDeUsuarioBLL
    {
        public static bool Insertar(TiposDeUsuario nuevo)
        {
            bool resultado = false;
            using (var conexion = new ProyectoFinalDataBase())
            {
                try
                {
                    conexion.TipoDeUsuario.Add(nuevo);
                    conexion.SaveChanges();
                    resultado = true;
                }catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            return resultado;
        }
        public static TiposDeUsuario Buscar(int TipoDeUsuarioId)
        {
            var typeUser = new TiposDeUsuario();
            using (var conexion = new ProyectoFinalDataBase())
            {
                try
                {
                    typeUser = conexion.TipoDeUsuario.Find(TipoDeUsuarioId);
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
        public static List<TiposDeUsuario> GetLista()
        {
            var lista = new List<TiposDeUsuario>();
            using (var conexion = new ProyectoFinalDataBase())
            {
                try
                {
                    lista = conexion.TipoDeUsuario.ToList();
                }catch(Exception)
                {
                    throw;
                }
            }
            return lista;
        }
    }
}
