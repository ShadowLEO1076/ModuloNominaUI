// En WinModuloNomina/Modelo/UsuarioSesion.cs

public static class UsuarioSesion
{
    public static string Cedula { get; set; }
    public static string Rol { get; set; }
    public static bool EsAdministrador => Cedula == "1724805674";
    public static void CerrarSesion()
    {
        Cedula = null;
        Rol = null;
    }
}