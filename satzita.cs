using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
namespace Limpador_da_Sat
{
    public partial class satzita : Form
    {
        // <3

        Point lastPoint;


        public satzita()
        {
            InitializeComponent();

        }
        enum RecycleFlags : uint
        {
            SHRB_NOCONFIRMATION = 0x00000001,
            SHRB_NOPROGRESSUI = 0x00000002,
            SHRB_NOSOUND = 0x00000004
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);
        private void intro_MouseHover(object sender, EventArgs e)
        {
            intro.Text = "Amo a sat ❤";
        }

        private void intro_MouseLeave(object sender, EventArgs e)
        {
            intro.Text = "Limpador da Sat";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button1, "Fechar :v");
            ToolTip1.InitialDelay = 250;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "C:/Windows/Prefetch";
            label2.Text = Environment.UserName + "/AppData/Local/Temp";
            label3.Text = Environment.UserName + "/Recent";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                clear(@"C:\Users\" + Environment.UserName + @"\AppData\Local\Temp");
                MessageBox.Show("limpei tudin, só falta o pagamento :< ", "Satzita - Empregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Não consegui apagar os arquivos, Provavelmente o acesso não foi permitido pelo windows :c", "Satzita - Empregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clear(string local)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(local);
            foreach (FileInfo file in di.GetFiles())
            {
                try
                {

                    file.Delete();

                }
                catch
                {
                }

            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                try
                {
                    dir.Delete(true);
                }
                catch
                {
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                clear(@"C:\Users\" + Environment.UserName + @"\Recent");
                MessageBox.Show("limpei tudin, só falta o pagamento :< ", "Satzita - Empregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Não consegui apagar os arquivos, Provavelmente o acesso não foi permitido pelo windows :c", "Satzita - Empregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                clear(@"C:\Windows\Prefetch");
                MessageBox.Show("limpei tudin, só falta o pagamento :< ", "Satzita - Empregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Não consegui apagar os arquivos, Provavelmente o acesso não foi permitido pelo windows :c", "Satzita - Empregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
                MessageBox.Show("limpei tudin, só falta o pagamento :< ", "Satzita - Empregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("não consegui fazer isso, desculpe :c" + ex.Message, "Satzita - Empregada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
        }

        private void intro_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void intro_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
