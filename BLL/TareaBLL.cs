using System;
using System.Collections.Generic;
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

        // Obtener las tareas de un empleado en especifico
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

        // Guardar tarea en memoria para despues confirmar cambios
        public void GuardarTareaEnMemoria(Tarea tarea)
        {
            // Validar campos antes de guardar
            ValidarTarea(tarea);

            // Validar que la fecha sea actual o futura
            if (tarea.FechaEsperadaFinalizacion < DateTime.Now.Date)
            {
                throw new ArgumentException("La fecha límite debe ser la actual o una posterior.");
            }

            _tareasEnMemoria.Add(tarea);
        }

        // Confirmar todas las tareas en memoria y guardarlas en la base de datos
        public void ConfirmarTareas()
        {
            foreach (var tarea in _tareasEnMemoria)
            {
                try
                {
                    ValidarTarea(tarea);

                    if (tarea.FechaEsperadaFinalizacion < DateTime.Now.Date)
                    {
                        throw new Exception($"La tarea '{tarea.Titulo}' tiene una fecha anterior a la actual.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al confirmar tareas: {ex.Message}. Ninguna tarea ha sido confirmada.");
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

        // Asignar una nueva tarea a un empleado
        public void AsignarTarea(int empleadoId, string titulo, string descripcion, DateTime fechaLimite)
        {
            if (empleadoId <= 0)
                throw new ArgumentException("El ID del empleado no es válido.");

            // Crear una instancia de tarea para validarla
            var tarea = new Tarea
            {
                UsuarioId = empleadoId,
                Titulo = titulo,
                Descripcion = descripcion,
                FechaEsperadaFinalizacion = fechaLimite
            };

            // Validar antes de guardar
            ValidarTarea(tarea);

            try
            {
                GuardarTareaEnMemoria(tarea);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al asignar tarea: " + ex.Message);
            }
        }

        // Obtener tareas por sector (Para cargar tareas en el DataGridView)
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

        // Completar una tarea
        public void CompletarTarea(int tareaId)
        {
            if (tareaId <= 0)
                throw new ArgumentException("El ID de la tarea no es válido.");

            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    _tareaDal.CompletarTarea(tareaId);
                    transaction.Complete();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al completar la tarea: " + ex.Message);
                }
            }
        }

        // Validar tarea (Título, Descripción, Fecha)
        private void ValidarTarea(Tarea tarea)
        {
            const string placeholderTitulo = "Título";
            const string placeholderDescripcion = "Tarea a realizar";

            if (string.IsNullOrWhiteSpace(tarea.Titulo) || tarea.Titulo == placeholderTitulo)
                throw new ArgumentException("El título no puede estar vacío o tener el texto predeterminado.");

            if (string.IsNullOrWhiteSpace(tarea.Descripcion) || tarea.Descripcion == placeholderDescripcion)
                throw new ArgumentException("La descripción no puede estar vacía o tener el texto predeterminado.");
        }
    }
}
