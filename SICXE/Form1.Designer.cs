namespace SICXE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.paso1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analizarCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarArchivoIntermedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paso2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.simuladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbErrores = new System.Windows.Forms.TextBox();
            this.dataGridTabSim = new System.Windows.Forms.DataGridView();
            this.dgSimbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intermedio = new System.Windows.Forms.DataGridView();
            this.dg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEtiqueta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInstruccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgOperando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCodObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgErrores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPrograma = new System.Windows.Forms.TextBox();
            this.tbLinea = new System.Windows.Forms.TextBox();
            this.LongitudPrograma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRegistros = new System.Windows.Forms.TextBox();
            this.btnEnsamblar = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.cargarOtroArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
=======
            this.cargadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
>>>>>>> e62345c310b273d41a8eb9493a71ef38b2fc3d78
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTabSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intermedio)).BeginInit();
            this.SuspendLayout();
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripSeparator2,
            this.cerrarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.paso1ToolStripMenuItem,
            this.paso2ToolStripMenuItem,
            this.cargadorToolStripMenuItem,
            this.simuladorToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(1527, 28);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // paso1ToolStripMenuItem
            // 
            this.paso1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analizarCódigoToolStripMenuItem,
            this.generarArchivoIntermedioToolStripMenuItem});
            this.paso1ToolStripMenuItem.Enabled = false;
            this.paso1ToolStripMenuItem.Name = "paso1ToolStripMenuItem";
            this.paso1ToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.paso1ToolStripMenuItem.Text = "Paso 1";
            // 
            // analizarCódigoToolStripMenuItem
            // 
            this.analizarCódigoToolStripMenuItem.Name = "analizarCódigoToolStripMenuItem";
            this.analizarCódigoToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.analizarCódigoToolStripMenuItem.Text = "Analizar Código";
            this.analizarCódigoToolStripMenuItem.Click += new System.EventHandler(this.analizarCódigoToolStripMenuItem_Click);
            // 
            // generarArchivoIntermedioToolStripMenuItem
            // 
            this.generarArchivoIntermedioToolStripMenuItem.Enabled = false;
            this.generarArchivoIntermedioToolStripMenuItem.Name = "generarArchivoIntermedioToolStripMenuItem";
            this.generarArchivoIntermedioToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.generarArchivoIntermedioToolStripMenuItem.Text = "Generar Archivo Intermedio";
            this.generarArchivoIntermedioToolStripMenuItem.Click += new System.EventHandler(this.generarArchivoIntermedioToolStripMenuItem_Click);
            // 
            // paso2ToolStripMenuItem
            // 
            this.paso2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.códigoObjetoToolStripMenuItem,
            this.generarRegistrosToolStripMenuItem});
            this.paso2ToolStripMenuItem.Enabled = false;
            this.paso2ToolStripMenuItem.Name = "paso2ToolStripMenuItem";
            this.paso2ToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.paso2ToolStripMenuItem.Text = "Paso 2";
            // 
            // códigoObjetoToolStripMenuItem
            // 
            this.códigoObjetoToolStripMenuItem.Enabled = false;
            this.códigoObjetoToolStripMenuItem.Name = "códigoObjetoToolStripMenuItem";
            this.códigoObjetoToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.códigoObjetoToolStripMenuItem.Text = "Código Objeto";
            this.códigoObjetoToolStripMenuItem.Click += new System.EventHandler(this.códigoObjetoToolStripMenuItem_Click);
            // 
            // generarRegistrosToolStripMenuItem
            // 
            this.generarRegistrosToolStripMenuItem.Enabled = false;
            this.generarRegistrosToolStripMenuItem.Name = "generarRegistrosToolStripMenuItem";
            this.generarRegistrosToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.generarRegistrosToolStripMenuItem.Text = "Generar Registros";
            this.generarRegistrosToolStripMenuItem.Click += new System.EventHandler(this.generarRegistrosToolStripMenuItem_Click);
            // 
            // cargadorToolStripMenuItem
            // 
            this.cargadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
<<<<<<< HEAD
            this.cargadorToolStripMenuItem1,
            this.cargarOtroArchivoToolStripMenuItem});
=======
            this.cargadorToolStripMenuItem1});
