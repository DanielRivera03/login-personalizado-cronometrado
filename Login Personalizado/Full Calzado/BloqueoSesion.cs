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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_Calzado
{
    public partial class BloqueoSesion : Form
    {
        // INICIALIZACION TIMER CONTEO REGRESIVO -> VENTANA EMERGENTE
        Timer CuentaRegresiva = new Timer();
        int InicializacionConteo = 50;  // -> CONTEO DESCENDENTE INICIAL EN 50s

        public BloqueoSesion()
        {
            InitializeComponent();
            //Opacity = .95;
            CuentaRegresiva.Interval = 1000;        // INTERVALO 1000ms
            CuentaRegresiva.Enabled = true;         // HABILITANDO CONTEO REGRESIVO
            CuentaRegresiva.Tick += ConteoRegresivo_Tick;    // ACUMULATIVO -> VALIDO 1 EVENTO RECARGABLE
            CuentaRegresiva.Start();                // INICIANDO CONTEO REGRESITO [START]
            lbConteoRegresivo.Text = InicializacionConteo.ToString();   // X SEGUNDOS MOSTRADOS EN PANTALLA
        }

        // POSICION VENTANA EMERGENTE PERSONALIZADO
        private void BloqueoSesion_Load(object sender, EventArgs e)
        {
            // MAXIMA PRIORIDAD, SUPERPOSICION EN OTRAS VENTANAS SIN OPACIDAD
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Size.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height);
        }

        private void ConteoRegresivo_Tick(object sender, EventArgs e)
        {
            lbConteoRegresivo.Text = InicializacionConteo.ToString();   // X SEGUNDOS MOSTRADOS EN PANTALLA
            InicializacionConteo -= 1;  // CONTEO DESCENDENTE 1 EN 1... APLICABLE UNA VEZ POR EVENTO [RECARGABLE]
            // SI CONTEO FINALIZA EN 0 ENTONCES
            if (InicializacionConteo < 0)
            {
                // DETENCION DE CONTEO REGRESIVO
                CuentaRegresiva.Stop();
                this.Hide();    // OCULTAR VENTANA EMERGENTE
            }
        }
    }
}
