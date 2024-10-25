using System.Transactions;
using DAL;
using Entity;

namespace BLL
{
    public class TareaBLL
    {
        private readonly TareaDAL _tareaDal;
        private List<Tarea> _tareasEnMemoria = new List<Tarea>();

        public TareaBLL()
        {
            _tareaDal = new TareaDAL();
        }

        public List<Tarea> ObtenerTareasPorEmpleado(int empleadoId)
        {
            if (empleadoId <= 0)
                throw new ArgumentException("ID de empleado inválido.");

            try
            {
                return _tareaDal.ObtenerTareasPorEmpleado(empleadoId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las tareas del empleado: " + ex.Message);
            }
        }

        public void GuardarTareaEnMemoria(Tarea tarea)
        {
            // Validar que la fecha sea actual o futura
            if (tarea.FechaEsperadaFinalizacion < DateTime.Now.Date)
            {
                throw new ArgumentException("La fecha límite debe ser la actual o una posterior.");
            }

            _tareasEnMemoria.Add(tarea);
        }

        public void ConfirmarTareas()
        {
            // Validar todas las fechas antes de confirmar
            foreach (var tarea in _tareasEnMemoria)
            {
                if (tarea.FechaEsperadaFinalizacion < DateTime.Now.Date)
                {
                    throw new Exception($"Error: La tarea '{tarea.Titulo}' tiene una fecha anterior a la actual. Ninguna tarea ha sido confirmada.");
                }
            }

            using (TransactionScope transaction = new TransactionScope())
            {
                foreach (var tarea in _tareasEnMemoria)
                {
                    _tareaDal.AsignarTarea(tarea.UsuarioId, tarea.Titulo, tarea.Descripcion, tarea.FechaEsperadaFinalizacion);
                }
                transaction.Complete();
            }
            _tareasEnMemoria.Clear();
        }

        public void AsignarTarea(int empleadoId, string titulo, string descripcion, DateTime fechaLimite)
        {
            if (empleadoId <= 0)
                throw new ArgumentException("El ID del empleado no es válido.");

            if (string.IsNullOrEmpty(titulo))
                throw new ArgumentException("El título no puede estar vacío.");

            if (string.IsNullOrEmpty(descripcion))
                throw new ArgumentException("La descripción no puede estar vacía.");

            if (fechaLimite < DateTime.Now.Date)
                throw new ArgumentException("La fecha límite debe ser la actual o una posterior.");

            try
            {
                var tarea = new Tarea
                {
                    UsuarioId = empleadoId,
                    Titulo = titulo,
                    Descripcion = descripcion,
                    FechaEsperadaFinalizacion = fechaLimite
                };

                GuardarTareaEnMemoria(tarea);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al asignar tarea: " + ex.Message);
            }
        }

        public List<Tarea> ObtenerTareasPorSector(int sectorId)
        {
            if (sectorId <= 0)
                throw new ArgumentException("El ID del sector no es válido.");

            try
            {
                return _tareaDal.ObtenerTareasPorSector(sectorId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las tareas del sector: " + ex.Message);
            }
        }

        public void CompletarTarea(int tareaId)
        {
            if (tareaId <= 0)
                throw new ArgumentException("El ID de la tarea no es válido.");

            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    _tareaDal.CompletarTarea(tareaId);
                    transaction.Complete(); // Completa la transacción si no hay errores
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al completar la tarea: " + ex.Message);
                }
            }
        }

    }
}
