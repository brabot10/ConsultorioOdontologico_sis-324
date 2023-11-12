using CadConsultorioOdontologico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnConsultorioOdontologico
{
    public class PacienteCln
    {
        public static int insertar(Paciente paciente)
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                context.Paciente.Add(paciente);
                context.SaveChanges();
                return paciente.id;
            }
        }

        public static int actualizar(Paciente paciente)
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                var existente = context.Paciente.Find(paciente.id);
                existente.nombres = paciente.nombres;
                existente.cedulaIdentidad = paciente.cedulaIdentidad;
                existente.alergias = paciente.alergias;
                existente.fechaNacimiento = paciente.fechaNacimiento;
                existente.celular = paciente.celular;
                existente.usuarioRegistro = paciente.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                var existente = context.Paciente.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Paciente get(int id)
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                return context.Paciente.Find(id);
            }
        }

        public static List<Paciente> listar()
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                return context.Paciente.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paPacienteListar_Result> listarPa(string parametro)
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                return context.paPacienteListar(parametro).ToList();
            }
        }
    }
}
