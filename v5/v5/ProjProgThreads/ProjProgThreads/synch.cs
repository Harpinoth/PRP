using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ProjProgThreads
{
    class synch
    {
        Comms client;
        windowform okno;
        bool polaczenie;
        byte[] tabin, tabout, ID;
        bool isactive;
        public void uphold ()
        {
            isactive = true;
            okno = new windowform();

            Application.Run(okno);
            isactive = false;
        }

        public void handler ()
        {
            Thread.Sleep(500);
            client = new Comms();
            tabin = new byte[140];
            tabout = new byte[140];
            ID = new byte[5];
            int k;
            while(isactive)
            {
                if (okno.gettrial() == true)
                {
                    if (polaczenie && okno.getdisconnect())
                    {
                        client.rozlacz();
                        polaczenie = false;
                    }
                    else if (client.polacz(okno.getip(), 50131))
                    {
                        polaczenie = true;
                    }
                }
                if (okno.gettryb() == 2 && polaczenie)
                {
                    tabout[0] = 1;
                    tabout[1] = 2;
                    tabout[2] = 0;
                    client.wyslij(3, tabout);
                    Thread.Sleep(45);
                    client.wez(tabin);
                    Thread.Sleep(45);
                    client.wez(tabin);
                    Thread.Sleep(45);
                    while (okno.gettryb() == 2 && !okno.getdisconnect())
                    {
                        tabout[0] = 3;
                        client.wyslij(1, tabout);
                        Thread.Sleep(45);
                        client.wez(tabin);
                        Thread.Sleep(45);
                        client.wez(tabin);
                        Thread.Sleep(45);
                        for (int i = 0; i < 5; i++)
                        {
                            if ((tabin[14 * i] > 0) && (tabin[14 * i] < 6))
                            {
                                if (i == 0)
                                {
                                    okno.robot1set(tabin[14 * i], BitConverter.ToSingle(tabin, 2 + 14 * i),
                                        BitConverter.ToSingle(tabin, 6 + 14 * i),
                                        BitConverter.ToSingle(tabin, 10 + 14 * i),
                                        tabin[1 + 14 * i]);
                                }
                                else if (i == 1)
                                {
                                    okno.robot2set(tabin[14 * i], BitConverter.ToSingle(tabin, 2 + 14 * i),
                                        BitConverter.ToSingle(tabin, 6 + 14 * i),
                                        BitConverter.ToSingle(tabin, 10 + 14 * i),
                                        tabin[1 + 14 * i]);
                                }
                                else if (i == 2)
                                {
                                    okno.robot3set(tabin[14 * i], BitConverter.ToSingle(tabin, 2 + 14 * i),
                                        BitConverter.ToSingle(tabin, 6 + 14 * i),
                                        BitConverter.ToSingle(tabin, 10 + 14 * i),
                                        tabin[1 + 14 * i]);
                                }
                                else if (i == 3)
                                {
                                    okno.robot4set(tabin[14 * i], BitConverter.ToSingle(tabin, 2 + 14 * i),
                                        BitConverter.ToSingle(tabin, 6 + 14 * i),
                                        BitConverter.ToSingle(tabin, 10 + 14 * i),
                                        tabin[1 + 14 * i]);
                                }
                                else
                                {
                                    okno.robot5set(tabin[14 * i], BitConverter.ToSingle(tabin, 2 + 14 * i),
                                        BitConverter.ToSingle(tabin, 6 + 14 * i),
                                        BitConverter.ToSingle(tabin, 10 + 14 * i),
                                        tabin[1 + 14 * i]);
                                }
                            }

                        }

                    }
                }
                if (okno.gettryb() == 0 && polaczenie)
                {
                    tabout[0] = 1;
                    tabout[1] = 0;
                    tabout[2] = 1;
                    client.wyslij(3, tabout);
                    Thread.Sleep(45);
                    client.wez(tabin);
                    Thread.Sleep(45);
                    client.wez(tabin);
                    /*for (int j = 1; j < tabout[2]+1; j++)
                    {
                        ID[j - 1] = tabin[j];
                    }
                    */
                    Thread.Sleep(45);
                    while (okno.gettryb() == 0 && !okno.getdisconnect())
                    {
                        if (okno.getmoving() == 1)
                        {
                            byte[] forwardframe1 = new byte[4];
                            byte[] forwardframe2 = new byte[4];
                            float a = 50, b = 50;
                            forwardframe1 = BitConverter.GetBytes(a);
                            forwardframe2 = BitConverter.GetBytes(b);
                            tabout[0] = 5;
                            /* for (k = 0; k < 1; k++)
                             {
                                 for (int z = 0; z < 4; z++)
                                 {
                                     tabout[1 + z + k * 8] = forwardframe1[z];
                                     tabout[5 + z + k * 8] = forwardframe2[z];
                                 }
                             }
                             //*/
                            forwardframe1.CopyTo(tabout, 1);
                            forwardframe2.CopyTo(tabout, 5);
                            Thread.Sleep(45);
                            client.wyslij(9, tabout);
                            Thread.Sleep(45);
                            //okno.setmoving();
                        }
                        else if (okno.getmoving() == 2)
                        {
                            byte[] leftframe1 = new byte[4];
                            byte[] leftframe2 = new byte[4];
                            float a = -50, b = 50;
                            leftframe1 = BitConverter.GetBytes(a);
                            leftframe2 = BitConverter.GetBytes(b);
                            tabout[0] = 5;
                            leftframe1.CopyTo(tabout, 1);
                            leftframe2.CopyTo(tabout, 5);
                            Thread.Sleep(45);
                            client.wyslij(9, tabout);
                            Thread.Sleep(45);
                            //okno.setmoving();
                        }
                        else if (okno.getmoving() == 3)
                        {
                            byte[] reverseframe1 = new byte[4];
                            byte[] reverseframe2 = new byte[4];
                            float a = -50, b = -50;
                            reverseframe1 = BitConverter.GetBytes(a);
                            reverseframe2 = BitConverter.GetBytes(b);
                            tabout[0] = 5;
                            reverseframe1.CopyTo(tabout, 1);
                            reverseframe2.CopyTo(tabout, 5);
                            Thread.Sleep(45);
                            client.wyslij(9, tabout);
                            Thread.Sleep(45);
                            //okno.setmoving();
                        }
                        else if (okno.getmoving() == 4)
                        {
                            byte[] rightframe1 = new byte[4];
                            byte[] rightframe2 = new byte[4];
                            float a = 50, b = -50;
                            rightframe1 = BitConverter.GetBytes(a);
                            rightframe2 = BitConverter.GetBytes(b);
                            tabout[0] = 5;
                            rightframe1.CopyTo(tabout, 1);
                            rightframe2.CopyTo(tabout, 5);
                            Thread.Sleep(45);
                            client.wyslij(9, tabout);
                            Thread.Sleep(45);
                            //okno.setmoving();
                        }
                        else if (okno.getmoving() == 0)
                        {
                            tabout[0] = 5;
                            tabout[1] = 0;
                            tabout[2] = 0;
                            tabout[3] = 0;
                            tabout[4] = 0;
                            tabout[5] = 0;
                            tabout[6] = 0;
                            tabout[7] = 0;
                            tabout[8] = 0;
                            client.wyslij(9, tabout);
                        }
                        
                        Thread.Sleep(45);
                        tabout[0] = 3;
                            client.wyslij(1, tabout);
                            Thread.Sleep(45);
                            client.wez(tabin);
                            Thread.Sleep(45);
                            client.wez(tabin);
                            Thread.Sleep(45);
                            for (int i = 0; i < ID.Length; i++)
                            {
                                if ((tabin[14 * i] > 0) && (tabin[14 * i] < 6))
                                {
                                    if (i == 0)
                                    {
                                        okno.robot1set(tabin[14 * i], BitConverter.ToSingle(tabin, 2 + 14 * i),
                                            BitConverter.ToSingle(tabin, 6 + 14 * i),
                                            BitConverter.ToSingle(tabin, 10 + 14 * i),
                                            tabin[1 + 14 * i]);
                                    }
                                    else if (i == 1)
                                    {
                                        okno.robot2set(tabin[14 * i], BitConverter.ToSingle(tabin, 2 + 14 * i),
                                            BitConverter.ToSingle(tabin, 6 + 14 * i),
                                            BitConverter.ToSingle(tabin, 10 + 14 * i),
                                            tabin[1 + 14 * i]);
                                    }
                                    else if (i == 2)
                                    {
                                        okno.robot3set(tabin[14 * i], BitConverter.ToSingle(tabin, 2 + 14 * i),
                                            BitConverter.ToSingle(tabin, 6 + 14 * i),
                                            BitConverter.ToSingle(tabin, 10 + 14 * i),
                                            tabin[1 + 14 * i]);
                                    }
                                    else if (i == 3)
                                    {
                                        okno.robot4set(tabin[14 * i], BitConverter.ToSingle(tabin, 2 + 14 * i),
                                            BitConverter.ToSingle(tabin, 6 + 14 * i),
                                            BitConverter.ToSingle(tabin, 10 + 14 * i),
                                            tabin[1 + 14 * i]);
                                    }
                                    else
                                    {
                                        okno.robot5set(tabin[14 * i], BitConverter.ToSingle(tabin, 2 + 14 * i),
                                            BitConverter.ToSingle(tabin, 6 + 14 * i),
                                            BitConverter.ToSingle(tabin, 10 + 14 * i),
                                            tabin[1 + 14 * i]);
                                    }
                                }
                            }
                        
                    }
                }
                if (okno.gettryb() == 1 && polaczenie)
                {
                    tabout[0] = 1;
                    tabout[1] = 0;
                    tabout[2] = Convert.ToByte(okno.getnumberofrobots());
                    client.wyslij(3, tabout);
                    Thread.Sleep(45);
                    client.wez(tabin);
                    Thread.Sleep(45);
                    client.wez(tabin);
                    Thread.Sleep(45);
                    for (int j = 1; j < tabout[2] + 1; j++)
                    {
                        ID[j - 1] = tabin[j];
                    }
                    Thread.Sleep(45);
                    while (okno.gettryb() == 1 && !okno.getdisconnect())
                    {
                        if (okno.getmoving() == 1)
                        {
                            byte[] forwardframe1 = new byte[4];
                            byte[] forwardframe2 = new byte[4];
                            float a = 50, b = 50;
                            forwardframe1 = BitConverter.GetBytes(a);
                            forwardframe2 = BitConverter.GetBytes(b);
                            tabout[0] = 5;
                            for (k = 1; k < okno.getnumberofrobots() * 8 + 1; k++)
                            {
                                for (int z = 0; z < 4; z++)
                                {
                                    tabout[1 + z + k * 8] = forwardframe1[z];
                                    tabout[5 + z + k * 8] = forwardframe2[z];
                                }
                            }
                            client.wyslij(k + 1, tabout);
                            okno.setmoving();
                        }
                        else if (okno.getmoving() == 2)
                        {
                            byte[] leftframe1 = new byte[4];
                            byte[] leftframe2 = new byte[4];
                            float a = -50, b = 50;
                            leftframe1 = BitConverter.GetBytes(a);
                            leftframe2 = BitConverter.GetBytes(b);
                            tabout[0] = 5;
                            for (k = 1; k < okno.getnumberofrobots() * 8 + 1; k++)
                            {
                                for (int z = 0; z < 4; z++)
                                {
                                    tabout[1 + z + k * 8] = leftframe1[z];
                                    tabout[5 + z + k * 8] = leftframe2[z];
                                }
                            }
                            Thread.Sleep(45);
                            client.wyslij(k + 1, tabout);
                            Thread.Sleep(45);
                            okno.setmoving();
                        }
                        else if (okno.getmoving() == 3)
                        {
                            byte[] reverseframe1 = new byte[4];
                            byte[] reverseframe2 = new byte[4];
                            float a = -50, b = -50;
                            reverseframe1 = BitConverter.GetBytes(a);
                            reverseframe2 = BitConverter.GetBytes(b);
                            tabout[0] = 5;
                            for (k = 0; k < okno.getnumberofrobots(); k++)
                            {
                                for (int z = 0; z < 4; z++)
                                {
                                    tabout[1 + z + k * 8] = reverseframe1[z];
                                    tabout[5 + z + k * 8] = reverseframe2[z];
                                }
                            }
                            Thread.Sleep(45);
                            client.wyslij(k + 1, tabout);
                            Thread.Sleep(45);
                            okno.setmoving();
                        }
                        else if (okno.getmoving() == 4)
                        {
                            byte[] rightframe1 = new byte[4];
                            byte[] rightframe2 = new byte[4];
                            float a = 50, b = -50;
                            rightframe1 = BitConverter.GetBytes(a);
                            rightframe2 = BitConverter.GetBytes(b);
                            tabout[0] = 5;
                            for (k = 1; k < okno.getnumberofrobots() * 8 + 1; k++)
                            {
                                for (int z = 0; z < 4; z++)
                                {
                                    tabout[1 + z + k * 8] = rightframe1[z];
                                    tabout[5 + z + k * 8] = rightframe2[z];
                                }
                            }
                            Thread.Sleep(45);
                            client.wyslij(k + 1, tabout);
                            Thread.Sleep(45);
                            okno.setmoving();
                        }
                            Thread.Sleep(45);
                            tabout[0] = 3;
                            client.wyslij(1, tabout);
                            Thread.Sleep(45);
                            client.wez(tabin);
                            Thread.Sleep(45);
                            client.wez(tabin);
                            Thread.Sleep(45);
                            for (int i = 0; i < 5; i++)
                            {
                                if ((tabin[14 * i] > 0) && (tabin[14 * i] < 6))
                                {
                                    if (i == 0)
                                    {
                                        okno.robot1set(tabin[14 * i], BitConverter.ToSingle(tabin, 2 + 14 * i),
                                            BitConverter.ToSingle(tabin, 6 + 14 * i),
                                            BitConverter.ToSingle(tabin, 10 + 14 * i),
                                            tabin[1 + 14 * i]);
                                    }
                                    else if (i == 1)
                                    {
                                        okno.robot2set(tabin[14 * i], BitConverter.ToSingle(tabin, 2 + 14 * i),
                                            BitConverter.ToSingle(tabin, 6 + 14 * i),
                                            BitConverter.ToSingle(tabin, 10 + 14 * i),
                                            tabin[1 + 14 * i]);
                                    }
                                    else if (i == 2)
                                    {
                                        okno.robot3set(tabin[14 * i], BitConverter.ToSingle(tabin, 2 + 14 * i),
                                            BitConverter.ToSingle(tabin, 6 + 14 * i),
                                            BitConverter.ToSingle(tabin, 10 + 14 * i),
                                            tabin[1 + 14 * i]);
                                    }
                                    else if (i == 3)
                                    {
                                        okno.robot4set(tabin[14 * i], BitConverter.ToSingle(tabin, 2 + 14 * i),
                                            BitConverter.ToSingle(tabin, 6 + 14 * i),
                                            BitConverter.ToSingle(tabin, 10 + 14 * i),
                                            tabin[1 + 14 * i]);
                                    }
                                    else
                                    {
                                        okno.robot5set(tabin[14 * i], BitConverter.ToSingle(tabin, 2 + 14 * i),
                                            BitConverter.ToSingle(tabin, 6 + 14 * i),
                                            BitConverter.ToSingle(tabin, 10 + 14 * i),
                                            tabin[1 + 14 * i]);
                                    }
                                }
                            
                        }
                    }
                }
            }
        }
    }
}
