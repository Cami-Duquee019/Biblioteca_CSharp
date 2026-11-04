using System;

void ShowMainMenu()
{
    Console.WriteLine("\n--------- MENÚ PRINCIPAL ---------");
    Console.WriteLine("1. Libros");
    Console.WriteLine("2. Usuarios");
    Console.WriteLine("3. Préstamos");
    Console.WriteLine("4. Búsquedas y reportes");
    Console.WriteLine("5. Guardar / Cargar datos");
    Console.WriteLine("6. Salir");
}

void ShowBooksMenu()
{
    var opcion = "";
    do
    {
        Console.WriteLine("\n--------- MENÚ LIBROS ---------");
        Console.WriteLine("1.1 Registrar libro");
        Console.WriteLine("1.2 Listar libros");
        Console.WriteLine("1.3 Ver detalle (por ID/ISBN)");
        Console.WriteLine("1.4 Actualizar libro");
        Console.WriteLine("1.5 Eliminar libro");
        Console.WriteLine("0. Volver");
        Console.Write("Elige una opción: ");
        opcion = Console.ReadLine()?.Trim() ?? "";

        switch (opcion)
        {
            case "1.1":
                RegisterBook();
                break;
            case "1.2":
                ListBooksMenu();
                break;
            case "1.3":
                ViewBookDetail();
                break;
            case "1.4":
                UpdateBookMenu();
                break;
            case "1.5":
                DeleteBook();
                break;
            case "0":
                break;
            default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
        }
    } while (opcion != "0");
}

void ListBooksMenu()
{
    var opcion = "";
    do
    {
        Console.WriteLine("\n--------- LISTAR LIBROS ---------");
        Console.WriteLine("1.2.1 Listar todos");
        Console.WriteLine("1.2.2 Listar disponibles");
        Console.WriteLine("1.2.3 Listar prestados");
        Console.WriteLine("0. Volver");
        Console.Write("Elige una opción: ");
        opcion = Console.ReadLine()?.Trim() ?? "";

        switch (opcion)
        {
            case "1.2.1":
                ListBooksAll();
                break;
            case "1.2.2":
                ListBooksAvailable();
                break;
            case "1.2.3":
                ListBooksBorrowed();
                break;
            case "0":
                break;
            default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
        }
    } while (opcion != "0");
}

void UpdateBookMenu()
{
    var opcion = "";
    do
    {
        Console.WriteLine("\n--------- ACTUALIZAR LIBRO ---------");
        Console.WriteLine("1.4.1 Editar título");
        Console.WriteLine("1.4.2 Editar autor");
        Console.WriteLine("1.4.3 Editar año / categoría");
        Console.WriteLine("0. Volver");
        Console.Write("Elige una opción: ");
        opcion = Console.ReadLine()?.Trim() ?? "";

        switch (opcion)
        {
            case "1.4.1":
                EditBookTitle();
                break;
            case "1.4.2":
                EditBookAuthor();
                break;
            case "1.4.3":
                EditBookYearCategory();
                break;
            case "0":
                break;
            default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
        }
    } while (opcion != "0");
}

void RegisterBook() => Console.WriteLine("Acción seleccionada: registrar libro.");
void ListBooksAll() => Console.WriteLine("Acción seleccionada: listar todos los libros.");
void ListBooksAvailable() => Console.WriteLine("Acción seleccionada: listar libros disponibles.");
void ListBooksBorrowed() => Console.WriteLine("Acción seleccionada: listar libros prestados.");
void ViewBookDetail() => Console.WriteLine("Acción seleccionada: ver detalle del libro por ID/ISBN.");
void EditBookTitle() => Console.WriteLine("Acción seleccionada: editar título del libro.");
void EditBookAuthor() => Console.WriteLine("Acción seleccionada: editar autor del libro.");
void EditBookYearCategory() => Console.WriteLine("Acción seleccionada: editar año/categoría del libro.");
void DeleteBook() => Console.WriteLine("Acción seleccionada: eliminar libro. Validar no permitir si está prestado.");

void ShowUsersMenu()
{
    var opcion = "";
    do
    {
        Console.WriteLine("\n--------- MENÚ USUARIOS ---------");
        Console.WriteLine("2.1 Registrar usuario");
        Console.WriteLine("2.2 Listar usuarios");
        Console.WriteLine("2.3 Ver detalle (por ID/documento)");
        Console.WriteLine("2.4 Actualizar usuario");
        Console.WriteLine("2.5 Eliminar usuario");
        Console.WriteLine("0. Volver");
        Console.Write("Elige una opción: ");
        opcion = Console.ReadLine()?.Trim() ?? "";

        switch (opcion)
        {
            case "2.1":
                RegisterUser();
                break;
            case "2.2":
                ListUsers();
                break;
            case "2.3":
                ViewUserDetail();
                break;
            case "2.4":
                UpdateUserMenu();
                break;
            case "2.5":
                DeleteUser();
                break;
            case "0":
                break;
            default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
        }
    } while (opcion != "0");
}

void UpdateUserMenu()
{
    var opcion = "";
    do
    {
        Console.WriteLine("\n--------- ACTUALIZAR USUARIO ---------");
        Console.WriteLine("2.4.1 Editar nombre");
        Console.WriteLine("2.4.2 Editar contacto");
        Console.WriteLine("2.4.3 Activar / desactivar");
        Console.WriteLine("0. Volver");
        Console.Write("Elige una opción: ");
        opcion = Console.ReadLine()?.Trim() ?? "";

        switch (opcion)
        {
            case "2.4.1":
                EditUserName();
                break;
            case "2.4.2":
                EditUserContact();
                break;
            case "2.4.3":
                ToggleUserActiveStatus();
                break;
            case "0":
                break;
            default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
        }
    } while (opcion != "0");
}

void RegisterUser() => Console.WriteLine("Acción seleccionada: registrar usuario.");
void ListUsers() => Console.WriteLine("Acción seleccionada: listar usuarios.");
void ViewUserDetail() => Console.WriteLine("Acción seleccionada: ver detalle del usuario por ID/documento.");
void EditUserName() => Console.WriteLine("Acción seleccionada: editar nombre del usuario.");
void EditUserContact() => Console.WriteLine("Acción seleccionada: editar contacto del usuario.");
void ToggleUserActiveStatus() => Console.WriteLine("Acción seleccionada: activar/desactivar usuario.");
void DeleteUser() => Console.WriteLine("Acción seleccionada: eliminar usuario. Validar no permitir si tiene préstamos activos.");

void RunApplication()
{
    var opcion = "";
    do
    {
        ShowMainMenu();
        Console.Write("Elige una opción del menú: ");
        opcion = Console.ReadLine()?.Trim() ?? "";

        switch (opcion)
        {
            case "1":
                ShowBooksMenu();
                break;
            case "2":
                ShowUsersMenu();
                break;
            case "6":
                break;
            default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
        }
    } while (opcion != "6");
}

RunApplication();
