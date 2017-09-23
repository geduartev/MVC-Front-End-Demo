using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class FormsController : Controller
    {
        public ActionResult Contacts()
        {
            return View();
        }

        public ActionResult ContactsResponse()
        {
            #region SendMail

            /* string nombreCompleto = "Aca debe ir el nombre completo extraído desde la vista";

            // Armo el mensaje
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(email);
            mailMessage.Subject = "Tu solicitud ha sido procesada.";
            mailMessage.Body = mensaje + " Hemos recibido tu consulta. Responderemos a la brevedad.";
            mailMessage.IsBodyHtml = true;

            // Me conecto al servidor smtp
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smpt.live.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("email@email.com", "password");

            // Envío el mensaje
            smtp.Send(mailMessage);

            // SQL CONNECTION
            // Crear la conexión
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-74BJTF4\\SQLSERVER2008R2;Initial Catalog=MvcDemoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection.Open();*/

            #endregion

            #region SaveToDataBaseWithODBC

            /*// ODBC
            OdbcConnection conn;
            OdbcCommand cmd;
            string MyQuery;

            //string connectionString = "Driver={SQL Server};Server=mySQLServer;UID=sa;PWD=myPassword;Database=Northwind;";
            string connectionString = "DSN=Test;UID=Chester;Pwd=Tester";

            MyQuery = "Select * from Contactos";

            conn = new OdbcConnection(connectionString);
            cmd = new OdbcCommand(MyQuery, conn);
            conn.Open();

            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                People.Add(new Person()
                {
                    Id = Convert.ToInt32(dr.GetValue(0).ToString()),
                    Name = dr.GetValue(1).ToString()
                });
            }
            
            @ViewBag.DBMessage = "Connected";

            conn.Close();
            dr.Close();
            cmd.Dispose();
            conn.Dispose();*/

            #endregion

            #region SaveToDataBase

            /* // Crear la sentencia
            var sentence = new SqlCommand();
            sentence.CommandType = CommandType.Text;
            sentence.CommandText =
                "INSER INTO Contacto (nombre, apellido, correo), VALUES (@pnombre, @papellido, @pcorreo)";
            sentence.Parameters.Add(new System.Data.SqlClient.SqlParameter("pnombre", nombre));
            sentence.Parameters.Add(new SqlParameter("papellido", apellido));
            sentence.Parameters.Add(new SqlParameter("pcorreo", email));

            // Asociar sentencia a conexión
            sentence.Connection = connection;

            // Ejecutar la sentencia
            var result = sentence.ExecuteNonQuery();

            // Leer el resultado
            var feedbackMessage = "";
            feedbackMessage = result == 0 ? "Exitoso!" : "Fallo";

            // Cerrar la conexión
            connection.Close(); */

            #endregion

            ViewBag.Name = "Nombre por asignar";
            ViewBag.Text = "Te responderemos a la brevedad a Texto por asignar";
            return View("ContactsResponse");
        }

        public string OtroPuntoDeEntrada()
        {
            return "Solo devuelvo un texto...";
        }
    }
}
