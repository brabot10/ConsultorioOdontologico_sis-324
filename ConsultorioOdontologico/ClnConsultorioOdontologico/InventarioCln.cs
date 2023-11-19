using CadConsultorioOdontologico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnConsultorioOdontologico
{
    public class InventarioCln
    {
        public static int insertar(Inventario inventario)
        {
            using (var context = new LabSis324Entities())
            {
                context.Inventario.Add(inventario);
                context.SaveChanges();
                return inventario.id;
            }
        }
        public static int actualizar(Inventario inventario)
        {
            using (var context = new LabSis324Entities())
            {
                var existente = context.Inventario.Find(inventario.id);
                existente.articulo = inventario.articulo;
                existente.precio = inventario.precio;
                existente.usuarioRegistro = inventario.usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabSis324Entities())
            {
                var existente = context.Inventario.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static Inventario get(int id)
        {
            using (var context = new LabSis324Entities())
            {
                return context.Inventario.Find(id);
            }
        }
        public static List<Inventario> Listar()
        {
            using (var context = new LabSis324Entities())
            {
                return context.Inventario.Where(x => x.estado != -1).ToList();
            }
        }
        public static List<paInventarioListar_Result> listarPa(string parametro)
        {
            using (var context = new LabSis324Entities())
            {
                return context.paInventarioListar(parametro).ToList();
            }
        }
    }
}
