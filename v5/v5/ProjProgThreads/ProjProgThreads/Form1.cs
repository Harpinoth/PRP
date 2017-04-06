using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjProgThreads
{
    public partial class windowform : Form
    {
        int tryb;
        int moving = 0;
        bool dc = false;
        bool trial = false;
        string ip;
        int a, b;

        
        delegate void robopodloga (byte ID, float x, float y, float ang, byte lease);

        robopodloga robus;
        object[] robusie;
       

        public windowform ()
        {
            InitializeComponent();
            robusie = new object[5];
        }

        public int gettryb ()
        {
            return tryb;
        }

        public bool gettrial ()
        {
            return trial;
        }
        
        public void settrial ()
        {
            trial = false;
        }

        public string getip ()
        {
            return ip;
        }

        public bool getdisconnect()
        {
            return dc;
        }

        public int getmoving()
        {
            return moving;
        }

        public void setmoving()
        {
            moving = 0;
        }

        public int getnumberofrobots()
        {
            return a;
        }

        public int getcontrolledrobot()
        {
            return b;
        }

        public void robot1set (byte ID, float x, float y, float ang, byte lease)
        {
            if(roboinfo1.InvokeRequired)
            {
                robusie[0] = ID;
                robusie[1] = x;
                robusie[2] = y;
                robusie[3] = ang;
                robusie[4] = lease;
                robus = robot1set;
                roboinfo1.Invoke(robus, robusie);
            }
            else
            {
                roboinfo1.Text = "ID = " + ID.ToString() 
                    + ", x = " + x.ToString() + ", y = " 
                    + y.ToString() + ", kąt = " 
                    + ang.ToString() + ", zajęty: " 
                    + lease.ToString();
            }
        }

        public void robot2set (byte ID, float x, float y, float ang, byte lease)
        {
            if (roboinfo2.InvokeRequired)
            {
                robusie[0] = ID;
                robusie[1] = x;
                robusie[2] = y;
                robusie[3] = ang;
                robusie[4] = lease;
                robus = robot2set;
                roboinfo2.Invoke(robus, robusie);
            }
            else
            {
                roboinfo2.Text = "ID = " + ID.ToString() + ", x = " + x.ToString() + ", y = " + y.ToString() + ", kąt = " + ang.ToString() + ", zajęty: " + lease.ToString();
            }
        }

        public void robot3set (byte ID, float x, float y, float ang, byte lease)
        {
            if (roboinfo3.InvokeRequired)
            {
                robusie[0] = ID;
                robusie[1] = x;
                robusie[2] = y;
                robusie[3] = ang;
                robusie[4] = lease;
                robus = robot3set;
                roboinfo3.Invoke(robus, robusie);
            }
            else
            {
                roboinfo3.Text = "ID = " + ID.ToString() + ", x = " + x.ToString() + ", y = " + y.ToString() + ", kąt = " + ang.ToString() + ", zajęty: " + lease.ToString();
            }
        }

        public void robot4set (byte ID, float x, float y, float ang, byte lease)
        {
            if (roboinfo1.InvokeRequired)
            {
                robusie[0] = ID;
                robusie[1] = x;
                robusie[2] = y;
                robusie[3] = ang;
                robusie[4] = lease;
                robus = robot4set;
                roboinfo4.Invoke(robus, robusie);
            }
            else
            {
                roboinfo4.Text = "ID = " + ID.ToString() + ", x = " + x.ToString() + ", y = " + y.ToString() + ", kąt = " + ang.ToString() + ", zajęty: " + lease.ToString();
            }
        }

        public void robot5set (byte ID, float x, float y, float ang, byte lease)
        {
            if (roboinfo1.InvokeRequired)
            {
                robusie[0] = ID;
                robusie[1] = x;
                robusie[2] = y;
                robusie[3] = ang;
                robusie[4] = lease;
                robus = robot5set;
                roboinfo5.Invoke(robus, robusie);
            }
            else
            {
                roboinfo5.Text = "ID = " + ID.ToString() + ", x = " + x.ToString() + ", y = " + y.ToString() + ", kąt = " + ang.ToString() + ", zajęty: " + lease.ToString();
            }
        }

        private void monitorprz_Click (object sender, EventArgs e)
        {
            tryb = 2;
            dc = false;
            trial = true;
            ip = IPadd.Text;
        }

        private void kontrolaprz_Click(object sender, EventArgs e)
        {
            tryb = 0;
            dc = false;
            trial = true;
            ip = IPadd.Text;
            a = Convert.ToInt32(noofrobots.Text);
        }

        private void monitorkontrolaprz_Click(object sender, EventArgs e)
        {
            tryb = 1;
            dc = false;
            trial = true;
            ip = IPadd.Text;
            a = Convert.ToInt32(noofrobots.Text);
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            trial = true;
            dc = true;
        }

        private void moveforward_Click(object sender, EventArgs e)
        {
            moving = 1;
        }

        private void moveleft_Click(object sender, EventArgs e)
        {
            moving = 2;
        }

        private void movebackwards_Click(object sender, EventArgs e)
        {
            moving = 3;
        }

        private void controlledrobot_SelectedIndexChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt32(controlledrobot.Text);
        }

        private void stopper_Click(object sender, EventArgs e)
        {
            moving = 0;
        }

        private void moveright_Click(object sender, EventArgs e)
        {
            moving = 4;
        }
    }
}
