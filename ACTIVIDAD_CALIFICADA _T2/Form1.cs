using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTIVIDAD_CALIFICADA__T2
{
    public partial class Form1 : Form
    {
        public static List<int> list = new List<int>();
        public static List<Dueño> listDueño = new List<Dueño>();
        public static List<Mascota> listMascota = new List<Mascota>();

        public Form1()
        {
            InitializeComponent();
            //Random r = new Random();

            //for (int i = 0; i < 15; i++)
            //{
            //    Form1.list.Add(r.Next(100));
            //}

        }

        private void enunciado1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enunciado1 frm = new Enunciado1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reguitroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enunciado2 frm = new Enunciado2();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
