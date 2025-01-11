using log4net;
namespace Utilidades
{
    public static class Logs
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(Logs));
        public static void EscribirLog(string tipoLog, string mensajeLog, Exception? e = null)
        {
            if (_log.IsDebugEnabled)
            {
                if (e != null) 
                {
                    mensajeLog = mensajeLog + " _ Stack completo: " + e;
                }
                switch (tipoLog)
                {
                    case "e":
                        _log.Error(mensajeLog); break;
                    case "i":
                        _log.Info(mensajeLog); break;
                    case "w":
                        _log.Warn(mensajeLog); break;
                    default: break;
                }
            }
        }
    }
}
