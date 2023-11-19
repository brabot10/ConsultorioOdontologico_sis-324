using CadConsultorioOdontologico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnConsultorioOdontologico
{
    public class HorarioCln
    {
        public static int insertar(Horario horario)
        {
            using (var context = new LabSis324Entities())
            {
                context.Horario.Add(horario);
                context.SaveChanges();
                return horario.id;
            }
        }
        public static int actualizar(Horario horario)
        {
            using (var context = new LabSis324Entities())
            {
                var existente = context.Horario.Find(horario.id);
                existente.lunes = horario.lunes;
                existente.martes = horario.martes;
                existente.miercoles = horario.miercoles;
                existente.jueves = horario.jueves;
                existente.viernes = horario.viernes;
                existente.sabado = horario.sabado;
                existente.mes = horario.mes;
                existente.permiso = horario.permiso;
                existente.usuarioRegistro = horario.usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabSis324Entities())
            {
                var existente = context.Horario.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static Horario get(int id)
        {
            using (var context = new LabSis324Entities())
            {
                return context.Horario.Find(id);
            }
        }
        public static List<Horario> Listar()
        {
            using (var context = new LabSis324Entities())
            {
                return context.Horario.Where(x => x.estado != -1).ToList();
            }
        }
        public static List<paHorarioListar_Result> listarPa(string parametro)
        {
            using (var context = new LabSis324Entities())
            {
                return context.paHorarioListar(parametro).ToList();
            }
        }
    }
}
