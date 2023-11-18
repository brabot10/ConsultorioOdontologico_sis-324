using CadConsultorioOdontologico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnConsultorioOdontologico
{
   public class MedicamentoCln
    {
        public static int insertar(Medicamento medicamento)
        {
            using (var context = new LabSis324Entities())
            {
                context.Medicamento.Add(medicamento);
                context.SaveChanges();
                return medicamento.id;
            }
        }

        public static int actualizar(Medicamento medicamento)
        {
            using (var context = new LabSis324Entities())
            {
                var existente = context.Medicamento.Find(medicamento.id);
                existente.articulo = medicamento.articulo;
                existente.descripcion = medicamento.descripcion;
                existente.precio = medicamento.precio;
                existente.estado = medicamento.estado;
                existente.usuarioRegistro = medicamento.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabSis324Entities())
            {
                var existente = context.Medicamento.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Medicamento get(int id)
        {
            using (var context = new LabSis324Entities())
            {
                return context.Medicamento.Find(id);
            }
        }

        public static List<Medicamento> listar()
        {
            using (var context = new LabSis324Entities())
            {
                return context.Medicamento.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paMedicamentoListar_Result> listarPa(string parametro4)
        {
            using (var context = new LabSis324Entities())
            {
                return context.paMedicamentoListar(parametro4).ToList();
            }
        }
    }
}
