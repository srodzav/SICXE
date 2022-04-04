using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Web;

namespace SICXE
{

    #region VALORES

    public enum Instrucciones
    { // Valor CodOp en DECIMAL
        ADD = 24, ADDF = 88, ADDR = 144, AND = 64, CLEAR = 180, COMP = 40, COMPF = 136, COMPR = 160, DIV = 36,
        DIVF = 100, DIRVR = 156, FIX = 196, FLOAT = 192, HIO = 244, J = 60, JEQ = 48, JGT = 52, JLT = 56, JSUB = 72,
        LDA = 0, LDB = 104, LDCH = 80, LDF = 112, LDL = 8, LDS = 108, LDT = 116, LDX = 04, LPS = 208, MUL = 32, MULR = 152,
        MULF = 96, NORM = 200, OR = 68, RD = 216, RMO = 172, RSUB = 76, SHIFTL = 164, SHIFTR = 168, SIO = 240, SSK = 236,
        STA = 12, STB = 120, STCH = 84, STF = 128, STI = 212, STL = 20, STS = 124, STSW = 232, STT = 132, STX = 16,
        SUB = 28, SUBF = 92, SUBR = 148, SUC = 176, TD = 224, TIO = 248, TIX = 44, TIXR = 184, WD = 220
    }

    public enum Registros
    { // Registros
        A = 0, X = 1, L = 2, B = 3, S = 4, T = 5, F = 6
    }

    public enum Directivas
    { // Directivas
        START, END, BYTE, WORD, RESB, RESW
    }

    #endregion

    public partial class Form1 : Form
    {

        #region INSTRUCCIONES

        public List<string> Instr1 = new List<string>
        { // Instrucciones Formato 1
            "FIX", "FLOAT", "HIO", "NORM", "SIO", "TIO"
        };

        public List<string> Instr2 = new List<string>
        { // Instrucciones Formato 2
            "ADDR", "CLEAR", "COMPR", "DIVR", "MULR", "RMO", "SHIFTL", "SHIFTR", "SUBR", "SVC", "TIXR"
        };

        public List<string> Instr3 = new List<string>
        { // Instrucciones Formato 3
            "ADD", "ADDF", "AND", "COMP", "COMPF", "DIV", "DIVF", "J", "JEQ", "JGT", "JLT",
            "JSUB", "LDA", "LDB", "LDCH", "LDF", "LDL", "LDS", "LDT", "LDX", "LPS",
            "MUL", "MULF", "OR", "RD", "RSUB", "SSK", "STA", "STB", "STCH", "STF", "STI",
            "STL", "STS", "STSW", "STT", "STX", "SUB", "SUBF", "TD", "TIX", "WD"
        };

        public List<string> Instr4 = new List<string>
        { // Instrucciones Formato 4
            "+ADD", "+ADDF", "+AND", "+COMP", "+COMPF", "+DIV", "+DIVF", "+J", "+JEQ", "+JGT", "+JLT",
            "+JSUB", "+LDA", "+LDB", "+LDCH", "+LDF", "+LDL", "+LDS", "+LDT", "+LDX", "+LPS",
            "+MUL", "+MULF", "+OR", "+RD", "+RSUB", "+SSK", "+STA", "+STB", "+STCH", "+STF", "+STI",
            "+STL", "+STS", "+STSW", "+STT", "+STX", "+SUB", "+SUBF", "+TD", "+TIX", "+WD"
        };

        public List<string> Directivas = new List<string>
        {
             "START", "END", "BYTE", "WORD", "RESB", "RESW", "BASE"
        };

        public List<string> Registros = new List<string>
        {
             "A", "X", "L", "B", "S", "T", "F"
        };

        public List<string> NoCODOP = new List<string>
        {
             "START", "END", "RESB", "RESW", "BASE"
        };

        public List<string> SiCODOP = new List<string>
        {
             "WORD", "BYTE", "BASE"
        };

        #endregion

        #region VARIABLES

        // PRE PROGRAMA
        public string nombre, ruta;
        private Programa prog;
        // PASO 1
        public string CP;
        public string OperandoMod;
        private int LongPrograma;
        // PASO 2
        public string n, i, x, b, p, e;
        public string BASE;
        private int regIns2 = 0;
        private string bytetxt;
        private string wordtxt;
        public string TA;
        // REGISTROS
        private string regNombre;

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region BOTONES

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        { // Abre un archivo en formato .S
            OpenFileDialog open = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = "Archivo SIC|*.s"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                ruta = Directory.GetParent(open.FileName).ToString();
                tbPrograma.Lines = File.ReadAllLines(open.FileName);
                string[] files = open.FileName.Split((char)92);
                string[] file = files[files.Length - 1].Split('.');
                nombre = file[0]; // Se guarda el nombre del archivo
                tbPrograma_TextChanged(this, null); // Se carga en el textbox 

                tbPrograma.Enabled = true;

                prog = new Programa();
                // Se resetean el Archivo Intermedio, el TabSim y los Errores
                intermedio.Rows.Clear();
                dataGridTabSim.Rows.Clear();
                tbErrores.Clear();
                tbRegistros.Clear();

                btnsArchivo(true, true, true, true, true, true);
            }
            paso1ToolStripMenuItem.Enabled = true;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbPrograma.Text = "";
            tbLinea.Text = "";
            tbErrores.Text = "";
            nombre = "";
            ActiveForm.Text = "SIC";
            LongitudPrograma.Text = "";
            tbPrograma.Enabled = true;

