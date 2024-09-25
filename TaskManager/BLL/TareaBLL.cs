
public class TareaBLL
{
    private readonly TareaDAL _tareaDal;

    public TareaBLL()
    {
        _tareaDal = new TareaDAL();
    }

    // Validar y obtener tareas por empleado (para empleado)
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

    // Validar y asignar una tarea a un empleado (para jefe de sector)
    public void AsignarTarea(int empleadoId, string titulo, string descripcion, DateTime fechaLimite)
    {
        // Validaciones
        if (empleadoId <= 0)
            throw new ArgumentException("El ID del empleado no es válido.");

        if (string.IsNullOrEmpty(titulo))
            throw new ArgumentException("El título no puede estar vacío.");

        if (string.IsNullOrEmpty(descripcion))
            throw new ArgumentException("La descripción no puede estar vacía.");

        if (fechaLimite <= DateTime.Now)
            throw new ArgumentException("La fecha límite debe ser posterior a la fecha actual.");

        try
        {
            _tareaDal.AsignarTarea(empleadoId, titulo, descripcion, fechaLimite);
        }
        catch (Exception ex)
        {
            throw new Exception("Error al asignar tarea: " + ex.Message);
        }
    }

    // Obtener tareas por sector (para jefe de sector)
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

    // Completar tarea 
    public void CompletarTarea(int tareaId)
    {
        if (tareaId <= 0)
            throw new ArgumentException("El ID de la tarea no es válido.");

        try
        {
            _tareaDal.CompletarTarea(tareaId);
        }
        catch (Exception ex)
        {
            throw new Exception("Error al completar la tarea: " + ex.Message);
        }
    }
}
