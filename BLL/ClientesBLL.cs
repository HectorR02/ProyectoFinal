using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BLL
{
    public class ClientesBLL
    {
        public static bool Insertar(Clientes nuevo)
        {
            bool resultado = false;
            using (var conexion = new ProyectoFinalDataBase())
            {
                try
                {
                    conexion.Cliente.Add(nuevo);
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
        public static Clientes Buscar(int ClienteId)
        {
            var cliente = new Clientes();
            using (var conexion = new ProyectoFinalDataBase())
            {
                try
                {
                    cliente = conexion.Cliente.Find(ClienteId);
                }catch(Exception)
                {
                    throw;
                }
            }
            return cliente;
        }
        public static bool Eliminar(Clientes existente)
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
        public static List<Clientes> GetList()
        {
            var lista = new List<Clientes>();
            using (var conexion = new ProyectoFinalDataBase())
            {
                try
                {
                    lista = conexion.Cliente.ToList();
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
