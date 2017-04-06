using System;
using System.Windows.Forms;

namespace Pomiar_temperatury
{
    public partial class Temperatura : Form
    {
        Port port = new Port();
        Odczyt odczyt = new Odczyt();
        public Temperatura()
        {
            InitializeComponent();
        }

        private void portB_Click(object sender, EventArgs e)
        {
            port.ShowDialog();
        }

        private void odczytB_Click(object sender, EventArgs e)
        {
            if (port.stan)
            {
                odczyt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Otwórz port");
            }
        }
    }
}
