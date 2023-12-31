﻿using CadConsultorioOdontologico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnConsultorioOdontologico
{
    public class UsuarioCln
    {
        public static int insertar(Usuario usuario)
        {
            using (var context = new LabSis324Entities())
            {
                context.Usuario.Add(usuario);
                context.SaveChanges();
                return usuario.id;
            }
        }

        public static int actualizar(Usuario usuario)
        {
            using (var context = new LabSis324Entities())
            {
                var existente = context.Usuario.Find(usuario.id);
                existente.usuario1 = usuario.usuario1;
                existente.clave = usuario.clave;
                existente.usuarioRegistro = usuario.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabSis324Entities())
            {
                var existente = context.Usuario.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Usuario get(int id)
        {
            using (var context = new LabSis324Entities())
            {
                return context.Usuario.Find(id);
            }
        }

        public static List<Usuario> listar()
        {
            using (var context = new LabSis324Entities())
            {
                return context.Usuario.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paUsuarioListar_Result> listarPa(string parametro1)
        {
            using (var context = new LabSis324Entities())
            {
                return context.paUsuarioListar(parametro1).ToList();
            }
        }
        public static Usuario validar(string usuario, string clave)
        {
            using (var context = new LabSis324Entities())
            {
                return context.Usuario
                    .Where(x => x.usuario1 == usuario && x.clave == clave)
                    .FirstOrDefault();
            }
        }
    }
}
