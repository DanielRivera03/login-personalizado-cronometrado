# Login Personalizado Cronometrado C Sharp (C#)
![lg1](https://user-images.githubusercontent.com/44457989/83304663-7958ae80-a1bc-11ea-953e-4dcfa7913116.png)

<h2>Descripción general del proyecto:</h2>


![animacion-sistema](https://user-images.githubusercontent.com/44457989/83307485-1538e900-a1c2-11ea-8853-4e6e3abe6639.gif)

<p>Cansado de ver los mismos inicios de sesión comunes y corrientes, una práctica solución es implementar un login personalizado y cronometrado que sea capaz de controlar el número de intentos de cada uno de los usuarios válidados dentro de la aplicación, este práctico inicio de sesión implementa un contador de N intentos, y al cumplir <b>3 intentos permitidos, la aplicación se bloquea por 50 segundos para que el usuario pueda volver a intentar loguearse.</b> El número de intentos así como su duración es totalmente personalizable, usted puede adecuarlo a sus proyectos como usted considere conveniente. Para ello debe modificar ciertas líneas de código dentro de la aplicación:</p>

```csharp
if (ContadorIntentos == 3) // DONDE 3 ES EL N NUMERO DE INTENTOS A CUMPLIRSE
{
      CuentaRegresiva.Start(); // INICIO DE CUENTA REGRESIVA | BLOQUEO DE ACCESO
      // LLAMADA DE CRONOMETRO CONTROLADO -> VENTANA EMERGENTE
      Form Bloquear = new BloqueoSesion();
      Bloquear.Show();
      // BLOQUEO TOTAL DE CONTROLES DE ACCESO
      txtPassUsuario.Enabled = false;
      txtUsuarioLogin.Enabled = false;
      btnIniciarSesion.Enabled = false;
}
```
```csharp
 private void CuentaRegresiva_Tick(object sender, EventArgs e)
 {
        // DECREMENTO EN UNO CUENTA REGRESIVA
         InicializandoConteo--;
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
 << IMPORTANTE: INICIALIZACION DE CONTEO EN 51, PARA QUE CONTEO DE VENTANA 
   EMERGENTE SEA EXACTAMENTE IGUAL AL CONTEO DEL FORMULARIO DE ACCESO >>
                   -- CASO CONTRARIO CONTEO ES DISPAREJO -- 
 */
}
```
<p>En el primer bloque de código presentado anteriormente específicamente la línea de código número 173 del archivo form1.cs usted podrá modificar el número de intentos, además de modificar la línea número 251 del segundo bloque de código dentro de el evento <b>CuentaRegresiva_Tick</b> puede modificar la duración en segundos para la cuenta regresiva. <b>Debe tomar en cuenta que en este archivo siempre debe aumentar en 1 la inicialización del cronometro, de lo contrario el conteo será disparejo y los controles se habilitarán antes de que la cuenta regresiva principal acabe.</b></p> 

<p>Posteriormente debe ubicarse en el archivo BloqueoSesion.cs y dirigirse a la línea número 50 y modificar el valor de esa variable por el <b>número exacto de conteo de cronómetro.</b> Este punto es importante que se respete.</p> 

<h2>Extras:</h2>
<p>Se ha hecho uso de formularios emergentes personalizados, configurados para mostrarse como mensajes de alerta para los usuarios, siéntase en libertad de modificarlos y adecuarlos a sus necesidades.<br> A continuación algunas capturas de dichos mensajes de alerta</p>




![al1](https://user-images.githubusercontent.com/44457989/83306986-dd7d7180-a1c0-11ea-94fb-76d0d7ef5cd4.PNG)
![al2](https://user-images.githubusercontent.com/44457989/83307205-63012180-a1c1-11ea-9916-ac27012ad29c.PNG)
![al3](https://user-images.githubusercontent.com/44457989/83307242-8330e080-a1c1-11ea-9962-6fa07c0b3a30.PNG)
![al7](https://user-images.githubusercontent.com/44457989/83307281-9cd22800-a1c1-11ea-9db4-40b63e04ce6d.PNG)


<p>De igual forma se añadieron algunos efectos de sonido, tome en cuenta que debe modificar el archivo llamado <b>ControlRutaNotificaciones.cs</b> línea de código número 30 donde deberá modificar la ruta presentada por la ruta de su ordenador.</p>



```csharp
public String RutaNotificaciones()
{
    String ControlRutaPC = "dany__000/Desktop/Full Calzado S.A de C.V/Notificaciones/"; // MODIFICAR RUTA 
    return ControlRutaPC;
}

```


![CSharp](https://user-images.githubusercontent.com/44457989/70968018-afb2cf00-205d-11ea-9b79-2ff5a0a100ac.png)<br>



<h2>Proyecto desarrollado bajo el lenguaje de programación C Sharp (C#), compartido y liberado para fines educativos.</h2>

<br>
<h4>*** Fecha de Subida: 29 mayo 2020    |     Fecha Última Modificación: 29 mayo 2020 ***</h4>
