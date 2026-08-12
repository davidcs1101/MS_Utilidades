namespace Utilidades.Seguridad
{
    public static class CodigosPermisos
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

        public static class Acciones
        {
            public const string CONSULTAR = "ACCIONES.CONSULTAR";
            public const string CREAR = "ACCIONES.CREAR";
            public const string MODIFICAR = "ACCIONES.MODIFICAR";
            public const string ELIMINAR = "ACCIONES.ELIMINAR";
            public const string LISTAR = "ACCIONES.LISTAR";
        }

        public static class Usuarios
        {
            public const string CREARCONSEDE = "USUARIOS.CREARCONSEDE";
            public const string CREARCONGRUPO = "USUARIOS.CREARCONGRUPO";
            public const string CONSULTAR = "USUARIOS.CONSULTAR";
            public const string LISTAR = "USUARIOS.LISTAR";
        }

        public static class UsuariosSedesGrupos
        {
            public const string CREAR = "USUARIOSSEDESGRUPOS.CREAR";
            public const string MODIFICAR = "USUARIOSSEDESGRUPOS.MODIFICAR";
            public const string ELIMINAR = "USUARIOSSEDESGRUPOS.ELIMINAR";
        }

        public static class Permisos
        {
            public const string MODIFICAR = "PERMISOS.MODIFICAR";
            public const string LISTAR = "PERMISOS.LISTAR";
            public const string CONSULTAR = "PERMISOS.CONSULTAR";
        }

        public static class GruposPermisos
        {
            public const string CREAR = "GRUPOSPERMISOS.CREAR";
            public const string MODIFICAR = "GRUPOSPERMISOS.MODIFICAR";
            public const string ELIMINAR = "GRUPOSPERMISOS.ELIMINAR";
            public const string LISTAR = "GRUPOSPERMISOS.LISTAR";
        }

        public static class RecepcionEventosSeguridad
        {
            public const string CREAR = "RECEPCIONEVENTOSSEGURIDAD.CREAR";
        }
    }
}
