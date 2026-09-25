namespace Utilidades.Seguridad
{
    public static class CodigosPermisos
    {
        #region REG_Permisos SEG.Seguridad
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
        #endregion


        #region REG_Permisos DCO.DatosComunes
        public static class DatosConstantes
        {
            public const string CONSULTAR = "DATOSCONSTANTES.CONSULTAR";
            public const string CREAR = "DATOSCONSTANTES.CREAR";
            public const string MODIFICAR = "DATOSCONSTANTES.MODIFICAR";
            public const string ELIMINAR = "DATOSCONSTANTES.ELIMINAR";
            public const string LISTAR = "DATOSCONSTANTES.LISTAR";
        }

        public static class DatosConstantesDetalles
        {
            public const string CREAR = "DATOSCONSTANTESDETALLES.CREAR";
            public const string MODIFICAR = "DATOSCONSTANTESDETALLES.MODIFICAR";
        }

        public static class Geografia
        {
            public const string LISTAR = "GEOGRAFIA.LISTAR";
        }

        public static class Listas
        {
            public const string CONSULTAR = "LISTAS.CONSULTAR";
            public const string CREAR = "LISTAS.CREAR";
            public const string MODIFICAR = "LISTAS.MODIFICAR";
            public const string ELIMINAR = "LISTAS.ELIMINAR";
            public const string LISTAR = "LISTAS.LISTAR";
        }

        public static class ListasDetalles 
        {
            public const string CONSULTAR = "LISTASDETALLES.CONSULTAR";
            public const string CREAR = "LISTASDETALLES.CREAR";
            public const string MODIFICAR = "LISTASDETALLES.MODIFICAR";
            public const string ELIMINAR = "LISTASDETALLES.ELIMINAR";
            public const string LISTAR = "LISTASDETALLES.LISTAR";

        }
        #endregion








        #region REG_Permisos ECO.EnvioCorreos
        public static class ConfiguracionesSmtp
        {
            public const string CREAR = "CONFIGURACIONSMTP.CREAR";
            public const string MODIFICAR = "CONFIGURACIONSMTP.MODIFICAR";
            public const string CONSULTAR = "CONFIGURACIONSMTP.CONSULTAR";
            public const string LISTAR = "CONFIGURACIONSMTP.LISTAR";
        }

        public static class PlantillasCorreo
        {
            public const string CREAR = "PLANTILLASCORREO.CREAR";
            public const string MODIFICAR = "PLANTILLASCORREO.MODIFICAR";
            public const string CONSULTAR = "PLANTILLASCORREO.CONSULTAR";
            public const string LISTAR = "PLANTILLASCORREO.LISTAR";
        }
        #endregion


        #region REG_Permisos EMP.Empresas
        public static class Empresas
        {
            public const string CREAR = "EMPRESAS.CREAR";
            public const string VERIFICAR = "EMPRESAS.VERIFICAR";//OJO NUEVA ACCION PARA VERIFICAR SI EXISTE LA EMPRESA
            public const string CONSULTAR = "EMPRESAS.CONSULTAR";
            public const string LISTAR = "EMPRESAS.LISTAR";
        }

        public static class Sedes
        {
            public const string CREAR = "SEDES.CREAR";
            public const string CONSULTAR = "SEDES.CONSULTAR";
            public const string LISTAR = "SEDES.LISTAR";
        }

        public static class SedesSalud
        {
            public const string CREAR = "SEDESSALUD.CREAR";
        }
        #endregion

    }
}
