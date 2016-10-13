using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BLL
{
    public class HuevosBLL
    {
        public static bool Insertar(Huevos nuevo)
        {
            bool resultado = false;
            using(var conexion = new ProyectoFinalDataBase())
            {
                try
                {
                    conexion.Huevo.Add(nuevo);
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
        public static Huevos Buscar(int HuevoId)
        {
            var huevo = new Huevos();
            using(var conexion = new ProyectoFinalDataBase())
            {
                try
                {
                    huevo = conexion.Huevo.Find(HuevoId);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return huevo;
        }
        public static bool Eliminar(Huevos existente)
        {
            bool resultado = false;
            using(var conexion = new ProyectoFinalDataBase())
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
        public static List<Huevos> GetLista()
        {
            var lista = new List<Huevos>();
            using (var conexion = new ProyectoFinalDataBase())
            {
                try
                {
                    lista = conexion.Huevo.ToList();
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