>>>>>>> e62345c310b273d41a8eb9493a71ef38b2fc3d78
            this.cargadorToolStripMenuItem.Name = "cargadorToolStripMenuItem";
            this.cargadorToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.cargadorToolStripMenuItem.Text = "Cargador";
            // 
            // cargadorToolStripMenuItem1
            // 
            this.cargadorToolStripMenuItem1.Name = "cargadorToolStripMenuItem1";
            this.cargadorToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.cargadorToolStripMenuItem1.Text = "Cargador";
            this.cargadorToolStripMenuItem1.Click += new System.EventHandler(this.cargadorToolStripMenuItem1_Click);
            // 
            // simuladorToolStripMenuItem
            // 
            this.simuladorToolStripMenuItem.Enabled = false;
            this.simuladorToolStripMenuItem.Name = "simuladorToolStripMenuItem";
            this.simuladorToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.simuladorToolStripMenuItem.Text = "Simulador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Archivo Intermedio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1188, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "TabSim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1188, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Errores";
            // 
            // tbErrores
            // 
            this.tbErrores.Enabled = false;
            this.tbErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbErrores.Location = new System.Drawing.Point(1193, 406);
            this.tbErrores.Margin = new System.Windows.Forms.Padding(4);
            this.tbErrores.Multiline = true;
            this.tbErrores.Name = "tbErrores";
            this.tbErrores.ReadOnly = true;
            this.tbErrores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbErrores.Size = new System.Drawing.Size(316, 131);
            this.tbErrores.TabIndex = 2;
            // 
            // dataGridTabSim
            // 
            this.dataGridTabSim.AllowUserToAddRows = false;
            this.dataGridTabSim.AllowUserToDeleteRows = false;
            this.dataGridTabSim.AllowUserToResizeColumns = false;
            this.dataGridTabSim.AllowUserToResizeRows = false;
            this.dataGridTabSim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTabSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridTabSim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSimbolo,
            this.dgDireccion,
            this.dgTipo});
            this.dataGridTabSim.Location = new System.Drawing.Point(1193, 75);
            this.dataGridTabSim.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridTabSim.Name = "dataGridTabSim";
            this.dataGridTabSim.ReadOnly = true;
            this.dataGridTabSim.RowHeadersWidth = 20;
            this.dataGridTabSim.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridTabSim.Size = new System.Drawing.Size(317, 299);
            this.dataGridTabSim.TabIndex = 6;
            // 
            // dgSimbolo
            // 
            this.dgSimbolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgSimbolo.HeaderText = "Simbolo";
            this.dgSimbolo.Name = "dgSimbolo";
            this.dgSimbolo.ReadOnly = true;
            this.dgSimbolo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgDireccion
            // 
            this.dgDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDireccion.HeaderText = "Direccion";
            this.dgDireccion.Name = "dgDireccion";
            this.dgDireccion.ReadOnly = true;
            this.dgDireccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgTipo
            // 
            this.dgTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgTipo.HeaderText = "Tipo";
            this.dgTipo.Name = "dgTipo";
            this.dgTipo.ReadOnly = true;
            this.dgTipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // intermedio
            // 
            this.intermedio.AllowUserToAddRows = false;
            this.intermedio.AllowUserToDeleteRows = false;
            this.intermedio.AllowUserToResizeColumns = false;
            this.intermedio.AllowUserToResizeRows = false;
            this.intermedio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.intermedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.intermedio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg,
            this.dgEtiqueta,
            this.dgInstruccion,
            this.dgOperando,
            this.dgCodObj,
            this.dgErrores});
            this.intermedio.Location = new System.Drawing.Point(357, 75);
            this.intermedio.Margin = new System.Windows.Forms.Padding(4);
            this.intermedio.Name = "intermedio";
            this.intermedio.ReadOnly = true;
            this.intermedio.RowHeadersWidth = 36;
            this.intermedio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.intermedio.Size = new System.Drawing.Size(828, 683);
            this.intermedio.TabIndex = 7;
            // 
            // dg
            // 
            this.dg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dg.FillWeight = 36F;
            this.dg.HeaderText = "CP";
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgEtiqueta
            // 
            this.dgEtiqueta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgEtiqueta.FillWeight = 46F;
            this.dgEtiqueta.HeaderText = "Etiqueta";
            this.dgEtiqueta.Name = "dgEtiqueta";
            this.dgEtiqueta.ReadOnly = true;
            this.dgEtiqueta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgInstruccion
            // 
            this.dgInstruccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgInstruccion.FillWeight = 46F;
            this.dgInstruccion.HeaderText = "Instrucción";
            this.dgInstruccion.Name = "dgInstruccion";
            this.dgInstruccion.ReadOnly = true;
            this.dgInstruccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgOperando
            // 
            this.dgOperando.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgOperando.FillWeight = 57.31839F;
            this.dgOperando.HeaderText = "Operando";
            this.dgOperando.Name = "dgOperando";
            this.dgOperando.ReadOnly = true;
            this.dgOperando.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgCodObj
            // 
            this.dgCodObj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgCodObj.FillWeight = 70F;
            this.dgCodObj.HeaderText = "Codigo Objeto";
            this.dgCodObj.Name = "dgCodObj";
            this.dgCodObj.ReadOnly = true;
            this.dgCodObj.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgErrores
            // 
            this.dgErrores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgErrores.FillWeight = 70F;
            this.dgErrores.HeaderText = "Errores";
            this.dgErrores.Name = "dgErrores";
            this.dgErrores.ReadOnly = true;
            this.dgErrores.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tbPrograma
            // 
            this.tbPrograma.AcceptsTab = true;
            this.tbPrograma.Location = new System.Drawing.Point(57, 75);
            this.tbPrograma.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrograma.Multiline = true;
            this.tbPrograma.Name = "tbPrograma";
            this.tbPrograma.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPrograma.Size = new System.Drawing.Size(287, 682);
            this.tbPrograma.TabIndex = 8;
            this.tbPrograma.TextChanged += new System.EventHandler(this.tbPrograma_TextChanged);
            // 
            // tbLinea
            // 
            this.tbLinea.BackColor = System.Drawing.SystemColors.Control;
            this.tbLinea.Enabled = false;
            this.tbLinea.Location = new System.Drawing.Point(16, 75);
            this.tbLinea.Margin = new System.Windows.Forms.Padding(4);
            this.tbLinea.Multiline = true;
            this.tbLinea.Name = "tbLinea";
            this.tbLinea.ReadOnly = true;
            this.tbLinea.Size = new System.Drawing.Size(39, 682);
            this.tbLinea.TabIndex = 9;
            this.tbLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LongitudPrograma
            // 
            this.LongitudPrograma.AutoSize = true;
            this.LongitudPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongitudPrograma.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LongitudPrograma.Location = new System.Drawing.Point(1052, 763);
            this.LongitudPrograma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LongitudPrograma.Name = "LongitudPrograma";
            this.LongitudPrograma.Size = new System.Drawing.Size(12, 17);
            this.LongitudPrograma.TabIndex = 10;
            this.LongitudPrograma.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1188, 542);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Registros";
            // 
            // tbRegistros
            // 
            this.tbRegistros.Location = new System.Drawing.Point(1193, 570);
            this.tbRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.tbRegistros.Multiline = true;
            this.tbRegistros.Name = "tbRegistros";
            this.tbRegistros.ReadOnly = true;
            this.tbRegistros.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbRegistros.Size = new System.Drawing.Size(316, 187);
            this.tbRegistros.TabIndex = 20;
            this.tbRegistros.WordWrap = false;
            // 
            // btnEnsamblar
            // 
            this.btnEnsamblar.Enabled = false;
            this.btnEnsamblar.Location = new System.Drawing.Point(16, 762);
            this.btnEnsamblar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnsamblar.Name = "btnEnsamblar";
            this.btnEnsamblar.Size = new System.Drawing.Size(328, 28);
            this.btnEnsamblar.TabIndex = 21;
            this.btnEnsamblar.Text = "Ensamblar";
            this.btnEnsamblar.UseVisualStyleBackColor = true;
            this.btnEnsamblar.Click += new System.EventHandler(this.btnEnsamblar_Click);
            // 
