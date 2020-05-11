namespace Presentacion
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerMouse1 = new System.Windows.Forms.Timer(this.components);
            this.timerProgram = new System.Windows.Forms.Timer(this.components);
            this.txtProgramas = new System.Windows.Forms.TextBox();
            this.lblReloj = new System.Windows.Forms.Label();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.txtsololetras = new System.Windows.Forms.TextBox();
            this.lblFlag = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDetener
            // 
            this.btnDetener.Enabled = false;
            this.btnDetener.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.Location = new System.Drawing.Point(245, 87);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(171, 70);
            this.btnDetener.TabIndex = 6;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(25, 87);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(171, 70);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Inciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Control de Horas";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(485, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 78);
            this.textBox1.TabIndex = 7;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(640, 296);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(94, 32);
            this.lbltime.TabIndex = 8;
            this.lbltime.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerMouse1
            // 
            this.timerMouse1.Tick += new System.EventHandler(this.timerMouse1_Tick);
            // 
            // timerProgram
            // 
            this.timerProgram.Interval = 1000;
            this.timerProgram.Tick += new System.EventHandler(this.timerMouse2_Tick);
            // 
            // txtProgramas
            // 
            this.txtProgramas.Enabled = false;
            this.txtProgramas.Location = new System.Drawing.Point(485, 114);
            this.txtProgramas.Multiline = true;
            this.txtProgramas.Name = "txtProgramas";
            this.txtProgramas.Size = new System.Drawing.Size(406, 99);
            this.txtProgramas.TabIndex = 9;
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.Location = new System.Drawing.Point(174, 194);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(94, 32);
            this.lblReloj.TabIndex = 10;
            this.lblReloj.Text = "00:00";
            // 
            // timerReloj
            // 
            this.timerReloj.Interval = 1000;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            // 
            // txtsololetras
            // 
            this.txtsololetras.Enabled = false;
            this.txtsololetras.Location = new System.Drawing.Point(485, 220);
            this.txtsololetras.Multiline = true;
            this.txtsololetras.Name = "txtsololetras";
            this.txtsololetras.Size = new System.Drawing.Size(406, 73);
            this.txtsololetras.TabIndex = 11;
            // 
            // lblFlag
            // 
            this.lblFlag.AutoSize = true;
            this.lblFlag.Location = new System.Drawing.Point(482, 315);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(37, 13);
            this.lblFlag.TabIndex = 12;
            this.lblFlag.Text = "lblFlag";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(485, 381);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 13;
            this.lblUsuario.Text = "label2";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(485, 421);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(35, 13);
            this.lblInicio.TabIndex = 14;
            this.lblInicio.Text = "label2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 260);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblFlag);
            this.Controls.Add(this.txtsololetras);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.txtProgramas);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHRONOS V3.1 (BETA)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerMouse1;
        private System.Windows.Forms.Timer timerProgram;
        private System.Windows.Forms.TextBox txtProgramas;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.TextBox txtsololetras;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblInicio;
    }
}