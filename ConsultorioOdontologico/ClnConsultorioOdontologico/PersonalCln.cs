using CadConsultorioOdontologico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnConsultorioOdontologico
{
    public class PersonalCln
    {
        public static int insertar(Personal personal)
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                context.Personal.Add(personal);
                context.SaveChanges();
                return personal.id;
            }
        }

        public static int actualizar(Personal personal)
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                var existente = context.Personal.Find(personal.id);
                existente.cedulaIdentidad = personal.cedulaIdentidad;
                existente.nombres = personal.nombres;
                existente.primerApellido = personal.primerApellido;
                existente.segundoApellido = personal.segundoApellido;
                existente.direccion = personal.direccion;
                existente.celular = personal.celular;
                existente.cargo = personal.cargo;
                existente.usuarioRegistro = personal.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                var existente = context.Personal.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Personal get(int id)
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                return context.Personal.Find(id);
            }
        }

        public static List<Personal> listar()
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                return context.Personal.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paPersonalListar_Result> listarPa(string parametro1)
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                return context.paPersonalListar(parametro1).ToList();
            }
        }
    }
}
