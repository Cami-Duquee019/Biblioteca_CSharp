namespace Biblioteca_C.Models;

public class Prestamo
{
    public int Id { get; set; }
    public Libro Libro { get; set; } = new();
    public Usuario Usuario { get; set; } = new();
    public DateTime FechaPrestamo { get; set; } = DateTime.Today;
    public DateTime FechaVencimiento { get; set; } = DateTime.Today.AddDays(15);
    public DateTime? FechaDevolucion { get; set; }
    public EstadoPrestamo Estado { get; set; } = EstadoPrestamo.Activo;

    public Prestamo()
    {
    }

    public Prestamo(
        int id,
        Libro libro,
        Usuario usuario,
        DateTime fechaPrestamo,
        DateTime fechaVencimiento,
        DateTime? fechaDevolucion = null,
        EstadoPrestamo estado = EstadoPrestamo.Activo)
    {
        Id = id;
        Libro = libro;
        Usuario = usuario;
        FechaPrestamo = fechaPrestamo;
        FechaVencimiento = fechaVencimiento;
        FechaDevolucion = fechaDevolucion;
        Estado = estado;
    }

    public bool EstaVencido() =>
        Estado == EstadoPrestamo.Activo &&
        FechaDevolucion is null &&
        DateTime.Today > FechaVencimiento.Date;

    public int DiasTranscurridos() => (DateTime.Today - FechaPrestamo.Date).Days;

    public string ResumenCorto() =>
        $"Préstamo [{Id}] - Libro: {Libro.Titulo} - Usuario: {Usuario.Nombre} - Estado: {Estado}";

    public string DetalleCompleto() =>
        $"Id: {Id}{Environment.NewLine}" +
        $"Libro: {Libro.Titulo}{Environment.NewLine}" +
        $"Usuario: {Usuario.Nombre}{Environment.NewLine}" +
        $"Fecha de préstamo: {FechaPrestamo:dd/MM/yyyy}{Environment.NewLine}" +
        $"Fecha de vencimiento: {FechaVencimiento:dd/MM/yyyy}{Environment.NewLine}" +
        $"Fecha de devolución: {(FechaDevolucion.HasValue ? FechaDevolucion.Value.ToString("dd/MM/yyyy") : "Pendiente")}{Environment.NewLine}" +
        $"Estado: {Estado}";

    public override string ToString() => ResumenCorto();
}
