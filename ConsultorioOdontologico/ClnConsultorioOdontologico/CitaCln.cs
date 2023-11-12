using CadConsultorioOdontologico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnConsultorioOdontologico
{
    public class CitaCln
    {
        public static int insertar(Cita cita)
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                context.Cita.Add(cita);
                context.SaveChanges();
                return cita.id;
            }
        }
        public static int actualizar(Cita cita)
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                var existente = context.Cita.Find(cita.id);
                existente.fecha = cita.fecha;
                existente.hora = cita.hora;
                existente.tratamiento = cita.tratamiento;
                existente.pago = cita.pago;
                existente.aCuenta = cita.aCuenta;
                existente.usuarioRegistro = cita.usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                var existente = context.Cita.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static Cita get(int id)
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                return context.Cita.Find(id);
            }
        }
        public static List<Cita> Listar()
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                return context.Cita.Where(x => x.estado != -1).ToList();
            }
        }
        public static List<paCitaListar_Result> listarPa(string parametro)
        {
            using (var context = new LabConsultorioOdontologicoEntities())
            {
                return context.paCitaListar(parametro).ToList();
            }
        }
    }
}
