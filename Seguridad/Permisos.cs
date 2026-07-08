namespace Utilidades.Seguridad
{
    public static class Permisos
    {
        public static class Grupos 
        {
            public const string CONSULTAR = "GRUPOS.CONSULTAR";
            public const string CREAR = "GRUPOS.CREAR";
            public const string MODIFICAR = "GRUPOS.MODIFICAR";
            public const string ELIMINAR = "GRUPOS.ELIMINAR";
            public const string LISTAR = "GRUPOS.LISTAR";
        }

        public static class Programas
        {
            public const string CONSULTAR = "PROGRAMAS.CONSULTAR";
            public const string CREAR = "PROGRAMAS.CREAR";
            public const string MODIFICAR = "PROGRAMAS.MODIFICAR";
            public const string ELIMINAR = "PROGRAMAS.ELIMINAR";
            public const string LISTAR = "PROGRAMAS.LISTAR";
        }

        public static class Usuarios
        {
            public const string REGISTRARCONSEDE = "USUARIOS.REGISTRARCONSEDE";
            public const string CONSULTAR = "USUARIOS.CONSULTAR";
            public const string LISTAR = "USUARIOS.LISTAR";
        }

        public static class UsuariosSedesGrupos
        {
            public const string CREAR = "USUARIOSSEDESGRUPOS.CREAR";
            public const string MODIFICAR = "USUARIOSSEDESGRUPOS.MODIFICAR";
            public const string ELIMINAR = "USUARIOSSEDESGRUPOS.ELIMINAR";
        }
    }
}