            prog = new Programa();
            intermedio.Rows.Clear();
            dataGridTabSim.Rows.Clear();
            tbErrores.Clear();
            tbRegistros.Clear();
            paso1ToolStripMenuItem.Enabled = true;
            btnsArchivo(true,true,true,true,true,true);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ruta != null)
            {
                File.WriteAllLines(ruta + @"\" + nombre + ".s", tbPrograma.Lines);
                tbPrograma.DeselectAll();
            }
            else
            {
                guardarComoToolStripMenuItem.PerformClick();
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                InitialDirectory = Application.StartupPath + "\\example",
                Filter = "SICXE|*.s"
            };
            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(save.FileName, tbPrograma.Lines);
                tbPrograma.DeselectAll();
                string[] files = save.FileName.Split((char)92);
                string[] file = files[files.Length - 1].Split('.');
                nombre = file[0];
                ruta = Directory.GetParent(save.FileName).ToString();
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbPrograma.Text = "";
            tbLinea.Text = "";
            tbErrores.Text = "";
            nombre = "";
            LongitudPrograma.Text = "";
            intermedio.Rows.Clear();
            dataGridTabSim.Rows.Clear();
            tbErrores.Clear();
            tbRegistros.Clear();

            btnsArchivo(true, true, false, false, false, true);
            tbPrograma.Enabled = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void btnsArchivo(bool nuevo, bool abrir, bool guardar, bool guardarComo, bool cerrar, bool salir)
        {
            nuevoToolStripMenuItem.Enabled = nuevo;
            abrirToolStripMenuItem.Enabled = abrir;
            guardarToolStripMenuItem.Enabled = guardar;
            guardarComoToolStripMenuItem.Enabled = guardarComo;
            cerrarToolStripMenuItem.Enabled = cerrar;
            salirToolStripMenuItem.Enabled = salir;
        }

        private void tbPrograma_TextChanged(object sender, EventArgs e)
        {
            tbLinea.Text = "";
            int cont = 1;
            foreach (string line in tbPrograma.Lines)
            { // Se carga el programa
                tbLinea.Text += cont.ToString() + string.Format(Environment.NewLine);
                cont++;
            }
        }

        private void btnEnsamblar_Click(object sender, EventArgs e)
        {
            analizaCodigo();
            generaArchivo();
            codigoObjeto();
            generaRegistros();
        }


        #endregion

        #region PASO 1

        private void analizarCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        { // GENERA ERRORES A LA HORA DE ANALIZAR CÓDIGO
            analizaCodigo();
        }

        private void analizaCodigo()
        {
            if (tbPrograma.Text != "")
            {
                int cont = 1;
                List<string> results = new List<string>();
                tbErrores.Clear();
                prog.lineas.Clear();
                foreach (string line in tbPrograma.Lines)
                { // Recorrido linea por linea del programa fuente
                    if (line != "")
                    {
                        Linea linea = new Linea(line); // Se crea una linea 
                        prog.lineas.Add(linea); // Se añade la linea al programa
                        // Creacion de las partes del ANTLR4
                        GramaticaLexer lex = new GramaticaLexer(new AntlrInputStream(line + Environment.NewLine));
                        CommonTokenStream tokens = new CommonTokenStream(lex);
                        GramaticaParser parser = new GramaticaParser(tokens);
                        try
                        { // Try catch de errores
                            parser.prog();
                            if (parser.NumberOfSyntaxErrors != 0)
                            {
                                results.Add("Error en linea: " + (cont).ToString());
                                prog.lineas[prog.lineas.Count - 1].Error = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            throw;
                        }
                        cont++; // Contador para señalar en que fila esta el error
                        tbPrograma.DeselectAll();
                    }
                }
                if (results.Any())
                {
                    tbErrores.Lines = results.ToArray();
                }
                else
                {
                    tbErrores.Text = "Sin errores";
                }
                generarArchivoIntermedioToolStripMenuItem.Enabled = true;
                // Creacion del archivo de errores
                File.WriteAllLines(ruta + @"\" + $"errores_{nombre}.t", tbErrores.Lines);
                intermedio.Rows.Clear();
                dataGridTabSim.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Favor de cargar un programa");
            }
        }

        private void generarArchivoIntermedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generaArchivo();
        }

        private void generaArchivo()
        {
            // Definir la estructura del DataGridView
            intermedio.RowHeadersWidth = 60;
            dataGridTabSim.Rows.Clear();
            intermedio.Rows.Clear();

            // Inicio de contador de programa
            int contador = prog.lineas[0].Operando.ToDec();

            //Recorrido principal
            for (int i = 0; i < prog.lineas.Count; i++)
            {
                CP = contador.ToHex();
                OperandoMod = prog.lineas[i].Operando;
                intermedio.Rows.Add(CP, prog.lineas[i].Etiqueta, prog.lineas[i].CodigoOp, OperandoMod);

                if (!prog.lineas[i].Error)
                { // Si no hay error se aumenta el contador dependiendo de que formato es la instruccion
                    if (Instr4.Contains(prog.lineas[i].CodigoOp))
                    {
                        contador += 4;
                    }
                    else if (Instr3.Contains(prog.lineas[i].CodigoOp))
                    {
                        contador += 3;
                    }
                    else if (Instr2.Contains(prog.lineas[i].CodigoOp))
                    {
                        contador += 2;
                    }
                    else if (Instr1.Contains(prog.lineas[i].CodigoOp))
                    {
                        contador += 1;
                    }
                    else if (Directivas.Contains(prog.lineas[i].CodigoOp))
                    { // Si es una directiva evalua individualmente
                        if (prog.lineas[i].CodigoOp == "BYTE")
                        { // En caso de que sea BYTE
                            if (prog.lineas[i].Operando.Contains("X"))
                            { // Si es X, divide el total y lo redondea hacia arriba
                                contador += (int)Math.Ceiling(((double)prog.lineas[i].CodigoOp.Length) / 2);
                            }
                            else if (prog.lineas[i].Operando.Contains("C"))
                            { // Si es C, agrega el total de bytes
                                contador += (prog.lineas[i].Operando.Length - 3);
                            }
                        }
                        else if (prog.lineas[i].CodigoOp == "WORD")
                        { // Si es WORD solo agrega 3 al contador
                            contador += 3;
                        }
                        else if (prog.lineas[i].CodigoOp == "RESB")
                        { // Si es RESB convierte a Hexadecimal y lo agrega
                            contador += prog.lineas[i].Operando.ToDec();
                        }
                        else if (prog.lineas[i].CodigoOp == "RESW")
                        { // Si es RESW multiplica por 3 y convierte a Hexadecimal para agregarlo
                            contador += prog.lineas[i].Operando.ToDec() * 3;
                        }
                    }
                    if (prog.lineas[i].Etiqueta != null && prog.lineas[i].Etiqueta != "" && prog.lineas[i].Etiqueta != " " && i != 0)
                    { // Si etiqueta contiene algo y no es el nombre del programa, lo agrega al TabSim
                        dataGridTabSim.Rows.Add(prog.lineas[i].Etiqueta, CP);
                    }
                }
            }

            // Ciclo para guardar la BASE
            for (int i = 0; i < prog.lineas.Count; i++)
            {
                if (!prog.lineas[i].Error)
                {
                    if (prog.lineas[i].CodigoOp == "BASE")
                    {
                        foreach (DataGridViewRow row in dataGridTabSim.Rows)
                        {
                            if (row.Cells[0].Value.ToString() == prog.lineas[i].Operando)
                            {
                                BASE = row.Cells[1].Value.ToString();
                                break;
                            }
                        }
                    }
                }
            }

            #region ARCHIVOS

            // setup for export
            dataGridTabSim.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridTabSim.SelectAll();
            // hiding row headers to avoid extra \t in exported text
            var rowHeaders = dataGridTabSim.RowHeadersVisible;
            dataGridTabSim.RowHeadersVisible = false;

            // Longitud de Programa, SE CALCULA EN DECIMAL Y SE CONVIERTE EN HEXADECIMAL
            LongPrograma = CP.ToDec() - intermedio.Value(0, 0).ToDec(); // Restamos el contador HEX al valor inicial
            LongPrograma = CP.ToDec() - intermedio[0, 0].Value.ToString().ToDec(); // Valor final - valor inicial
            LongitudPrograma.Text = "Total: " + LongPrograma.ToHex() + " H";

            // ! creating text from grid values
            string content = dataGridTabSim.GetClipboardContent().GetText();
            content += $"\n{LongitudPrograma.Text}";

            // restoring grid state
            dataGridTabSim.ClearSelection();
            dataGridTabSim.RowHeadersVisible = rowHeaders;

            System.IO.File.WriteAllText(ruta + @"\" + $"tabsim_{nombre}.txt", content);

            paso2ToolStripMenuItem.Enabled = true;
            códigoObjetoToolStripMenuItem.Enabled = true;

            #endregion
        }

        #endregion

        #region PASO 2

        private void códigoObjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codigoObjeto();
        }

        private void codigoObjeto()
        {
            int contador = prog.lineas[0].Operando.ToDec();
            for (int i = 0; i < prog.lineas.Count; i++)
            {
                //MessageBox.Show(prog.lineas[i].n + " " + prog.lineas[i].i + " " + prog.lineas[i].x + " " + prog.lineas[i].b + " " + prog.lineas[i].p + " " + prog.lineas[i].e + " " + " | " + prog.lineas[i].CodigoOp + ": " + prog.lineas[i].Operando);
                if (!prog.lineas[i].Error)
                {
                    if (!NoCODOP.Contains(prog.lineas[i].CodigoOp))
                    {
                        if (Instr1.Contains(prog.lineas[i].CodigoOp))
                        {
                            foreach (Instrucciones instr in Enum.GetValues(typeof(Instrucciones)))
                            {
                                if (prog.lineas[i].CodigoOp == instr.ToString())
                                {
                                    intermedio.Rows[i].Cells[4].Value = instr.GetHashCode().ToString("X");
                                }
                            }
                        }
                        else if (Instr2.Contains(prog.lineas[i].CodigoOp))
                        {
                            foreach (Instrucciones instr in Enum.GetValues(typeof(Instrucciones)))
                            {
                                if (prog.lineas[i].CodigoOp == instr.ToString())
                                {
                                    intermedio.Rows[i].Cells[4].Value = instr.GetHashCode().ToString("X");
                                }
                            }
                            foreach (Registros reg in Enum.GetValues(typeof(Registros)))
                            {
                                if (prog.lineas[i].Operando.Contains(reg.ToString()))
                                {
                                    intermedio.Rows[i].Cells[4].Value += reg.GetHashCode().ToString("X"); regIns2++;
                                }
                            }
                            if (regIns2 != 2)
                                intermedio.Rows[i].Cells[4].Value += "0";
                            regIns2 = 0;
                        }
                        else if (Instr3.Contains(prog.lineas[i].CodigoOp))
                        {
                            foreach (Instrucciones instr in Enum.GetValues(typeof(Instrucciones)))
                            {
                                if (prog.lineas[i].CodigoOp == "RSUB")
                                    intermedio.Rows[i].Cells[4].Value = "4F0000";
                                if (prog.lineas[i].CodigoOp == instr.ToString())
                                {
                                    CodigoObjetoPaso2(instr.GetHashCode().ToString("X"), prog.lineas[i].Operando, prog.lineas[i].n, prog.lineas[i].i, prog.lineas[i].x, prog.lineas[i].b, prog.lineas[i].p, prog.lineas[i].e, i, false);
                                }
                            }
                        }
                        else if (Instr4.Contains(prog.lineas[i].CodigoOp))
                        {
                            foreach (Instrucciones instr in Enum.GetValues(typeof(Instrucciones)))
                            {
                                string instr2;
                                instr2 = "+" + instr.ToString();
                                if (prog.lineas[i].CodigoOp == "+RSUB")
                                    intermedio.Rows[i].Cells[4].Value = "4F000000";
                                if (prog.lineas[i].CodigoOp == instr2.ToString()) //prog.lineas[i].CodigoOp.Contains(instr.ToString())
                                {
                                    CodigoObjetoPaso2(instr.GetHashCode().ToString("X"), prog.lineas[i].Operando, prog.lineas[i].n, prog.lineas[i].i, prog.lineas[i].x, prog.lineas[i].b, prog.lineas[i].p, prog.lineas[i].e, i, true);
                                    break;
                                }
                            }
                        }
                        else if (SiCODOP.Contains(prog.lineas[i].CodigoOp))
                        {
                            if (prog.lineas[i].CodigoOp == "WORD")
                            {
                                if (prog.lineas[i].Operando.Length == 6)
                                    wordtxt = prog.lineas[i].Operando;
                                else
                                    wordtxt = "0000" + prog.lineas[i].Operando;
                                intermedio.Rows[i].Cells[4].Value = wordtxt;
                            }
                            if (prog.lineas[i].CodigoOp == "BYTE")
                            {
                                if (prog.lineas[i].Operando.Contains("C'"))
                                {
                                    bytetxt = prog.lineas[i].Operando.Replace("C'", "");
                                    bytetxt = bytetxt.Replace("'", "");
                                    foreach (char c in bytetxt)
                                    {
                                        intermedio.Rows[i].Cells[4].Value += System.Convert.ToInt32(c).ToString("X");
                                    }
                                }
                                if (prog.lineas[i].Operando.Contains("X'"))
                                {
                                    bytetxt = prog.lineas[i].Operando.Replace("X'", "0");
                                    bytetxt = bytetxt.Replace("'", "");
                                    intermedio.Rows[i].Cells[4].Value = bytetxt;
                                }
                            }
                            if (prog.lineas[i].CodigoOp == "BASE")
                            {
                                foreach (DataGridViewRow row in dataGridTabSim.Rows)
                                {
                                    if (row.Cells[0].Value.ToString() == prog.lineas[i].Operando)
                                    {
                                        BASE = row.Cells[1].Value.ToString();
                                        intermedio.Rows[i].Cells[4].Value = "----";
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        intermedio.Rows[i].Cells[4].Value = "----";
                    }
                }
                else
                {
                    if (Instr1.Contains(prog.lineas[i].CodigoOp) || Instr2.Contains(prog.lineas[i].CodigoOp) || Instr3.Contains(prog.lineas[i].CodigoOp) || Instr4.Contains(prog.lineas[i].CodigoOp) || Directivas.Contains(prog.lineas[i].CodigoOp))
                    {
                        intermedio.Rows[i].Cells[4].Value = "Error: Sintaxis";
                    }
                    else
                    {
                        intermedio.Rows[i].Cells[4].Value = "Error: Instruccion no existe";
                    }
                }
            }

            #region ARCHIVO

            // setup for export
            intermedio.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            intermedio.SelectAll();
            // hiding row headers to avoid extra \t in exported text
            var rowHeaders = intermedio.RowHeadersVisible;
            intermedio.RowHeadersVisible = false;

            // ! creating text from grid values
            string content = intermedio.GetClipboardContent().GetText();

            // restoring grid state
            intermedio.ClearSelection();
            intermedio.RowHeadersVisible = rowHeaders;

            System.IO.File.WriteAllText(ruta + @"\" + $"archivointermedio_{nombre}.txt", content);

            generarRegistrosToolStripMenuItem.Enabled = true;

            #endregion
        }

        private void CodigoObjetoPaso2(string ins, string op, string n, string i, string x, string b, string p, string e, int cont, bool indexado)
        {
            string simple, indirecto, inmediato, temp, desp = "", CP = "", buscado = "", buscadoaux = "", agregado = "", constante = "";
            bool found = false, found2 = false, cons = false;
            int num1, num2, res;
            string binario = Convert.ToString(Convert.ToInt32(ins.ToString(), 16), 2);
            if (binario.Length == 3)
                binario = "00000" + binario;
            else if (binario.Length == 4)
                binario = "0000" + binario;
            else if (binario.Length == 5)
                binario = "000" + binario;
            else if (binario.Length == 6)
                binario = "00" + binario;
            else if (binario.Length == 7)
                binario = "0" + binario;
            else if (binario == "0")
                binario = "00000000";
            binario = binario.Remove(binario.Length - 2);
            binario += n + i + x;

            if (indexado == true)
            {
                buscado = op;
                foreach (DataGridViewRow row in dataGridTabSim.Rows)
                {
                    simple = row.Cells[0].Value.ToString(); indirecto = "@" + row.Cells[0].Value.ToString(); inmediato = "#" + row.Cells[0].Value.ToString();
                    if (simple == op || indirecto == op || inmediato == op)
                    {
                        temp = row.Cells[1].Value.ToString().Remove(0, 2);
                        binario += b + p + e;
                        binario = ConvierteHexa(binario) + "0";
                        binario += temp;
                        binario += "*";
                        found = true;
                        break;
                    }
                    else if (op.Any(char.IsDigit) || op.Contains(",X"))
                    {
                        b = "1";
                        p = "1";
                        binario += b + p + e;
                        binario = ConvierteHexa(binario);
                        found = true;
                        binario += "FFFFF";
                        for (int j = 0; j < prog.lineas.Count; j++)
                        {
                            if(intermedio.Rows[j].Cells[3].Value.ToString() == buscado)
                            {
                                intermedio.Rows[j].Cells[5].Value = "Error: No existe combinacion MD";
                            }
                        }
                        break;
                    }
                }
                if (!found)
                {
                    b = "1";
                    p = "1";
                    binario += b + p + e;
                    binario = ConvierteHexa(binario);
                    binario += "FFFFF";
                    for (int j = 0; j < prog.lineas.Count; j++)
                    {
                        if (intermedio.Rows[j].Cells[3].Value == op)
                        {
                            intermedio.Rows[j].Cells[5].Value = "Error: Simbolo no existe";
                        }
                    }
                }
                intermedio.Rows[cont].Cells[4].Value = binario ;
            }
            else
            {
                if (op.Contains('@'))
                {
                    constante = op;
                    constante = constante.Replace("#", "");
                    constante = constante.Replace("@", "");
                    if (constante.Any(char.IsDigit))
                    {
                        b = "0";
                        p = "0";
                        binario += b + p + e;
                        binario = ConvierteHexa(binario);
                        desp = constante;
                        found = true;
                        cons = true;
                    }
                    foreach (DataGridViewRow row in dataGridTabSim.Rows)
                    {
                        simple = row.Cells[0].Value.ToString(); indirecto = "@" + row.Cells[0].Value.ToString(); inmediato = "#" + row.Cells[0].Value.ToString();
                        if (simple == op || indirecto == op || inmediato == op)
                        {
                            TA = row.Cells[1].Value.ToString().Remove(0, 2);
                            buscado = row.Cells[0].Value.ToString();
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        desp = "FFF";
                        b = "1";
                        p = "1";
                        binario += b + p + e;
                        binario = ConvierteHexa(binario);
                        for (int j = 0; j < prog.lineas.Count; j++)
                        {
                            if (intermedio.Rows[j].Cells[3].Value == op)
                            {
                                intermedio.Rows[j].Cells[5].Value = "Error: Simbolo no encontrado en tabsim";
                            }
                        }
                    }
                    if (!cons)
                    {
                        foreach (DataGridViewRow row in intermedio.Rows)
                        {
                            buscadoaux = row.Cells[3].Value.ToString();
                            buscadoaux = buscadoaux.Replace("#","");
                            buscadoaux = buscadoaux.Replace("@", "");
                            if (found2 == true)
                            {
                                CP = row.Cells[0].Value.ToString();
                                break;
                            }
                            if (buscadoaux == buscado)
                            {
                                found2 = true;
                            }

                        }
                        num1 = Convert.ToInt32(TA, 16);
                        num2 = Convert.ToInt32(CP, 16);
                        res = num1 - num2;
                        if (res >= -2048 && res <= 2048)
                        {
                            agregado = res.ToString("X");
                            try { agregado = agregado.Remove(0, 5); } catch (Exception ex) { }
                            b = "0";
                            p = "1";
                            binario += b + p + e;
                            binario = ConvierteHexa(binario);
                            desp = agregado;
                            if (desp.Length == 2)
                                desp = "0" + desp;
                            if (desp.Length == 1)
                                desp = "00" + desp;
                        }
                        else
                        {
                            num1 = Convert.ToInt32(TA, 16);
                            num2 = Convert.ToInt32(BASE, 16);
                            res = num1 - num2;
                            agregado = res.ToString("X");
                            try { agregado = agregado.Remove(0, 5); } catch (Exception ex) { }
                            if (res >= 0 && res <= 4095)
                            {
                                b = "1";
                                p = "0";
                                binario += b + p + e;
                                binario = ConvierteHexa(binario);
                                desp = agregado;
                            }
                            else
                            {
                                b = "1";
                                p = "1";
                                binario += b + p + e;
                                binario = ConvierteHexa(binario);
                                desp = "FFF";
                                for (int j = 0; j < prog.lineas.Count; j++)
                                {
                                    if (intermedio.Rows[j].Cells[3].Value == op)
                                    {
                                        intermedio.Rows[j].Cells[5].Value = "Error: No relativo a CP/B";
                                    }
                                }
                            }
                        }
                    }
                    else
                    { 
                        if (desp.Length == 1)
                            desp = "00" + desp;
                        if (desp.Length == 2)
                            desp = "0" + desp;
                    }   
                    found2 = false;
                    binario += desp;
                    intermedio.Rows[cont].Cells[4].Value = binario;
                }
                else if (op.Contains('#'))
                {
                    constante = op;
                    constante = constante.Replace("#", "");
                    constante = constante.Replace("@", "");
                    if (constante.Any(char.IsDigit))
                    {
                        b = "0";
                        p = "0";
                        binario += b + p + e;
                        binario = ConvierteHexa(binario);
                        desp = constante;
                        found = true;
                        cons = true;
                    }
                    foreach (DataGridViewRow row in dataGridTabSim.Rows)
                    {
                        simple = row.Cells[0].Value.ToString(); indirecto = "@" + row.Cells[0].Value.ToString(); inmediato = "#" + row.Cells[0].Value.ToString();
                        if (simple == op || indirecto == op || inmediato == op)
                        {
                            TA = row.Cells[1].Value.ToString().Remove(0, 2);
                            buscado = row.Cells[0].Value.ToString();
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        desp = "FFF";
                        b = "1";
                        p = "1";
                        binario += b + p + e;
                        binario = ConvierteHexa(binario);
                        for (int j = 0; j < prog.lineas.Count; j++)
                        {
                            if (intermedio.Rows[j].Cells[3].Value == op)
                            {
                                intermedio.Rows[j].Cells[5].Value = "Error: Simbolo no encontrado en tabsim";
                            }
                        }
                    }
                    if (!cons)
                    {
                        foreach (DataGridViewRow row in intermedio.Rows)
                        {
                            buscadoaux = row.Cells[3].Value.ToString();
                            buscadoaux = buscadoaux.Replace("#", "");
                            buscadoaux = buscadoaux.Replace("@", "");
                            if (found2 == true)
                            {
                                CP = row.Cells[0].Value.ToString();
                                break;
                            }
                            if (buscadoaux == buscado)
                            {
                                found2 = true;
                            }

                        }
                        num1 = Convert.ToInt32(TA, 16);
                        num2 = Convert.ToInt32(CP, 16);
                        res = num1 - num2;
                        if (res >= -2048 && res <= 2048)
                        {
                            agregado = res.ToString("X");
                            agregado = agregado.Remove(0, 5);
                            b = "0";
                            p = "1";
                            binario += b + p + e;
                            binario = ConvierteHexa(binario);
                            desp = agregado;
                            if (desp.Length == 2)
                                desp = "0" + desp;
                            if (desp.Length == 1)
                                desp = "00" + desp;
                        }
                        else
                        {
                            num1 = Convert.ToInt32(TA, 16);
                            num2 = Convert.ToInt32(BASE, 16);
                            res = num1 - num2;
                            agregado = res.ToString("X");
                            try { agregado = agregado.Remove(0, 5); } catch (Exception ex) { }
                            if (res >= 0 && res <= 4095)
                            {
                                b = "1";
                                p = "0";
                                binario += b + p + e;
                                binario = ConvierteHexa(binario);
                                desp = agregado;
                            }
                            else
                            {
                                b = "1";
                                p = "1";
                                binario += b + p + e;
                                binario = ConvierteHexa(binario);
                                desp = "FFF";
                                for (int j = 0; j < prog.lineas.Count; j++)
                                {
                                    if (intermedio.Rows[j].Cells[3].Value == op)
                                    {
                                        intermedio.Rows[j].Cells[5].Value = "Error: No relativo a CP/B";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (desp.Length == 1)
                            desp = "00" + desp;
                        if (desp.Length == 2)
                            desp = "0" + desp;
                    }
                    found2 = false;
                    binario += desp;
                    intermedio.Rows[cont].Cells[4].Value = binario;
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridTabSim.Rows)
                    {
                        if (op.Contains(",X"))
                            op = op.Replace(",X", "");
                        simple = row.Cells[0].Value.ToString(); indirecto = "@" + row.Cells[0].Value.ToString(); inmediato = "#" + row.Cells[0].Value.ToString();
                        if (simple == op || indirecto == op || inmediato == op)
                        {
                            TA = row.Cells[1].Value.ToString().Remove(0, 2);
                            buscado = row.Cells[0].Value.ToString();
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        desp = "FFF";
                        b = "1";
                        p = "1";
                        binario += b + p + e;
                        binario = ConvierteHexa(binario);
                        for (int j = 0; j < prog.lineas.Count; j++)
                        {
                            if (intermedio.Rows[j].Cells[3].Value == op && Instr3.Contains( intermedio.Rows[j].Cells[2].Value) && intermedio.Rows[j].Cells[2].Value.ToString() != "RSUB")
                            {
                                intermedio.Rows[j].Cells[5].Value = "Error: Simbolo no encontrado";
                            }
                        }
                    }
                    else
                    {
                        foreach (DataGridViewRow row in intermedio.Rows)
                        {
                            buscadoaux = row.Cells[3].Value.ToString();
                            if (buscadoaux.Contains(",X"))
                                buscadoaux = buscadoaux.Replace(",X", "");
                            buscadoaux = buscadoaux.Replace("#", "");
                            buscadoaux = buscadoaux.Replace("@", "");
                            if (found2 == true)
                            {
                                CP = row.Cells[0].Value.ToString();
                                break;
                            }
                            if (buscadoaux == buscado)
                            {
                                found2 = true;
                            }

                        }
                        num1 = Convert.ToInt32(TA, 16);
                        num2 = Convert.ToInt32(CP, 16);
                        res = num1 - num2;

                        if (res >= -2048 && res <= 2048)
                        {
                            agregado = res.ToString("X");
                            try
                            {
                                agregado = agregado.Remove(0, 5);
                            } catch (Exception ex) { }
                            b = "0";
                            p = "1";
                            binario += b + p + e;
                            binario = ConvierteHexa(binario);
                            desp = agregado;
                            if (desp.Length == 2)
                                desp = "0" + desp;
                            if (desp.Length == 1)
                                desp = "00" + desp;
                        }
                        else
                        {
                            num1 = Convert.ToInt32(TA, 16);
                            num2 = Convert.ToInt32(BASE, 16);
                            res = num1 - num2;
                            agregado = res.ToString("X");
                            agregado = agregado.Remove(0, 5);

                            if (res >= 0 && res <= 4095)
                            {
                                b = "1";
                                p = "0";
                                binario += b + p + e;
                                binario = ConvierteHexa(binario);
                                desp = agregado;
                            }
                            else
                            {
                                b = "1";
                                p = "1";
                                binario += b + p + e;
                                binario = ConvierteHexa(binario);
                                desp = "FFF";
                                for (int j = 0; j < prog.lineas.Count; j++)
                                {
                                    if (intermedio.Rows[j].Cells[3].Value == op)
                                    {
                                        intermedio.Rows[j].Cells[5].Value = "Error: No relativo a CP/B";
                                    }
                                }
                            }
                        }
                    }
                    found2 = false;
                    binario += desp;
                    intermedio.Rows[cont].Cells[4].Value = binario;
                }
            }
        }

        public string ConvierteHexa(string binario)
        {
            string hexa = "";
            string hx = "";
            string res = "";
            int i = 0;
            foreach (char c in binario)
            {
                hexa += c;
                i++;
                if (i == 4)
                {
                    hx = Convert.ToInt32(hexa, 2).ToString("X");
                    res += hx;
                    i = 0;
                    hexa = "";
                }
            }
            return res;
        }
        
        private void generarRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generaRegistros();
        }

        private void generaRegistros()
        {
            RegistroH();
            RegistroT();
            RegistroM();
            RegistroE();
            File.WriteAllLines(ruta + @"\" + $"registros_{nombre}" + ".obj", tbRegistros.Lines);
        }

        private void RegistroH()
        {
            string H = "H";
            string aux;
            if (intermedio.Value(0, 1).Length > 6)
            {
                H += intermedio.Value(0, 1).Substring(0, 6);
                regNombre = intermedio.Value(0, 1).Substring(0, 6);
            }
            else
            {
                H += intermedio.Value(0, 1);
                regNombre = intermedio.Value(0, 1);
                for (int i = H.Length - 1; i < 6; i++)
                {
                    H += " ";
                    regNombre += " ";
                }
            }
            aux = intermedio.Value(0, 3);
            while (aux.Length < 6)
            {
                aux = "0" + aux;
            }
            H += aux;
            aux = LongPrograma.ToHex();
            while (aux.Length < 6)
            {
                aux = "0" + aux;
            }
            H += aux;
            tbRegistros.Text += H + Environment.NewLine;
        }

        private void RegistroT()
        {
            List<string> T = new List<string>();
            List<string> DirT = new List<string>();
            string RegistroT = "";
            string temp;

            foreach (DataGridViewRow row in intermedio.Rows)
            {
                if (row.Cells[2].Value.ToString() != "START")
                {
                    if (row.Cells[2].Value.ToString() != "RESW" && row.Cells[2].Value.ToString() != "RESB" && row.Cells[2].Value.ToString() != "END")
                    {
                        if (!row.Cells[4].Value.ToString().StartsWith("Error") && !row.Cells[4].Value.ToString().StartsWith("----"))
                        {
                            if (RegistroT.Length + row.Cells[4].Value.ToString().Length <= 60)
                            {
                                if (RegistroT == "")
                                {
                                    DirT.Add(row.Cells[0].Value.ToString());
                                }
                                if (row.Cells[4].Value.ToString().Contains("Error: Simbolo no existe"))
                                    RegistroT += row.Cells[4].Value.ToString().Substring(0, row.Cells[4].Value.ToString().Length - 29);
                                else
                                {
                                    temp = row.Cells[4].Value.ToString();
                                    temp = temp.Replace("*", "");
                                    MessageBox.Show(temp);
                                    RegistroT += temp;
                                }
                            }
                            else
                            {
                                T.Add(RegistroT);
                                DirT.Add(row.Cells[0].Value.ToString());
                                RegistroT = row.Cells[4].Value.ToString();
                            }
                        }
                    }
                    else
                    {
                        if (row.Cells[2].Value.ToString() == "END")
                        {
                            if (RegistroT != "")
                            {
                                T.Add(RegistroT);
                                RegistroT = "";
                            }
                        }
                        else
                        {
                            T.Add(RegistroT);
                            RegistroT = "";
                        }
                    }
                }
            }

            T = T.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();

            for (int i = 0; i < T.Count; i++)
            {
                string DireccionT = "";
                string LongitudT = "";

                for (int j = DirT[i].Length; j < 6; j++)
                {
                    DireccionT += "0";
                }
                DireccionT += DirT[i];

                for (int j = (T[i].Length / 2).ToString("X").Length; j < 2; j++)
                {
                    LongitudT += "0";
                }
                LongitudT += (T[i].Length / 2).ToString("X");

                tbRegistros.Text += "T" + DireccionT + LongitudT + T[i] + Environment.NewLine;
            }
        }

        private void RegistroM()
        {
            string DireccionM = "";
            string Relocalizar = "";

            foreach (DataGridViewRow row in intermedio.Rows)
            {
                if (row.Cells[4].Value.ToString().Contains("*"))
                {
                    DireccionM = row.Cells[0].Value.ToString();
                    DireccionM = DireccionM.Replace("*", "");
                    if (row.Cells[2].Value.ToString().Contains("WORD"))
                        Relocalizar = "06";
                    if (row.Cells[2].Value.ToString().Contains("+"))
                        Relocalizar = "05";
                    tbRegistros.Text += "M" + DireccionM + Relocalizar + "+" + regNombre + Environment.NewLine;
                }
            }
        }

        private void RegistroE()
        {
            string E = "E";
            if (intermedio.Rows[intermedio.Rows.Count - 1].Cells[3].Value.ToString() != "")
            {
                foreach (DataGridViewRow row in dataGridTabSim.Rows)
                {
                    if (row.Cells[0].Value.ToString() == intermedio.Rows[intermedio.Rows.Count - 1].Cells[3].Value.ToString())
                    {
                        for (int i = row.Cells[1].Value.ToString().Length; i < 6; i++)
                        {
                            E += "0";
                        }
                        E += row.Cells[1].Value.ToString();
                        tbRegistros.Text += E;
                        return;
                    }
                }
                E += "FFFFFF";
                tbRegistros.Text += E;
            }
            else
            {
                foreach (DataGridViewRow row in intermedio.Rows)
                {
                    foreach (Instrucciones instr in Enum.GetValues(typeof(Instrucciones)))
                    {
                        if (row.Cells[2].Value.ToString() == instr.ToString())
                        {
                            for (int i = row.Cells[0].Value.ToString().Length; i < 6; i++)
                            {
                                E += "0";
                            }
                            E += row.Cells[0].Value.ToString();
                            tbRegistros.Text += E;
                            return;
                        }
                    }
                }
            }
        }

        #endregion

    }
}
