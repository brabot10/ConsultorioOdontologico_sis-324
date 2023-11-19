using CadConsultorioOdontologico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnConsultorioOdontologico
{
    public class RegistroCln
    {
        public static int insertar(Registro registro)
        {
            using (var context = new LabSis324Entities())
            {
                context.Registro.Add(registro);
                context.SaveChanges();
                return registro.id;
            }
        }
        public static int actualizar(Registro registro)
        {
            using (var context = new LabSis324Entities())
            {
                var existente = context.Registro.Find(registro.id);
                existente.valor = registro.valor;
                existente.usuarioRegistro = registro.usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabSis324Entities())
            {
                var existente = context.Registro.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static Registro get(int id)
        {
            using (var context = new LabSis324Entities())
            {
                return context.Registro.Find(id);
            }
        }
        public static List<Registro> listar()
        {
            using (var context = new LabSis324Entities())
            {
                return context.Registro.Where(x => x.estado != -1).ToList();
            }
        }
        public static List<paRegistroListar_Result> listarPa(string parametro)
        {
            using (var context = new LabSis324Entities())
            {
                return context.paRegistroListar(parametro).ToList();
            }
        }
    }
}
