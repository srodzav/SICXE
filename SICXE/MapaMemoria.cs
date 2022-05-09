using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SICXE
{
    public partial class MapaMemoria : Form
    {
        private string A = "FFFFFF";
        private string L = "FFFFFF";
        private string X = "FFFFFF";
        private string CP = "FFFFFF";
        private string CC = "";
        private int tamProg = 0;
        private int contadorCP = 0;
        private string[] obj;

        public MapaMemoria(string[] objText, int longPrograma)
        {
            InitializeComponent();
            obj = objText;
            InicializaMemoria(obj);
        }

        private void InicializaMemoria(string[] objText)
        {
            //textBoxA.Text = A;
            //textBoxCP.Text = CP;
            //textBoxL.Text = L;
            //textBoxX.Text = X;

            //MessageBox.Show("Cadena: "+objText.ToString());
            string dir = objText[0].Substring(7, 6);
            //MessageBox.Show("Direccion: " + dir);
            string dirInicio = dir;
            int[] pos;
            tamProg = objText[0].Substring(13, 6).ToDec() + dir.ToDec();
            //MessageBox.Show("Tamaño programa: " + tamProg.ToString());

            label7.Text = objText[0].Substring(13, 6);
            label10.Text = objText[1].Substring(1, 6);

            memoria.RowHeadersWidth = 80;
            // Agrega las columnas de la tabal
            for (int i = 0; i < 16; i++)
            {
                memoria.Columns.Add(i.ToString("X"), i.ToString("X"));
                memoria.Columns[i].Width = 30;
            }
            dir = dir.Substring(0, 5) + "0";
            // Agrega las filas de la tabla + 1
            for (int i = 0; i < (int)Math.Ceiling(objText[0].Substring(13, 6).ToDec() / 16.0) + 1; i++)
            {
                memoria.Rows.Add("FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF");
                memoria.Rows[i].HeaderCell.Value = dir;
                dir = (dir.ToDec() + 16).ToHex(); // ("100".ToDec() + dir.ToDec()).TotHex();
            }

            for (int i = 1; i < objText.Length - 1; i++)
            {
                pos = memoria.Posicion(objText[i].Substring(1, 6));
                //MessageBox.Show("Pos: " + pos);
                int cont = objText[i].Substring(7, 2).ToDec();
                //MessageBox.Show("Cont: " + cont);
                string resto = objText[i].Substring(9);
                //MessageBox.Show("Resto: " +resto);

                for (int j = 0; j < cont * 2; j += 2)
                {
                    //memoria[pos[1], pos[0]].Value = resto[j].ToString() + resto[j + 1].ToString();
                    try {
                        if(contadorCP < 20)
                        {
                            memoria.Rows[pos[0]].Cells[pos[1]].Value = resto[j].ToString() + resto[j + 1].ToString();
                            pos[1]++;
                            contadorCP++;
                            if (pos[1] == 16)
                            {
                                pos[1] = 0;
                                pos[0]++;
                            }
                        }
                    } catch (Exception ex) { }
                }
            }

            //CP = textBoxCP.Text = objText[0].Substring(7, 6);
            //memoria[2, 2].Selected = true;
            memoria.ClearSelection();
            memoria.Colorea(dirInicio, Color.LightBlue, 3);
        }
    }
}
