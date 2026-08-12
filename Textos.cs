namespace Utilidades
{
    public static class Textos
    {
        public static class Generales
        {
            public const string MENSAJE_ERROR_SERVIDOR = "Error inesperado en el servidor.";
            public const string MENSAJE_REGISTRO_ACTUALIZADO = "La actualización se ha realizado correctamente.";
            public const string MENSAJE_REGISTRO_CREADO = "El registro se ha creado correctamente.";
            public const string MENSAJE_REGISTRO_ELIMINADO = "El registro se ha eliminado correctamente.";
            public const string MENSAJE_REGISTRO_NO_ELIMINADO = "El proceso de eliminación no retornó filas afectadas, no se eliminó el registro.";
            public const string MENSAJE_NO_EXISTE_ID = "No existe un registro con el Id indicado.";
            public const string MENSAJE_CORREO_ENVIADO_OK = "La notificación de se ha enviado correctamente.";
            public const string MENSAJE_CORREO_ENVIADO_ERROR = "No se ha podido enviar la notificación de correo electrónico.";
            public const string MENSAJE_CORREO_CONFIGURACION_ERROR = "Todos los datos de configuración de correo electrónico deben estar diligenciados en AppSettings.";
            public const string MENSAJE_CORREO_ADJUNTOS_ERROR = "Error al procesar datos adjuntos del correo.";
            public const string MENSAJE_ERROR_CONSUMO_SERVICIO = "Error al consumir el servicio.";
            public const string MENSAJE_TOKEN_SIN_USUARIOID = "No se encontró el 'UsuarioId' en el token JWT.";
            public const string MENSAJE_TOKEN_SIN_GRUPO = "No se encontró el 'CodigoGrupo' en el token JWT.";

            public const string VALIDA_CAMPO_OBLIGATORIO = "El dato es obligatorio.";
            public const string VALIDA_VALOR_EXCEDE_LONGITUD = "El valor ingresado supera la longitud máxima permitida.";
            public const string VALIDA_CORREO_NO_VALIDO = "El correo electrónico no es válido.";

            public static string MENSAJE_MAESTROEXTERNO_NO_EXISTE_EN_CODIGOMAESTRO(string codigoCatalogo, string codigo)
                => $"No existe un parámetro externo con el código {codigo} en el catálogo {codigoCatalogo}.";

            public static string MENSAJE_PERMISO_NO_AUTORIZADO(string codigoPermiso, string codigoGrupo = "")
                => $"El usuario no tiene permiso para acceder al recurso solicitado. grupo: {codigoGrupo} - permiso: {codigoPermiso}";
        }



        #region REG_Mensajes del microservicio de Seguridad
        public static class Usuarios
        {
            public const string MENSAJE_LOGIN_INCORRECTO = "Usuario o contraseña inválida.";
            public const string MENSAJE_LOGIN_SEDE_INCORRECTO = "Asociación de usuario y sede no válida.";
            public const string MENSAJE_TOKEN_INCORRECTO = "El token no contiene UsuarioId válido.";
            public const string MENSAJE_TOKEN_USUARIO_INCORRECTO = "El UsuarioId del token no coincide con el UsuarioId de la solicitud.";

            public const string MENSAJE_USUARIO_NOMBRE_EXISTE = "Ya existe un registro de usuario con el mismo nombre de usuario que está intentando crear.";
            public const string MENSAJE_USUARIO_EMAIL_EXISTE = "Ya existe otro registro de usuario con el mismo email de usuario que está intentando asignar.";
            public const string MENSAJE_USUARIO_DOCUMENTO_EXISTE = "Ya existe un registro de usuario con el mismo número de documento y tipo de documento de usuario que está intentando crear.";
            public const string MENSAJE_USUARIO_NO_EXISTE_ID = "No existe un registro de usuarios con el Id indicado.";
            public const string MENSAJE_USUARIO_NO_EXISTE_NOMBRE = "No existe un registro de usuarios con el nombre de usuario indicado.";
            public const string MENSAJE_USUARIO_NO_CAMBIO_CLAVE = "El usuario no ha realizado el cambio de clave. No tienes permiso para realizar la acción.";

            public const string MENSAJE_USUARIO_AUDITORIA_NO_EXISTE_ID = "El usuario indicado en el campo de auditoría no existe (usuario que crea, actualiza, o elimina).";
            public const string MENSAJE_USUARIO_NO_TIENE_GRUPO_DIRECTO = "El usuario no cuenta con un grupo directamente asociado.";
        }

        public static class UsuariosSedesGrupos
        {
            public const string MENSAJE_USUARIOSEDEGRUPO_NO_EXISTE_ID = "No existe un registro de UsuariosSedesGrupos con el Id indicado.";
            public const string MENSAJE_USUARIOSEDEGRUPO_NO_TIENE_SEDES_ACTIVAS = "El usuario indicado no tiene sedes asociadas en estado activo.";
            public const string MENSAJE_USUARIOSEDEGRUPO_YA_TIENE_SEDE_ASOCIADA = "El usuario indicado ya se encuentra asignado a la sede.";
            public const string MENSAJE_USUARIOSEDEGRUPO_NO_EXISTE_USUARIO_SEDE = "No existe un registro de UsuariosSedesGrupos con el UsuarioId y SedeId indicado.";
        }

        public static class Grupos
        {
            public const string MENSAJE_GRUPO_NO_EXISTE_ID = "No existe un registro de grupos con el Id indicado.";
            public const string MENSAJE_GRUPO_CODIGO_EXISTE = "Ya existe un registro de grupos con el mismo código de grupo que está intentando crear.";
            public const string MENSAJE_GRUPO_NO_EXISTE_CODIGO = "No existe un registro de grupos con el código de grupo indicado.";
        }

        public static class Programas
        {
            public const string MENSAJE_PROGRAMA_NO_EXISTE_ID = "No existe un registro de programas con el Id indicado.";
            public const string MENSAJE_PROGRAMA_CODIGO_EXISTE = "Ya existe un registro de programas con el mismo código de programa que está intentando crear.";
            public const string MENSAJE_PROGRAMA_NO_EXISTE_CODIGO = "No existe un registro de programas con el código de programa indicado.";
        }

        public static class Acciones
        {
            public const string MENSAJE_ACCION_NO_EXISTE_ID = "No existe un registro de acciones con el Id indicado.";
            public const string MENSAJE_ACCION_CODIGO_EXISTE = "Ya existe un registro de acciones con el mismo código de acción que está intentando crear.";
            public const string MENSAJE_ACCION_NO_EXISTE_CODIGO = "No existe un registro de acciones con el código de acción indicado.";
        }

        public static class Permisos
        {
            public const string MENSAJE_PERMISO_NO_EXISTE_ID = "No existe un registro de permisos con el Id indicado.";
            public static string MENSAJE_PERMISO_INACTIVO(string codigo) => $"El código de permiso de usuario ({codigo}) se encuentra inactivo.";
            public static string MENSAJE_PERMISO_NO_EXISTE_CODIGO(string codigo) => $"No existe un registro de permisos con el código de permiso indicado. ({codigo})";
            public const string MENSAJE_PERMISO_CODIGO_EXISTE = "Ya existe un registro de permiso con el código programa y código de acción que está intentando crear.";
        }

        public static class GruposPermisos
        {
            public const string MENSAJE_GRUPOPERMISO_NO_EXISTE_ID = "No existe un registro de grupos permisos con el Id indicado.";
            public const string MENSAJE_GRUPOPERMISO_YA_EXISTE = "Ya existe un registro de grupos permisos con el mismo grupo y permiso que está intentando crear.";
            public const string MENSAJE_GRUPOPERMISO_NO_EXISTE_GRUPO_PERMISO = "No existe un registro de grupos permisos con el mismo grupo y permiso indicado.";
        }
        #endregion


        #region REG_Textos del microservicio DatosComunes
        public static class Listas
        {
            public const string MENSAJE_LISTA_NO_EXISTE_ID = "No existe un registro de listas con el Id indicado.";
            public const string MENSAJE_LISTA_CODIGO_EXISTE = "Ya existe un registro de listas con el mismo código de lista que está intentando crear.";
            public const string MENSAJE_LISTA_NO_EXISTE_CODIGO = "No existe un registro de listas con el código de lista indicado.";
        }

        public static class ListasDetalles
        {
            public const string MENSAJE_LISTADETALLE_NO_EXISTE_ID = "No existe un registro de listas detalles con el Id indicado.";
            public static string MENSAJE_LISTADETALLE_NO_EXISTE_EN_CODIGOLISTA(string CodigoLista, string CodigoListaDetalle) => 
                $"El código de lista detalle indicado: {CodigoListaDetalle}, no se encuentra asociado a la lista {CodigoLista}.";
            public static string MENSAJE_LISTADETALLE_NO_EXISTE_EN_CODIGOCONSTANTE(string codigoConstante, string CodigoListaDetalle) =>
                $"El código de lista detalle indicado: {CodigoListaDetalle}, no se encuentra asociado a la constante {codigoConstante}.";
            public const string MENSAJE_LISTADETALLE_CODIGO_EXISTE = "Ya existe un registro de listas detalle con el Id de lista y el código de detalle que está intentando crear.";
            public const string MENSAJE_LISTADETALLE_NO_EXISTE_CODIGO = "No existe un registro de listas detalle con el Id de lista y el código de detalle indicado.";
        }

        public static class DatosConstantes
        {
            public const string MENSAJE_DATOCONSTANTE_NO_EXISTE_ID = "No existe un registro de datos constantes con el Id indicado.";
            public const string MENSAJE_DATOCONSTANTE_CODIGO_EXISTE = "Ya existe un registro de datos constantes con el mismo código de dato constante que está intentando crear.";
            public const string MENSAJE_DATOCONSTANTE_NO_EXISTE_CODIGO = "No existe un registro de datos constantes con el código de dato constante indicado.";
            public const string MENSAJE_DATOCONSTANTE_LISTA_NO_EXISTE_CODIGO = "El Id de lista, asociado al código de dato constante indicado, no tiene asociado un registro en listas detalles con el código lista detalle indicado.";
        }

        public static class DatosConstantesDetalles
        {
            public const string MENSAJE_DATOCONSTANTEDETALLE_LISTADETALLE_YA_EXISTE = "Ya existe un registro de datos constante detalle con el Id de datos constante y el Id de listas detalle que está intentando crear.";
            public const string MENSAJE_DATOCONSTANTEDETALLE_LISTADETALLE_NO_EXISTE_ID = "No existe un registro de datos constante detalle con el Id indicado.";
        }

        #endregion


        #region REG_Textos del microservicio empresas
        public static class Empresas
        {
            public const string MENSAJE_EMPRESA_NO_EXISTE_ID = "No existe un registro de empresas con el Id indicado.";
            public const string MENSAJE_EMPRESA_DOCUMENTO_EXISTE = "Ya existe un registro de empresas con el mismo documento y tipo de identificación que está intentando crear.";
            public const string MENSAJE_EMPRESA_VERIFICADA = "La empresa se ha verificado de manera correcta.";
            public const string MENSAJE_EMPRESA_YA_VERIFICADA = "La empresa ya se encuentra verificada.";
            public const string MENSAJE_EMPRESA_EXCEDE_CANTIDAD_SEDES = "El consecutivo para la nueva sede supera la cantidad de sedes permitidas para la empresa.";
        }

        public static class Sedes
        {
            public const string MENSAJE_SEDE_NO_EXISTE_ID = "No existe un registro de sedes con el Id indicado.";
        }

        public static class SedesSalud
        {
            public const string MENSAJE_SEDESALUD_SEDE_YA_EXISTE = "Ya existe un registro de sede salud con el Id de sede que está intentando crear.";
            public const string MENSAJE_SEDESALUD_NO_EXISTE_ID = "No existe un registro de sede de salud con el Id indicado.";
            public const string MENSAJE_SEDESALUD_CODIGOHABILITACION_EXISTE = "Ya existe un registro de sede de salud con el mismo codigo de habilitación y código de sede que está intentando crear.";
        }
        #endregion


        #region REG_Textos del microservicio de Envío de Correos

        public static class Correos
        {
            public const string MENSAJE_CORREO_NO_EXISTE_ID = "No existe un registro de correo con el Id de correo y empresa indicados.";
        }

        public static class Configuraciones
        {
            public const string MENSAJE_CONFIGURACION_NO_EXISTE_ID = "No existe un registro de configuración con el Id de configuración y empresa indicados.";
            public const string MENSAJE_CONFIGURACION_CODIGO_EXISTE = "Ya existe un registro de configuración de correo en la empresa con el mismo código de configuración que está intentando crear.";
            public const string MENSAJE_CONFIGURACION_NO_EXISTE_CODIGO = "No existe un registro de configuración de correo en la empresa con el código de configuración indicado.";
            public const string MENSAJE_CONFIGURACION_INACTIVA = "El código de configuración de correo se encuentra inactiva.";
        }

        public static class Plantillas
        {
            public const string MENSAJE_PLANTILLA_NO_EXISTE_ID = "No existe un registro de plantilla con el Id de plantilla y empresa indicados.";
            public const string MENSAJE_PLANTILLA_CODIGO_EXISTE = "Ya existe un registro de plantillas de correo en la empresa con el mismo código de plantilla que está intentando crear.";
            public const string MENSAJE_PLANTILLA_NO_EXISTE_CODIGO = "No existe un registro de plantillas de correo en la empresa con el código de plantilla indicado.";
            public const string MENSAJE_PLANTILLA_INACTIVA = "El código de plantilla de correo se encuentra inactiva.";
        }

        #endregion


        #region REG_textos para procesos de las colas de solicitudes
        public static class ColasSolicitudes
        {
            //Para manejo de colas en todos los microservicios
            public const string MENSAJE_COLASOLICITUD_YA_PROCESADA = "El registro de solicitud ya fue procesado.";
            public const string MENSAJE_COLASOLICITUD_NO_EXISTE_ID = "No existe un registro de ColasSolicitudes con el Id indicado.";
            public const string MENSAJE_COLASOLICITUD_ERROR_PROCESO = "Error al procesar la cola de solicitudes.";
            public const string MENSAJE_COLASOLICITUD_ERROR_ENCOLAR_HANGFIRE = "Error al tratar de encolar en HangFire.";
        }
        #endregion



        #region REG_Caches de datos
        public static class CacheDatos 
        {
            public const string MENSAJE_CACHE_DATOSCOMUNES_INICIALIZADA = "Caché de datos comunes inicializada.";
            public const string MENSAJE_CACHE_DATOSCOMUNES_ACTUALIZADA = "Caché de datos comunes actualizada";
        }
        #endregion
    }
}
