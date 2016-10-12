using ProyectoFinal.Data.Entidades;
using ProyectoFinal.Data.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ManejoDB
{
    public class ManipulacionDB
    {
        public string AddUser(Usuarios nuevo)
        {
            string resultado = "-- Operacion Fallida --";
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    conexion.User.Add(nuevo);
                    conexion.SaveChanges();
                    resultado = "-- Operacion Exitiosa --";
                }catch(Exception e)
                {
                    resultado += e.ToString();
                }
            }
            return resultado;
        }
        public Usuarios SearchUser(int Id)
        {
            var usuario = new Usuarios();
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    usuario = conexion.User.Where(x => x.Id == Id).SingleOrDefault();
                }catch(Exception e)
                {
                    MessageBox.Show("-- Operacion Fallida --\n"+e.ToString());
                    return null;
                }
            }
            return usuario;
        }
        public List<Usuarios> UsersList()
        {
            var userList = new List<Usuarios>();
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    return conexion.User.ToList();
                }
                catch (Exception e)
                {
                    MessageBox.Show("-- Operacion Fallida --\n" + e.ToString());
                    return null;
                }
            }
        }
        public string DeleteUser(Usuarios existente)
        {
            string resultado = "-- Operacion Fallida --";
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    conexion.Entry(existente).State = EntityState.Deleted;
                    conexion.SaveChanges();
                    resultado = "-- Operacion Exitosa --";
                }catch(Exception e)
                {
                   resultado = "-- Operacion Fallida --\n" + e.ToString();
                }
            }
            return resultado;
        }
        public string UserUpdate(Usuarios existente)
        {
            string resultado = "-- Operacion Fallida --";
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    conexion.Entry(existente).State = EntityState.Modified;
                    conexion.SaveChanges();
                    resultado = "-- Operacion Exitosa --";
                }catch(Exception e)
                {
                    resultado += e.ToString();
                }
            }
            return resultado;
        }

        public string AddTypeUser(TipoDeUsuario nuevo)
        {
            string resultado = "-- Operacion Fallida --";
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    conexion.TypeUser.Add(nuevo);
                    conexion.SaveChanges();
                    resultado = "-- Operacion Exitosa --";
                }catch(Exception e)
                {
                    resultado += e.ToString();
                }
            }
            return resultado;
        }
        public TipoDeUsuario SearchTypeUser(int Id)
        {
            var typeUser = new TipoDeUsuario();
            using (var Conexion = new FinalProyectDB())
            {
                try
                {
                   typeUser = Conexion.TypeUser.Where(x => x.Id == Id).SingleOrDefault();
                }catch(Exception e)
                {
                    MessageBox.Show("-- Operacion Fallida --\n" + e.ToString());
                    return null;
                }
            }
            return typeUser;
        }
        public List<TipoDeUsuario> TypeUserList()
        {
            var listTypeUser = new List<TipoDeUsuario>();
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    listTypeUser = conexion.TypeUser.ToList();
                }catch(Exception e)
                {
                    MessageBox.Show("-- Operacion Fallida --\n" + e.ToString());
                    return null;
                }
            }
            return listTypeUser;
        }
        public string DeleteTypeUser(TipoDeUsuario existente)
        {
            string resultado = "-- Operacion Fallida --\n";
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    conexion.Entry(existente).State = EntityState.Deleted;
                    resultado = "-- Operacion Exitosa --";
                }catch(Exception e)
                {
                    resultado += e.ToString();
                }
            }
            return resultado;
        }
        public string TypeUserUpdate(TipoDeUsuario existente)
        {
            string resultado = "-- Operacion Fallida --";
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    conexion.Entry(existente).State = EntityState.Modified;
                    resultado = "-- Operacion Exitosa --";
                }catch(Exception e)
                {
                    resultado += e.ToString();
                }
            }
            return resultado;
        }

        public string AddEmploye(Empleado nuevo)
        {
            string resultado = "-- Operacion Fallido --";
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    conexion.Employe.Add(nuevo);
                    conexion.SaveChanges();
                    resultado = "-- Operacion Existosa --";
                }catch(Exception e)
                {
                    resultado += e.ToString();
                }
            }
            return resultado;
        }
        public Empleado SearchEmploye(int Id)
        {
            var empleado = new Empleado();
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    conexion.Employe.Where(x => x.Id == Id).SingleOrDefault();
                }catch(Exception e)
                {
                    MessageBox.Show("-- Operacion Fallida --\n" + e.ToString());
                }
            }
            return empleado;
        }
        public List<Empleado> EmployeList()
        {
            var listado = new List<Empleado>();
            using (var conexion = new FinalProyectDB())
            {
                try
                {
                    listado = conexion.Employe.ToList();
                }catch(Exception e)
                {
                    MessageBox.Show("-- Operacion Fallida --" + e.ToString());
                }
            }
            return listado;
        }
        public string DeleteEmploye(Empleado existente)
        {
            string resultado = "-- Operacion Fallida --\n";
            using(var conexion = new FinalProyectDB())
            {
                try
                {
                    conexion.Entry(existente).State = EntityState.Deleted;
                    conexion.SaveChanges();
                    resultado = "-- Operacion Exitosa --";
                }catch(Exception e)
                {
                    MessageBox.Show(resultado+)
                }
            }
        }
    }
}
