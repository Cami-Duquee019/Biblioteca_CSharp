namespace Biblioteca_C.Models;

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Documento { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public bool Activo { get; set; } = true;

    public Usuario()
    {
    }

    public Usuario(
        int id,
        string nombre,
        string documento,
        string correo,
        string telefono,
        bool activo = true)
    {
        Id = id;
        Nombre = nombre;
        Documento = documento;
        Correo = correo;
        Telefono = telefono;
        Activo = activo;
    }

    public string ResumenCorto() =>
        $"[{Id}] {Nombre} - {(Activo ? "Activo" : "Inactivo")}";

    public string DetalleCompleto() =>
        $"Id: {Id}{Environment.NewLine}" +
        $"Nombre: {Nombre}{Environment.NewLine}" +
        $"Documento: {Documento}{Environment.NewLine}" +
        $"Correo: {Correo}{Environment.NewLine}" +
        $"Teléfono: {Telefono}{Environment.NewLine}" +
        $"Activo: {(Activo ? "Sí" : "No")}";

    public override string ToString() => ResumenCorto();
}
