/*
 * LINEA SIRVE PARA LEER LINEA POR LINEA EL PROGRAMA FUENTE
 * EL CUAL MANDA Y CLASIFICA EL PROGRAMA FUENTE
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SICXE {

	public class Linea
    {
		public string Etiqueta { get; set; }
		public string CodigoOp { get; set; }
		public string Operando { get; set; }
        public string Tipo { get; set; }
        public bool Error { get; set; }
        public string TipoError { get; set; }
        public string n { get; set; }
        public string i { get; set; }
        public string x { get; set; }
        public string b { get; set; }
        public string p { get; set; }
        public string e { get; set; }

        public List<string> Instr1 = new List<string>
        {
            "FIX", "FLOAT", "HIO", "NORM", "SIO", "TIO"
        };
        public List<string> Instr2 = new List<string>
        {
            "ADDR", "CLEAR", "COMPR", "DIVR", "MULR", "RMO", "SHIFTL", "SHIFTR", "SUBR", "SVC", "TIXR"
        };
        public List<string> Instr3 = new List<string>
        {
            "ADD", "ADDF", "AND", "COMP", "COMPF", "DIV", "DIVF", "J", "JEQ", "JGT", "JLT",
            "JSUB", "LDA", "LDB", "LDCH", "LDF", "LDL", "LDS", "LDT", "LDX", "LPS",
            "MUL", "MULF", "OR", "RD", "RSUB", "SSK", "STA", "STB", "STCH", "STF", "STI",
            "STL", "STS", "STSW", "STT", "STX", "SUB", "SUBF", "TD", "TIX", "WD"
        };
        public List<string> Instr4 = new List<string>
        {
            "+ADD", "+ADDF", "+AND", "+COMP", "+COMPF", "+DIV", "+DIVF", "+J", "+JEQ", "+JGT", "+JLT",
            "+JSUB", "+LDA", "+LDB", "+LDCH", "+LDF", "+LDL", "+LDS", "+LDT", "+LDX", "+LPS",
            "+MUL", "+MULF", "+OR", "+RD", "+RSUB", "+SSK", "+STA", "+STB", "+STCH", "+STF", "+STI",
            "+STL", "+STS", "+STSW", "+STT", "+STX", "+SUB", "+SUBF", "+TD", "+TIX", "+WD"
        };
        public List<string> Directivas = new List<string>
        {
             "START", "END", "BYTE", "WORD", "RESB", "RESW", "BASE"
        };

        public Linea(string lin) {
            lin.Replace("\t", " ");
            lin = Regex.Replace(lin, @"\s+", " ");
            string[] valores = lin.Split(' ');

            //MessageBox.Show(valores[1]);

            if (Instr3.Contains(valores[1]))
            {
                if (valores.Length == 3)
                {
                    Etiqueta = valores[0];
                    CodigoOp = valores[1];
                    if (valores[2].Any(char.IsDigit))
                    {
                        if ((valores[2].Last() == 'h' || valores[2].Last() == 'H'))
                        {
                            n = "1";
                            i = "1";
                            x = "0";
                            b = "0";
                            p = "0";
                            e = "0";
                            Operando = valores[2].Remove(valores[2].Length - 1);
                        }
                        else
                        {
                            if (valores[2].Contains(",X"))
                            {
                                n = "1";
                                i = "1";
                                x = "1";
                                b = "0";
                                p = "0";
                                e = "0";
                                Operando = valores[2];
                            }
                            else if (valores[2].Contains("#"))
                            {
                                n = "0";
                                i = "1";
                                x = "0";
                                b = "0";
                                p = "0";
                                e = "0";
                                Operando = valores[2];
                            }
                            else if (valores[2].Contains("@"))
                            {
                                n = "1";
                                i = "0";
                                x = "0";
                                b = "0";
                                p = "0";
                                e = "0";
                                Operando = valores[2];
                            }
                            else
                            {
                                try
                                {
                                    n = "1";
                                    i = "1";
                                    x = "0";
                                    b = "0";
                                    p = "0";
                                    e = "0";
                                    Operando = Convert.ToInt32(valores[2]).ToHex();
                                }
                                catch
                                {
                                    n = "1";
                                    i = "1";
                                    x = "0";
                                    b = "0";
                                    p = "0";
                                    e = "0";
                                    Operando = valores[2];
                                }
                            }
                        }
                    }
                    else
                    {
                        Operando = valores[2];
                        if (valores[2].Contains(",X"))
                        {
                            n = "1";
                            i = "1";
                            x = "1";
                            e = "0";
                        } else if (valores[2].Contains("#"))
                        {
                            n = "0";
                            i = "1";
                            x = "0";
                            e = "0";
                        } else if (valores[2].Contains("@"))
                        {
                            n = "1";
                            i = "0";
                            x = "0";
                            e = "0";
                        } else
                        {
                            n = "1";
                            i = "1";
                            x = "0";
                            e = "0";
                        }
                    }
                }
                else if (valores[1] == "RSUB")
                {
                    Etiqueta = "";
                    CodigoOp = valores[1];
                    Operando = "";
                }
                else
                {
                    Etiqueta = "";
                    CodigoOp = valores[1];
                    if (valores[2].Any(char.IsDigit))
                    {
                        MessageBox.Show(lin);
                        if ((valores[2].Last() == 'h' || valores[2].Last() == 'H'))
                        {
                            n = "1";
                            i = "1";
                            x = "0";
                            b = "0";
                            p = "0";
                            e = "0";
                            Operando = valores[2].Remove(valores[2].Length - 1);
                        }
                        else
                        {
                            if (valores[2].Contains(",X"))
                            {
                                n = "1";
                                i = "1";
                                x = "1";
                                b = "0";
                                p = "0";
                                e = "0";
                                Operando = valores[2].Remove(valores[2].Length - 2);
                            }
                            else if (valores[2].Contains("#"))
                            {
                                n = "0";
                                i = "1";
                                x = "0";
                                b = "0";
                                p = "0";
                                e = "0";
                                Operando = valores[2];
                            }
                            else if (valores[2].Contains("@"))
                            {
                                n = "1";
                                i = "0";
                                x = "0";
                                b = "0";
                                p = "0";
                                e = "0";
                                Operando = valores[2];
                            }
                            else
                            {
                                n = "1";
                                i = "1";
                                x = "0";
                                b = "0";
                                p = "0";
                                e = "0";
                                Operando = Convert.ToInt32(valores[2]).ToHex();
                            }
                        }
                    }
                    else
                    {
                        Operando = valores[2];
                        if (valores[2].Contains(",X"))
                        {
                            n = "1";
                            i = "1";
                            x = "1";
                            e = "0";
                        }
                        else if (valores[2].Contains("#"))
                        {
                            n = "0";
                            i = "1";
                            x = "0";
                            e = "0";
                        }
                        else if (valores[2].Contains("@"))
                        {
                            n = "1";
                            i = "0";
                            x = "0";
                            e = "0";
                        }
                        else
                        {
                            n = "1";
                            i = "1";
                            x = "0";
                            e = "0";
                        }
                    }
                }
            }
            else if (Instr2.Contains(valores[1]))
            {
                if (valores.Length == 3)
                {
                    Etiqueta = valores[0];
                    CodigoOp = valores[1];
                    Operando = valores[2];
                }
                else
                {
                    Etiqueta = "";
                    CodigoOp = valores[1];
                    Operando = valores[2];
                }
            }
            else if (Instr1.Contains(valores[1]))
            {
                Etiqueta = valores[0];
                CodigoOp = valores[1];
                try {
                    Operando = valores[2];
                } catch (Exception ex) {
                    Operando = "";
                }
            }
            else if (Instr4.Contains(valores[1]))
            {
                if (valores.Length == 3)
                {
                    Etiqueta = valores[0];
                    CodigoOp = valores[1];
                    if (valores[2].Any(char.IsDigit))
                    {
                        if ((valores[2].Last() == 'h' || valores[2].Last() == 'H'))
                        {
                            n = "1";
                            i = "1";
                            x = "0";
                            b = "0";
                            p = "0";
                            e = "1";
                            Operando = valores[2].Remove(valores[2].Length - 1);
                        }
                        else
                        {
                            if (valores[2].Contains(",X"))
                            {
                                n = "1";
                                i = "1";
                                x = "1";
                                b = "0";
                                p = "0";
                                e = "1";
                                //Operando = valores[2].Remove(valores[2].Length - 2);
                                Operando = valores[2];
                            }
                            else if (valores[2].Contains("#"))
                            {
                                n = "0";
                                i = "1";
                                x = "0";
                                b = "0";
                                p = "0";
                                e = "1";
                                Operando = valores[2];
                            }
                            else if (valores[2].Contains("@"))
                            {
                                n = "1";
                                i = "0";
                                x = "0";
                                b = "0";
                                p = "0";
                                e = "1";
                                Operando = valores[2];
                            }
                            else
                            {
                                n = "1";
                                i = "1";
                                x = "0";
                                b = "0";
                                p = "0";
                                e = "1";
                                Operando = Convert.ToInt32(valores[2]).ToHex();
                            }
                        }
                    }
                    else
                    {
                        Operando = valores[2];
                        if (valores[2].Contains(",X"))
                        {
                            n = "1";
                            i = "1";
                            x = "1";
                            b = "0";
                            p = "0";
                            e = "1";
                        }
                        else if (valores[2].Contains("#"))
                        {
                            n = "0";
                            i = "1";
                            x = "0";
                            b = "0";
                            p = "0";
                            e = "1";
                        }
                        else if (valores[2].Contains("@"))
                        {
                            n = "1";
                            i = "0";
                            x = "0";
                            b = "0";
                            p = "0";
                            e = "1";
                        }
                        else
                        {
                            n = "1";
                            i = "1";
                            x = "0";
                            b = "0";
                            p = "0";
                            e = "1";
                        }
                    }
                }
                else if (valores[1] == "RSUB")
                {
                    Etiqueta = "";
                    CodigoOp = valores[1];
                    Operando = "";
                }
                else
                {
                    Etiqueta = "";
                    CodigoOp = valores[1];
                    if (valores[2].Any(char.IsDigit))
                    {
                        if ((valores[2].Last() == 'h' || valores[2].Last() == 'H'))
                        {
                            n = "1";
                            i = "1";
                            x = "0";
                            b = "0";
                            p = "0";
                            e = "1";
                            Operando = valores[2].Remove(valores[2].Length - 1);
                        }
                        else
                        {
                            if (valores[2].Contains(",X"))
                            {
                                n = "1";
                                i = "1";
                                x = "1";
                                b = "0";
                                p = "0";
                                e = "1";
                                Operando = valores[2];
                            }
                            else if (valores[2].Contains("#"))
                            {
                                n = "0";
                                i = "1";
                                x = "0";
                                b = "0";
                                p = "0";
                                e = "1";
                                Operando = valores[2];
                            }
                            else if (valores[2].Contains("@"))
                            {
                                n = "1";
                                i = "0";
                                x = "0";
                                b = "0";
                                p = "0";
                                e = "1";
                                Operando = valores[2];
                            }
                            else
                            {
                                n = "1";
                                i = "1";
                                x = "0";
                                b = "0";
                                p = "0";
                                e = "1";
                                Operando = Convert.ToInt32(valores[2]).ToHex();
                            }
                        }
                    }
                    else
                    {
                        Operando = valores[2];
                        if (valores[2].Contains(",X"))
                        {
                            n = "1";
                            i = "1";
                            x = "1";
                            e = "1";
                        }
                        else if (valores[2].Contains("#"))
                        {
                            n = "0";
                            i = "1";
                            x = "0";
                            e = "1";
                        }
                        else if (valores[2].Contains("@"))
                        {
                            n = "1";
                            i = "0";
                            x = "0";
                            e = "1";
                        }
                        else
                        {
                            n = "1";
                            i = "1";
                            x = "0";
                            e = "1";
                        }
                    }
                }
            }
            else if (Directivas.Contains(valores[1]))
            {
                if (valores.Length == 3)
                {
                    Etiqueta = valores[0];
                    CodigoOp = valores[1];
                    if ((valores[2].Last() == 'h' || valores[2].Last() == 'H'))
                    {
                        Operando = valores[2].Remove(valores[2].Length - 1);
                    } else {
                        try {
                            Operando = Convert.ToInt32(valores[2]).ToHex();
                        } catch (Exception ex) {
                            Operando = valores[2];
                        }
                    }
                }
                else if (valores.Length == 2 && valores[0] == null)
                {
                    Etiqueta = "";
                    CodigoOp = valores[1];
                    Operando = valores[2];
                }
                else
                {
                    Etiqueta = "";
                    CodigoOp = valores[1];
                    Operando = "";
                }
            }
            else
            {
                try{
                    Etiqueta = valores[0];
                    CodigoOp = valores[1];
                    Operando = valores[2];
                } catch (Exception ex){
                    try {
                        Etiqueta = "";
                        CodigoOp = valores[1];
                        Operando = valores[2];
                    } catch (Exception ex1) { }
                }
            }
        }
    }
}
