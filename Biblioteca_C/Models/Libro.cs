namespace Biblioteca_C.Models;

public class Libro
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public string Isbn { get; set; } = string.Empty;
    public int AnioPublicacion { get; set; }
    public string Categoria { get; set; } = string.Empty;
    public bool Disponible { get; set; } = true;

    public Libro()
    {
    }

    public Libro(
        int id,
        string titulo,
        string autor,
        string isbn,
        int anioPublicacion,
        string categoria,
        bool disponible = true)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
        Isbn = isbn;
        AnioPublicacion = anioPublicacion;
        Categoria = categoria;
        Disponible = disponible;
    }

    public string ResumenCorto() =>
        $"[{Id}] {Titulo} - {Autor} ({(Disponible ? "Disponible" : "Prestado")})";

    public string DetalleCompleto() =>
        $"Id: {Id}{Environment.NewLine}" +
        $"Título: {Titulo}{Environment.NewLine}" +
        $"Autor: {Autor}{Environment.NewLine}" +
        $"ISBN: {Isbn}{Environment.NewLine}" +
        $"Año de publicación: {AnioPublicacion}{Environment.NewLine}" +
        $"Categoría: {Categoria}{Environment.NewLine}" +
        $"Disponible: {(Disponible ? "Sí" : "No")}";

    public override string ToString() => ResumenCorto();
}
