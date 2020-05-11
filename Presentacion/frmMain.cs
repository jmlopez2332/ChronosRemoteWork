using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using AccesoDatos;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class frmMain : Form
    {
        public string textoEscrito = "", textoNuevo = "", posicionActual = "", posicionNueva = "", programas = "", flag = "";
        public int numerodeveces = 0, reloj = 1, prorroga = 1;

        public frmMain()
        {
            InitializeComponent();
        }

        
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Enabled = false;
            btnDetener.Enabled = true;
            timer1.Enabled = true;
            timer1.Start();
            timerReloj.Start();

            timerMouse1.Start();
            timerProgram.Start();

            gHook.hook();
        }

        void verificarEscrito()
        {
            textoNuevo = textBox1.Text;
            if (textoEscrito != textoNuevo)
            {
                prorroga = 1;
                lblFlag.Text = prorroga.ToString();
                numerodeveces = numerodeveces + 1;
                lbltime.Text = numerodeveces.ToString();
                textoEscrito = textoNuevo;
            }
            else
            {
                prorroga = prorroga + 1;
                lblFlag.Text = prorroga.ToString();
                if (prorroga < 60)
                {
                    numerodeveces = numerodeveces + 1;
                    lbltime.Text = numerodeveces.ToString();
                }
            }

        }

        GlobalKeyboardHook gHook;
        private void frmMain_Load(object sender, EventArgs e)
        {
            gHook = new GlobalKeyboardHook();
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);
        }

        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.Text += ((char)e.KeyValue).ToString();
            txtsololetras.Text += ((char)e.KeyValue).ToString();
        }

        void stop()
        {
            btnDetener.Enabled = false;
            gHook.unhook();
            timer1.Stop();
            timerMouse1.Stop();
            timerProgram.Stop();
            timerReloj.Stop();
            btnIniciar.Enabled = true;
            guardar();
            reiniciar();

        }

        void reiniciar()
        {
            textBox1.Text = "";
            txtProgramas.Text = "";
            txtsololetras.Text = "";
            lblFlag.Text = "";
            lblReloj.Text = "";
            lbltime.Text = "";
            numerodeveces = 0; 
            reloj = 1;
            prorroga = 1;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            stop();
        }

        void guardar()
        {
            DateTime fecha = DateTime.Now;

            string nombrepc = System.Environment.MachineName;
            string tiempoCronometrado = lblReloj.Text;
            string tiemporeal = lbltime.Text;
            string capturador = txtsololetras.Text;
            capturador = capturador.Replace("'", "");
            capturador = capturador.Replace("\"", "");
            string programas = txtProgramas.Text;
            programas = programas.Replace("'", "");
            programas = programas.Replace("\"", "");
            string fechaActual = fecha.ToString();

            _0ConectDB conn = new _0ConectDB();
            SqlDataReader dtr = null;
            conn.cn.Open();
            string INSERT = "INSERT INTO AMQ_ADICIONAL..HISTORIAL_TRABAJO_REMOTO ( "+
                            "     FECHA "+
                            "     ,NOMBRE_PC "+
                            "     ,TIEMPO_CRONOMETRADO "+
                            "     ,TIEMPO_REAL "+
                            "     ,PROGRAMAS_UTILIZADOS "+
                            "     ,EVENTOS_CAPTURADOR "+
                            "   ) VALUES ( "+
                            "      '"+fechaActual+"'  "+
                            "     ,'"+nombrepc+"'  "+
                            "     ,'"+tiempoCronometrado+"' "+
                            "     ,'"+tiemporeal+"'   "+
                            "     ,'"+programas+"'   "+
                            "     ,'" + capturador + "'   " +
                            "   )";
            SqlCommand cmd = new SqlCommand(INSERT, conn.cn);
            dtr = cmd.ExecuteReader();
            dtr.Read();
            conn.cn.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            verificarEscrito();

        }


        protected delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        protected static extern int GetWindowText(IntPtr hWnd, StringBuilder strText, int maxCount);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        protected static extern int GetWindowTextLength(IntPtr hWnd);
        [DllImport("user32.dll")]
        protected static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);
        [DllImport("user32.dll")]
        protected static extern bool IsWindowVisible(IntPtr hWnd);
        public  bool EnumTheWindows(IntPtr hWnd, IntPtr lParam)
        {
            int tamano = GetWindowTextLength(hWnd);
            if (tamano++ > 0 && IsWindowVisible(hWnd))
            {
                StringBuilder sb = new StringBuilder(tamano);
                GetWindowText(hWnd, sb, tamano);
                //Console.WriteLine(sb.ToString());
                txtProgramas.Text += sb.ToString();
            }
            return true;
        }












        [DllImport("user32.dll")]
        static extern int GetForegroundWindow();

        [DllImport("user32")]
        private static extern UInt32 GetWindowThreadProcessId(Int32 hWnd, out Int32 lpdwProcessId);

        private int teller = 0;


        private void timerMouse2_Tick(object sender, EventArgs e)
        {

            //if (teller == 1)
            //{
                setTextje();
            //}
            //teller++;

            //EnumWindows(new EnumWindowsProc(EnumTheWindows), IntPtr.Zero);
            //Console.ReadKey();
        }


        private Int32 GetWindowProcessID(Int32 hwnd)
        {
            Int32 pid = 1;
            GetWindowThreadProcessId(hwnd, out pid);
            return pid;
        }

        private void setTextje()
        {
            try
            {
                Int32 hwnd = 0;
                hwnd = GetForegroundWindow();
                string appProcessName = Process.GetProcessById(GetWindowProcessID(hwnd)).ProcessName;
                //string appExePath = Process.GetProcessById(GetWindowProcessID(hwnd)).MainModule.FileName;
                //string appExeName = appExePath.Substring(appExePath.LastIndexOf(@"\") + 1);

                if (flag == appProcessName.ToString())
                {
                    flag = appProcessName.ToString();
                }
                else
                {
                    //txtProgramas.Text = "";
                    txtsololetras.Text += " | ";
                    txtsololetras.Text += appProcessName.ToString();
                    txtsololetras.Text += " ";
                    flag = appProcessName.ToString();
                }
            }
            catch (Exception ex)
            { 
            }

            //txtProgramas.Text += appProcessName.ToString(); //+ " | " + appExePath + " | " + appExeName;
        }
































        private void timerMouse1_Tick(object sender, EventArgs e)
        {
            posicionNueva = Cursor.Position.X.ToString();
            if (posicionActual != posicionNueva)
            {
                textBox1.Text += Cursor.Position.X.ToString();
                posicionActual = posicionNueva;
            }

        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            int numero = reloj++;
            lblReloj.Text = numero.ToString() + " (segundos)"; 
        }
    }
}