<<<<<<< HEAD
            // cargarOtroArchivoToolStripMenuItem
            // 
            this.cargarOtroArchivoToolStripMenuItem.Name = "cargarOtroArchivoToolStripMenuItem";
            this.cargarOtroArchivoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cargarOtroArchivoToolStripMenuItem.Text = "Cargar otro archivo";
            this.cargarOtroArchivoToolStripMenuItem.Click += new System.EventHandler(this.cargarOtroArchivoToolStripMenuItem_Click);
=======
            // cargadorToolStripMenuItem1
            // 
            this.cargadorToolStripMenuItem1.Name = "cargadorToolStripMenuItem1";
            this.cargadorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cargadorToolStripMenuItem1.Text = "Cargador";
            this.cargadorToolStripMenuItem1.Click += new System.EventHandler(this.cargadorToolStripMenuItem1_Click);
>>>>>>> e62345c310b273d41a8eb9493a71ef38b2fc3d78
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 790);
            this.Controls.Add(this.btnEnsamblar);
            this.Controls.Add(this.tbRegistros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LongitudPrograma);
            this.Controls.Add(this.tbLinea);
            this.Controls.Add(this.tbPrograma);
            this.Controls.Add(this.intermedio);
            this.Controls.Add(this.dataGridTabSim);
            this.Controls.Add(this.tbErrores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SICXE";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTabSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intermedio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridTabSim;
        private System.Windows.Forms.DataGridView intermedio;
        private System.Windows.Forms.TextBox tbPrograma;
        private System.Windows.Forms.TextBox tbLinea;
        private System.Windows.Forms.ToolStripMenuItem paso1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analizarCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarArchivoIntermedioToolStripMenuItem;
        private System.Windows.Forms.Label LongitudPrograma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem paso2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigoObjetoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEtiqueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgInstruccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgOperando;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgErrores;
        private System.Windows.Forms.ToolStripMenuItem generarRegistrosToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRegistros;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Button btnEnsamblar;
        private System.Windows.Forms.ToolStripMenuItem cargadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simuladorToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSimbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTipo;
        private System.Windows.Forms.ToolStripMenuItem cargadorToolStripMenuItem1;
<<<<<<< HEAD
        public System.Windows.Forms.TextBox tbErrores;
        private System.Windows.Forms.ToolStripMenuItem cargarOtroArchivoToolStripMenuItem;
=======
>>>>>>> e62345c310b273d41a8eb9493a71ef38b2fc3d78
    }
}

