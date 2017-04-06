using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace ProjProgThreads
{
    class Comms
    {
        TcpClient serwer;
        BinaryReader czytacz;
        BinaryWriter pisacz;

        public bool polacz (string IP, int port)
        {
            serwer = new TcpClient();
            serwer.Connect(IP, port);
            if (serwer.Connected)
            {
                czytacz = new BinaryReader(serwer.GetStream());
                pisacz = new BinaryWriter(serwer.GetStream());
                return true;
            }
            else return false;
        }

        public bool wyslij (int liczbajt, byte[] tab1)
        {
            try
            {
                pisacz.Write(tab1, 0, liczbajt);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool wez (byte[] tab2)
        {
            try
            {
                czytacz.Read(tab2, 0, 140);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool rozlacz()
        {
            try
            {
                serwer.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
    
}
