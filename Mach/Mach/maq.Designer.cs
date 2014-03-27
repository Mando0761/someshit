namespace Mach
{
    partial class maq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maq));
            this.iniciar = new System.Windows.Forms.Button();
            this.statelabel = new System.Windows.Forms.Label();
            this.cursorlabel = new System.Windows.Forms.Label();
            this.listavisual = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setInterval = new System.Windows.Forms.ToolStripMenuItem();
            this.setFont = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirARchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultado = new System.Windows.Forms.Label();
            this._entradas = new System.Windows.Forms.TextBox();
            this.norm1 = new System.Windows.Forms.RadioButton();
            this.norm2 = new System.Windows.Forms.RadioButton();
            this.rules = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Labelintervalo = new System.Windows.Forms.ToolStripStatusLabel();
            this.pause = new System.Windows.Forms.Button();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iniciar
            // 
            this.iniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iniciar.BackColor = System.Drawing.Color.Transparent;
            this.iniciar.Location = new System.Drawing.Point(101, 64);
            this.iniciar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(87, 37);
            this.iniciar.TabIndex = 2;
            this.iniciar.Text = "Iniciar";
            this.iniciar.UseVisualStyleBackColor = false;
            this.iniciar.Click += new System.EventHandler(this.button2_Click);
            // 
            // statelabel
            // 
            this.statelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statelabel.AutoSize = true;
            this.statelabel.BackColor = System.Drawing.Color.Transparent;
            this.statelabel.Font = new System.Drawing.Font("Haettenschweiler", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statelabel.Location = new System.Drawing.Point(97, 146);
            this.statelabel.Name = "statelabel";
            this.statelabel.Size = new System.Drawing.Size(85, 34);
            this.statelabel.TabIndex = 3;
            this.statelabel.Text = "Estado:";
            // 
            // cursorlabel
            // 
            this.cursorlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cursorlabel.AutoSize = true;
            this.cursorlabel.BackColor = System.Drawing.Color.Transparent;
            this.cursorlabel.Font = new System.Drawing.Font("Haettenschweiler", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cursorlabel.Location = new System.Drawing.Point(97, 196);
            this.cursorlabel.Name = "cursorlabel";
            this.cursorlabel.Size = new System.Drawing.Size(87, 34);
            this.cursorlabel.TabIndex = 4;
            this.cursorlabel.Text = "Cursor:";
            // 
            // listavisual
            // 
            this.listavisual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listavisual.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listavisual.FormattingEnabled = true;
            this.listavisual.ItemHeight = 37;
            this.listavisual.Location = new System.Drawing.Point(242, 65);
            this.listavisual.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listavisual.Name = "listavisual";
            this.listavisual.Size = new System.Drawing.Size(205, 300);
            this.listavisual.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setInterval,
            this.setFont,
            this.abrirARchivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(707, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setInterval
            // 
            this.setInterval.Name = "setInterval";
            this.setInterval.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.setInterval.Size = new System.Drawing.Size(58, 19);
            this.setInterval.Text = "Interval";
            this.setInterval.Click += new System.EventHandler(this.intervalToolStripMenuItem_Click);
            // 
            // setFont
            // 
            this.setFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.analisisToolStripMenuItem});
            this.setFont.Name = "setFont";
            this.setFont.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.setFont.Size = new System.Drawing.Size(43, 19);
            this.setFont.Text = "Font";
            this.setFont.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // abrirARchivoToolStripMenuItem
            // 
            this.abrirARchivoToolStripMenuItem.Name = "abrirARchivoToolStripMenuItem";
            this.abrirARchivoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.abrirARchivoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirARchivoToolStripMenuItem.Size = new System.Drawing.Size(89, 19);
            this.abrirARchivoToolStripMenuItem.Text = "Abrir Archivo";
            this.abrirARchivoToolStripMenuItem.Click += new System.EventHandler(this.abrirARchivoToolStripMenuItem_Click);
            // 
            // resultado
            // 
            this.resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resultado.AutoSize = true;
            this.resultado.BackColor = System.Drawing.Color.Transparent;
            this.resultado.Font = new System.Drawing.Font("Haettenschweiler", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(93, 242);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(110, 34);
            this.resultado.TabIndex = 8;
            this.resultado.Text = "Resultado\r\n";
            // 
            // _entradas
            // 
            this._entradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._entradas.BackColor = System.Drawing.Color.White;
            this._entradas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._entradas.Location = new System.Drawing.Point(8, 65);
            this._entradas.Multiline = true;
            this._entradas.Name = "_entradas";
            this._entradas.Size = new System.Drawing.Size(76, 300);
            this._entradas.TabIndex = 9;
            this._entradas.Text = "AAABBBCCC";
            this._entradas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // norm1
            // 
            this.norm1.AutoSize = true;
            this.norm1.BackColor = System.Drawing.Color.Transparent;
            this.norm1.Checked = true;
            this.norm1.Location = new System.Drawing.Point(8, 34);
            this.norm1.Name = "norm1";
            this.norm1.Size = new System.Drawing.Size(76, 25);
            this.norm1.TabIndex = 10;
            this.norm1.TabStop = true;
            this.norm1.Text = "Norma 1";
            this.norm1.UseVisualStyleBackColor = false;
            this.norm1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // norm2
            // 
            this.norm2.AutoSize = true;
            this.norm2.BackColor = System.Drawing.Color.Transparent;
            this.norm2.Location = new System.Drawing.Point(110, 34);
            this.norm2.Name = "norm2";
            this.norm2.Size = new System.Drawing.Size(78, 25);
            this.norm2.TabIndex = 11;
            this.norm2.Text = "Norma 2";
            this.norm2.UseVisualStyleBackColor = false;
            // 
            // rules
            // 
            this.rules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rules.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rules.ForeColor = System.Drawing.Color.Black;
            this.rules.Location = new System.Drawing.Point(453, 64);
            this.rules.Multiline = true;
            this.rules.Name = "rules";
            this.rules.ReadOnly = true;
            this.rules.Size = new System.Drawing.Size(242, 301);
            this.rules.TabIndex = 12;
            this.rules.Text = resources.GetString("rules.Text");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Labelintervalo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(707, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Labelintervalo
            // 
            this.Labelintervalo.Name = "Labelintervalo";
            this.Labelintervalo.Size = new System.Drawing.Size(56, 17);
            this.Labelintervalo.Text = "Intervalo:";
            // 
            // pause
            // 
            this.pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.Location = new System.Drawing.Point(101, 104);
            this.pause.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(87, 37);
            this.pause.TabIndex = 14;
            this.pause.Text = "Pausa";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.entradaToolStripMenuItem.Text = "Entrada";
            this.entradaToolStripMenuItem.Click += new System.EventHandler(this.entradaToolStripMenuItem_Click);
            // 
            // analisisToolStripMenuItem
            // 
            this.analisisToolStripMenuItem.Name = "analisisToolStripMenuItem";
            this.analisisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.analisisToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.analisisToolStripMenuItem.Text = "Analisis";
            this.analisisToolStripMenuItem.Click += new System.EventHandler(this.analisisToolStripMenuItem_Click);
            // 
            // maq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 422);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.norm2);
            this.Controls.Add(this.norm1);
            this.Controls.Add(this._entradas);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.listavisual);
            this.Controls.Add(this.cursorlabel);
            this.Controls.Add(this.statelabel);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "maq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maquina de Turing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Label statelabel;
        private System.Windows.Forms.Label cursorlabel;
        private System.Windows.Forms.ListBox listavisual;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setInterval;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.TextBox _entradas;
        private System.Windows.Forms.ToolStripMenuItem setFont;
        private System.Windows.Forms.RadioButton norm1;
        private System.Windows.Forms.RadioButton norm2;
        private System.Windows.Forms.TextBox rules;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Labelintervalo;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.ToolStripMenuItem abrirARchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analisisToolStripMenuItem;
    }
}

