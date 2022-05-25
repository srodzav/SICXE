﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.IO;
=======
>>>>>>> e62345c310b273d41a8eb9493a71ef38b2fc3d78
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SICXE
{
    public partial class MapaMemoria : Form
    {
<<<<<<< HEAD
        public string ruta = " ";
=======
>>>>>>> e62345c310b273d41a8eb9493a71ef38b2fc3d78
        private string A = "FFFFFF";
        private string L = "FFFFFF";
        private string X = "FFFFFF";
        private string CP = "FFFFFF";
        private string CC = "";
        private int tamProg = 0;
        private int contadorCP = 0;
        private string[] obj;

<<<<<<< HEAD

        public MapaMemoria()
        {
            InitializeComponent();
            label7.Text = "2021";//Long
            label10.Text = "2012";//Dir Inicial
            memoria.RowHeadersWidth = 80;
            for (int i = 0; i < 16; i++)//Columnas
            {
                memoria.Columns.Add(i.ToString("X"), i.ToString("X"));
                memoria.Columns[i].Width = 30;
            }
            for (int i = 0; i < 4; i++)//Filas
            {
                if (i==0){
                    memoria.Rows.Add("FF", "FF", "05", "00", "00", "69", "10", "30", "30", "2F", "10", "30", "2D", "0F", "90", "30");
                    memoria.Rows[i].HeaderCell.Value = "2010";
                    
                }
                if (i==1){
                    memoria.Rows.Add("2A", "1B", "A0", "03", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF");
                    memoria.Rows[i].HeaderCell.Value = "2020";
                    
                }
                if (i==2){
                    memoria.Rows.Add("FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "69", "20", "03", "FF", "FF", "FF");
                    memoria.Rows[i].HeaderCell.Value = "3020";
                    
                }
                if (i==3){
                    memoria.Rows.Add("00", "00", "00", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF");
                    memoria.Rows[i].HeaderCell.Value = "4030";
                    
                } 
            }

        }

=======
>>>>>>> e62345c310b273d41a8eb9493a71ef38b2fc3d78
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
<<<<<<< HEAD
             

            
            string dir = objText[0].Substring(7, 6);
           
           
            
=======
            string dir = objText[0].Substring(7, 6);
>>>>>>> e62345c310b273d41a8eb9493a71ef38b2fc3d78
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
