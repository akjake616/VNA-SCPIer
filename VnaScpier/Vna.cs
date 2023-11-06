using Ivi.Visa.Interop;
using System;


namespace VnaLibrary
{
    public class Vna
    {
        FormattedIO488 driver = null;
        public bool InitVna(string Address, int Timeout, out string msgError)
        {
            try
            {
                ResourceManager VISA_RM = new ResourceManager();
                driver = new FormattedIO488();

                driver.IO = (IMessage)VISA_RM.Open(Address, AccessMode.NO_LOCK, Timeout, "");
                //driver.WriteString("DISP:ENABLE ON");
                //driver.WriteString("DISP:VIS ON");

                driver.WriteString("format:data ascii");

                msgError = "";
            }
            catch
            {
                msgError = "VISA connection error.";
                return false;
            }
            return true;
        }

        public void Close()
        {
            driver.IO.Close();
        }

        public void Reset()
        {
            driver.WriteString("*RST\n CALC:PAR:DEL:ALL", true);
        }

        public string WriteSCPI(string command)
        {
            try
            {
                driver.WriteString(command, true);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        public string ReadSCPI(string command)
        {
            try
            {
                driver.WriteString(command, true);
                return driver.ReadString();
            }
            catch(Exception ex) 
            {
                return ex.Message;
            }
            
        }

    }
}
