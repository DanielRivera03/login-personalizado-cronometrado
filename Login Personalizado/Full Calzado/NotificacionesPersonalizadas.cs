/*
 ------------------------------------------------------------------------
 |  LOGIN / INICIO DE SESION 3 INTENTOS, CONTROLADO POR TEMPORIZADOR    |
 |-----------------------------------------------------------------------
 | Pequeña descripción: Login desarrollado que permite solamente tres   |
 | intentos, si el usuario sobrepasa el número de intentos permitidos   |
 | la aplicación se bloquea por 50 segundos, y transcurrido ese tiempo  |
 | podrá intentar ingresar nuevamente. Se añadieron mensajes nuevos     |
 | mensajes personalizados de notificaciones, en el cual usted es libre |
 | de modificarlos según sus necesidades.                               |
 |-----------------------------------------------------------------------
 | Proyecto compartido con fines académicos.                            |
 | © Copyright 2020 Daniel Rivera.                                      |                                        
 | https://github.com/DanielRivera03                                    |
 | Créditos icono robot: https://www.pngwing.com/es/free-png-nvjtw      |
 |-----------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Full_Calzado
{
    class NotificacionesPersonalizadas
    {
        // CREANDO EVENTO DE SONIDO
        SoundPlayer Notificaciones;

        // INSTANCIA CONTROLADOR DE RUTA
        ControlRutaNotificaciones ControladorRutas = new ControlRutaNotificaciones();

        // NOTIFICACION PERSONALIZADA DE ERRORES
        public void NotificionError()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "Error.wav");
            Notificaciones.Play();
        }

        // NOTIFICACION PERSONALIZADA DE ADVERTENCIAS
        public void NotificionAdvertencia()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "Advertencia.wav");
            Notificaciones.Play();
        }

        // NOTIFICACION PERSONALIZADA DE CONFIRMACION
        public void NotificionConfirmacion()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "Aprobacion.wav");
            Notificaciones.Play();
        }

        // NOTIFICACION PERSONALIZADA DE ERROR DUPLICADOS
        public void NotificionErrorDuplicado()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "ErrorDuplicados.wav");
            Notificaciones.Play();
        }

        // NOTIFICACION PERSONALIZADA DE ERROR LIMPIEZA NO COMPLETADA
        public void NotificionErrorLimpieza()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "ErrorLimpieza.wav");
            Notificaciones.Play();
        }

        // NOTIFICACION PERSONALIZADA DE ERROR ELIMINAR REGISTROS
        public void NotificionErrorDepurarRegistros()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "ErrorEliminar.wav");
            Notificaciones.Play();
        }

        // NOTIFICACION PERSONALIZADA DE INCOGNITA PROCESOS
        public void NotificionIncognita()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "ConsultaMensajes.wav");
            Notificaciones.Play();
        }
        // NOTIFICACION PERSONALIZADA DE EXPORTAR ARCHIVOS
        public void NotificionExportar()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "ExportarArchivo.wav");
            Notificaciones.Play();
        }
        public void IniciarSesion()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "Iniciar-Sesion.wav");
            Notificaciones.Play();
        }
    }
}
