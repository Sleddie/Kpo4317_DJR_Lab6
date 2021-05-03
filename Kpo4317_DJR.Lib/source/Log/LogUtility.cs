using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4317_DJR.Lib
{
    public static class LogUtility
    {
        public static void ErrorLog(string message)
        {
            message = DateTime.Now + ": " + message + "\n";
            byte[] byteMessage = Encoding.UTF8.GetBytes(message);
            FileStream logfile = null;

            try
            {
                logfile = new FileStream(AppGlobalSettings.LogPath, FileMode.Open);
                logfile.Write(byteMessage, 0, byteMessage.Length);
            }
            catch (NoFileInPathException ex)
            {
                Console.WriteLine(ex.Message + "\nСоздайте файл журнализации");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                if (logfile != null)
                    logfile.Close();
            }
        }

        public static void ErrorLog(Exception exception)
        {
            string message = DateTime.Now + ": " + exception.Message + "\n";
            byte[] byteMessage = Encoding.UTF8.GetBytes(message);
            FileStream logfile = null;

            try
            {
                logfile = new FileStream(AppGlobalSettings.LogPath, FileMode.Open);
                logfile.Write(byteMessage, 0, byteMessage.Length);
            }
            catch (NoFileInPathException ex)
            {
                Console.WriteLine(ex.Message + "\nСоздайте файл журнализации");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (logfile != null)
                    logfile.Close();
            }
        }
    }
}
