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

namespace Full_Calzado
{
    class ControlRutaNotificaciones
    {
        public String RutaNotificaciones()
        {
            String ControlRutaPC = "dany__000/Desktop/Full Calzado S.A de C.V/Notificaciones/";
            return ControlRutaPC;
        }
    }
}

