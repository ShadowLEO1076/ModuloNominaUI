using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        string cedula = "1724805674";
        string contraseña = "Admin1234";
        string nombre = "Nombre del Usuario"; // Cambia esto
        string rol = "Administrador"; // Cambia esto

        // Generar hash SHA256 (32 bytes)
        byte[] hash = SHA256.HashData(Encoding.UTF8.GetBytes(contraseña));
        string hashHex = BitConverter.ToString(hash).Replace("-", "");

        // Generar sentencia SQL
        string sql = $@"
        INSERT INTO Usuarios (Nombre, Cedula, Contraseña, Rol, FechaRegistro)
        VALUES (
            '{nombre}',
            '{cedula}',
            0x{hashHex}, -- Hash de 'Admin1234'
            '{rol}',
            GETDATE()
        );";

        Console.WriteLine("-- Ejecuta este SQL en tu base de datos:");
        Console.WriteLine(sql);
    }
}