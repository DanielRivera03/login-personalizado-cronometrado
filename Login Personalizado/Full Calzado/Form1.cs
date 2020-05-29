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
// IMPORTANDO LIBRERIA QUE HABILITA EL EVENTO DE ARRASTRES DE FORMULARIOS POR PARTE DE LOS USUARIOS
using System.Runtime.InteropServices;

namespace Full_Calzado
{
    public partial class LoginUsuarios : Form
    {
        // CONTROL TIMER -> CUENTA ATRAS PARA BLOQUEO TEXTBOX Y BOTON
        private int InicializandoConteo = 51;
        /*********************************************************************************************
         * HABILITANDO EL ARRASTRE DEL FORMULARIO A X POSICION EN PANTALLA POR PARTE DEL USUARIO
         * --> CODIGO DE INICIALIZACION DEL EVENTO
         *********************************************************************************************/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // FIN INICIALIZACION DE EVENTO ARRASTRE DE FORMULARIOS
        public LoginUsuarios()
        {
            InitializeComponent();
        }

        // INSTANCIA LLAMADA NOTIFICACIONES PESONALIZADAS
        NotificacionesPersonalizadas Llamada = new NotificacionesPersonalizadas();

        // INICIALIZANDO CONTADOR DE INTENTOS
        int ContadorIntentos = 0;

        /*
            --> EFECTO PLACEHOLDER
                CAJA DE TEXTO USUARIO 
        */

        private void txtUsuarioLogin_Enter(object sender, EventArgs e)
        {
            // SI FOCO SE ENCUENTRA ACTIVO, ENTONCES...
            if (txtUsuarioLogin.Text == "Ingrese su usuario...")
            {
                txtUsuarioLogin.Text = "";
                txtUsuarioLogin.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtUsuarioLogin_Leave(object sender, EventArgs e)
        {
            // SI FOCO NO SE ENCUENTRA ACTIVO, ENTONCES...
            if (txtUsuarioLogin.Text == "")
            {
                txtUsuarioLogin.Text = "Ingrese su usuario...";
                txtUsuarioLogin.ForeColor = Color.White;
            }
        }

        /*
            --> EFECTO PLACEHOLDER
                CAJA DE TEXTO CONTRASEÑA {PASSWORD} 
        */

        private void txtPassUsuario_Enter(object sender, EventArgs e)
        {
            // SI FOCO SE ENCUENTRA ACTIVO, ENTONCES...
            if (txtPassUsuario.Text == "password") {
                txtPassUsuario.Text = "";
                txtPassUsuario.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtPassUsuario_Leave(object sender, EventArgs e)
        {
            // SI FOCO NO SE ENCUENTRA ACTIVO, ENTONCES...
            if (txtPassUsuario.Text == "")
            {
                txtPassUsuario.Text = "password";
                txtPassUsuario.ForeColor = Color.White;
            }
        }

        /*
            --> BOTON MINIMIZAR VENTANA 
        */

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*
            --> BOTON CERRAR VENTANA 
        */

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            Application.Exit(); // TERMINA EJECUCION Y CIERRA VENTANA
        }

        /*
            --> ARRASTRE FORMULARIO TODO CONTENEDOR DE INFORMACION IZQUIERDO
                                EXCEPTO LOGO... 
        */

        private void ContenedorInfoIzq_MouseDown(object sender, MouseEventArgs e)
        {
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*
            --> ARRASTRE FORMULARIO TODO CONTENEDOR DE INFORMACION DERECHO 
        */

        private void ContenedorLoginUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // BOTON INICIAR SESION
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (this.txtUsuarioLogin.Text == "Ingrese su usuario..." || this.txtPassUsuario.Text == "password" || this.txtUsuarioLogin.Text == "" || this.txtPassUsuario.Text == "")
            {
                Llamada.NotificionAdvertencia();  // NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                // LLAMADA ERROR CAMPOS REQUERIDOS INCOMPLETOS {VACIOS}
                Form LlamadaErrorCampos = new MensajeErrorCamposVacios();
                LlamadaErrorCampos.Show();
            }
            else
            {
                // SI CONTRASEÑA GENERICA POR DEFECTO ES CORRECTA, ENTONCES...
                if(this.txtUsuarioLogin.Text == "Invitado" || this.txtUsuarioLogin.Text == "invitado" || this.txtPassUsuario.Text == "12345")
                {
                    Llamada.NotificionConfirmacion();  // NOTIFICACION PERSONALIZADA DE TAREA FINALIZADA {APROBADA}
                    Form llamadaaprobacion = new MensajeAprobacion();
                    llamadaaprobacion.Show(); // FINALIZA TAREA  
                }else
                {
                    Llamada.NotificionError();  // NOTIFICACION PERSONALIZADA DE TAREA FINALIZADA {APROBADA}
                    Form llamadatarearechazada = new MensajeErrorLogin();
                    llamadatarearechazada.Show(); // FINALIZA TAREA  
                    // AUMENTO EN 1 -> CONTADOR DE INTENTOS
                    ContadorIntentos++;
                }
                // SI CONTADOR INTENTOS ACUMULA 3, ENTONCES...
                if (ContadorIntentos == 3)
                {
                    CuentaRegresiva.Start();    // INICIO DE CUENTA REGRESIVA | BLOQUEO DE ACCESO
                                                // LLAMADA DE CRONOMETRO CONTROLADO -> VENTANA EMERGENTE
                    Form Bloquear = new BloqueoSesion();
                    Bloquear.Show();
                    // BLOQUEO TOTAL DE CONTROLES DE ACCESO
                    txtPassUsuario.Enabled = false;
                    txtUsuarioLogin.Enabled = false;
                    btnIniciarSesion.Enabled = false;
                }
            }
        }

        // EVENTO ENTER --> CAJA DE TEXTO USUARIOS
        private void txtUsuarioLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnIniciarSesion_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER --> CAJA DE TEXTO CONTRASEÑA
        private void txtPassUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciarSesion_Click(this, new EventArgs());
            }
        }

        private void CuentaRegresiva_Tick(object sender, EventArgs e)
        {
            // DECREMENTO EN UNO CUENTA REGRESIVA
            InicializandoConteo--;
            //this.label8.Text = InicializandoConteo.ToString();       //--> EFECTOS DE PRUEBAS
            // SI CUENTA REGRESIVA LLEGA A CERO, ENTONCES...
            if (InicializandoConteo == 0)
            {
                ContadorIntentos = 0;           // RESETEANDO CONTADOR DE INTENTOS
                CuentaRegresiva.Stop();         // DETENER CUENTA REGRESIVA
                InicializandoConteo = 51;       // INICIALIZANDO NUEVAMENTE CUENTA REGRESIVA
                // HABILITANDO TODOS LOS CONTROLES DE ACCESO
                txtPassUsuario.Enabled = true;  
                txtUsuarioLogin.Enabled = true;
                btnIniciarSesion.Enabled = true;
                /*
                    Y SE REPITE EL CICLO
                    << IMPORTANTE: INICIALIZACION DE CONTEO EN 51, PARA QUE CONTEO DE VENTANA EMERGENTE
                    SEA EXACTAMENTE IGUAL AL CONTEO DEL FORMULARIO DE ACCESO >>
                    
                    -- CASO CONTRARIO CONTEO ES DISPAREJO -- 
                */
            }
        }
    }
}

