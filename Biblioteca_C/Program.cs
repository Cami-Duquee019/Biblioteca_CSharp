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

void ShowLoansMenu()
{
    var opcion = "";
    do
    {
        Console.WriteLine("\n--------- MENÚ PRÉSTAMOS ---------");
        Console.WriteLine("3.1 Crear préstamo");
        Console.WriteLine("3.2 Listar préstamos");
        Console.WriteLine("3.3 Ver detalle de préstamo (por ID)");
        Console.WriteLine("3.4 Registrar devolución");
        Console.WriteLine("3.5 Eliminar préstamo");
        Console.WriteLine("0. Volver");
        Console.Write("Elige una opción: ");
        opcion = Console.ReadLine()?.Trim() ?? "";

        switch (opcion)
        {
            case "3.1":
                CreateLoan();
                break;
            case "3.2":
                ListLoansMenu();
                break;
            case "3.3":
                ViewLoanDetail();
                break;
            case "3.4":
                RegisterReturn();
                break;
            case "3.5":
                DeleteLoan();
                break;
            case "0":
                break;
            default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
        }
    } while (opcion != "0");
}

void ListLoansMenu()
{
    var opcion = "";
    do
    {
        Console.WriteLine("\n--------- LISTAR PRÉSTAMOS ---------");
        Console.WriteLine("3.2.1 Listar todos");
        Console.WriteLine("3.2.2 Listar activos");
        Console.WriteLine("3.2.3 Listar cerrados");
        Console.WriteLine("0. Volver");
        Console.Write("Elige una opción: ");
        opcion = Console.ReadLine()?.Trim() ?? "";

        switch (opcion)
        {
            case "3.2.1":
                ListLoansAll();
                break;
            case "3.2.2":
                ListLoansActive();
                break;
            case "3.2.3":
                ListLoansClosed();
                break;
            case "0":
                break;
            default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
        }
    } while (opcion != "0");
}

void CreateLoan()
{
    Console.WriteLine("Acción seleccionada: crear préstamo.");
    Console.WriteLine("Validaciones sugeridas: usuario activo, libro disponible, límites de préstamos y fecha de vencimiento.");
}

void ListLoansAll() => Console.WriteLine("Acción seleccionada: listar todos los préstamos.");
void ListLoansActive() => Console.WriteLine("Acción seleccionada: listar préstamos activos.");
void ListLoansClosed() => Console.WriteLine("Acción seleccionada: listar préstamos cerrados.");
void ViewLoanDetail() => Console.WriteLine("Acción seleccionada: ver detalle del préstamo por ID.");
void RegisterReturn() => Console.WriteLine("Acción seleccionada: registrar devolución, marcar préstamo devuelto y libro disponible.");
void DeleteLoan() => Console.WriteLine("Acción seleccionada: eliminar préstamo. Validar que no esté activo y conservar el historial.");

void ShowSearchReportsMenu()
{
    var opcion = "";
    do
    {
        Console.WriteLine("\n--------- BÚSQUEDAS Y REPORTES ---------");
        Console.WriteLine("4.1 Buscar libro (título/autor/ID/categoría)");
        Console.WriteLine("4.2 Buscar usuario (nombre/ID)");
        Console.WriteLine("4.3 Reportes");
        Console.WriteLine("0. Volver");
        Console.Write("Elige una opción: ");
        opcion = Console.ReadLine()?.Trim() ?? "";

        switch (opcion)
        {
            case "4.1":
                SearchBook();
                break;
            case "4.2":
                SearchUser();
                break;
            case "4.3":
                ReportsMenu();
                break;
            case "0":
                break;
            default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
        }
    } while (opcion != "0");
}

void ReportsMenu()
{
    var opcion = "";
    do
    {
        Console.WriteLine("\n--------- REPORTES ---------");
        Console.WriteLine("4.3.1 Reporte por usuario");
        Console.WriteLine("4.3.2 Reporte por libro");
        Console.WriteLine("4.3.3 Préstamos vencidos");
        Console.WriteLine("4.3.4 Resumen");
        Console.WriteLine("0. Volver");
        Console.Write("Elige una opción: ");
        opcion = Console.ReadLine()?.Trim() ?? "";

        switch (opcion)
        {
            case "4.3.1":
                ReportByUser();
                break;
            case "4.3.2":
                ReportByBook();
                break;
            case "4.3.3":
                ReportOverdue();
                break;
            case "4.3.4":
                ReportSummary();
                break;
            case "0":
                break;
            default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
        }
    } while (opcion != "0");
}

void SearchBook() => Console.WriteLine("Acción seleccionada: buscar libro por título, autor, ID o categoría.");
void SearchUser() => Console.WriteLine("Acción seleccionada: buscar usuario por nombre o ID.");
void ReportByUser() => Console.WriteLine("Acción seleccionada: generar reporte por usuario.");
void ReportByBook() => Console.WriteLine("Acción seleccionada: generar reporte por libro.");
void ReportOverdue() => Console.WriteLine("Acción seleccionada: generar reporte de préstamos vencidos.");
void ReportSummary() => Console.WriteLine("Acción seleccionada: generar resumen de la biblioteca.");

void ShowPersistenceMenu()
{
    var opcion = "";
    do
    {
        Console.WriteLine("\n--------- GUARDAR / CARGAR DATOS ---------");
        Console.WriteLine("5.1 Guardar datos");
        Console.WriteLine("5.2 Cargar datos");
        Console.WriteLine("5.3 Reiniciar datos");
        Console.WriteLine("0. Volver");
        Console.Write("Elige una opción: ");
        opcion = Console.ReadLine()?.Trim() ?? "";

        switch (opcion)
        {
            case "5.1":
                SaveData();
                break;
            case "5.2":
                LoadData();
                break;
            case "5.3":
                ConfirmResetData();
                break;
            case "0":
                break;
            default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
        }
    } while (opcion != "0");
}

void ConfirmResetData()
{
    if (ReadYesNo("¿Confirmas reiniciar los datos? (S/N): ") == "S")
    {
        ResetData();
    }
    else
    {
        Console.WriteLine("Reinicio cancelado.");
    }
}

string ReadYesNo(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        var respuesta = (Console.ReadLine() ?? "").Trim().ToUpperInvariant();
        if (respuesta is "S" or "N")
        {
            return respuesta;
        }

        Console.WriteLine("Respuesta no válida. Ingresa S o N.");
    }
}

void SaveData() => Console.WriteLine("Acción seleccionada: guardar datos (simulado, sin persistencia real).");
void LoadData() => Console.WriteLine("Acción seleccionada: cargar datos (simulado, sin persistencia real).");
void ResetData() => Console.WriteLine("Acción seleccionada: reiniciar datos (simulado, sin persistencia real).");

void ConfirmExitAndSave()
{
    if (ReadYesNo("¿Guardar antes de salir? (S/N): ") == "S")
    {
        SaveData();
    }
    else
    {
        Console.WriteLine("Saliendo sin guardar.");
    }
}

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
            case "3":
                ShowLoansMenu();
                break;
            case "4":
                ShowSearchReportsMenu();
                break;
            case "5":
                ShowPersistenceMenu();
                break;
            case "6":
                ConfirmExitAndSave();
                break;
            default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
        }
    } while (opcion != "6");
}

RunApplication();
