/* CLASE QUE PERMITE GENERAR DIFERENTES FUNCIONES, ENTRE ELLAS CONVERSIOENS DE NUMEROS,
 * OBTENER EL CODIGO DE OPERACION Y VERIFICAR SI LA INSTRUCCIÓN ES INDEXADA
*/ 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SICXE {
    public static class Extensions {
        /* Convierte una cadena hexadecimal a entero */
        public static int ToDec(this string hexNum) {
            return int.Parse(hexNum, System.Globalization.NumberStyles.HexNumber);
        }

        /* Convierte entero a cadena hexadecimal, 6 digitos*/
        public static string ToHex(this int decNum) {
            return decNum.ToString("X").PadLeft(6, '0');
        }

        /* Convierte un caracter hexadecimal a entero*/
        public static int ToDec(this char hexNum) {
            return int.Parse(hexNum.ToString(), System.Globalization.NumberStyles.HexNumber);
        }

        /* Obtiene el codigo de operacion de un codigo objeto*/
        public static string CodOp(this string codbj) {
            return codbj.Substring(0, 2);
        }

        /* Verifica si la instruccion es indexada */
        public static bool Indexado(this string codObj) {
            char thirdByte = codObj[2];
            string binary = Convert.ToString(thirdByte - 48, 2).PadLeft(4, '0');
            return binary[0] == '1';
        }

        public static string Add(this string num, string num2) {
            return (num.ToDec() + num2.ToDec()).ToString();
        }

        /* Regresa la dirección de un codigo objeto */
        public static string Dir(this string codObj) {
            string binary = "";

            foreach (char car in codObj) {
                binary += Convert.ToString(car.ToDec(), 2).PadLeft(4, '0');
            }
            return Convert.ToInt32(binary.Substring(9), 2).ToString("X").PadLeft(6, '0');

        }
        #region try
        /* Regresa el nemonico de un codigo objeto*/
        public static string Nemonico(this string codObj) {
            string cod = codObj.Substring(0, 2);
            return Enum.GetName(typeof(Instrucciones), cod.ToDec());
        }

        /* Regresa el byte mas a la derecha del codigo */
        public static string GetMSB(this string dato) {
            return dato.Substring(4);
        }

        /* Establece el byte mas a la derecha del codigo */
        public static string SetMSB(this string dato, string nuevo) {
            dato = dato.Substring(0, 4) + nuevo;
            return dato;
        }

        /* Regresa el byte mas a la izquierda del codigo */
        public static string GetLSB(this string dato) {
            return dato.Substring(0, 2);
        }

        /* Establece el byte mas a la derecha del codigo */
        public static string SetLSB(this string dato, string nuevo) {
            dato = nuevo + dato.Substring(0, 4);
            return dato;
        }


        /* Obtiene el valor de una celda en la memoria */
        public static string Value(this DataGridView data, int i, int j) {
            return data.Rows[i].Cells[j].Value.ToString();
        }

        // Suma dos numeros hexadecimales
        public static string Sum(this string a, string b) {
            string c;
            int num = a.ToDec() + b.ToDec();
            c = num.ToHex();
            return c;
        }

        /* Encuentra la posicion en el datagrid de la memoria especificada, recibe una dirección de 6 de largo*/
        public static int[] Posicion(this DataGridView mem, string direccion) {
            int[] pos = { -1, -1 };
            for (int i = 0; i < mem.Rows.Count; i++) {
                if (mem.Rows[i].HeaderCell.Value.ToString().Substring(0, 5) == direccion.Substring(0, 5)) {
                    for (int j = 0; j < 16; j++) {
                        if (mem.Rows[i].HeaderCell.Value.ToString().Remove(5) + j.ToString("X") == direccion) {
                            pos[0] = i;
                            pos[1] = j;
                            return pos;
                        }
                    }
                }
            }
            return pos;
        }

        /* Acceder a la memoria, recibe una dirección y la cantidad de bytes a leer.
         * regresa 3 bytes de la memoria en la direccion especificada */
        public static string Accede(this DataGridView data, string direccion) {
            int[] pos = data.Posicion(direccion);

            string dato = "";
            // Regresa 3 bytes a partir de la dirección especificada.
            // Modificar si necesita otra cantidad != 3
            if (pos[0] == -1 && pos[1] == -1) {
                MessageBox.Show("Instrucción inválida. Ejecución terminada");
            }
            else {
                for (int i = 0; i < 3; i++) {
                    dato += data.Value(pos[0], pos[1]);
                    if (pos[1] == data.Columns.Count - 1) {
                        pos[1] = 0;
                        pos[0]++;
                    }
                    else {
                        pos[1]++;
                    }
                }
            }
            return dato;
        }

        /* Guarda 3 bytes en la memoria , en la direccion especificada */
        public static void Guarda(this DataGridView data, string direccion, string dato, int v) {
            int[] pos = data.Posicion(direccion);
            List<string> datoDividido = new List<string>();
            if (v == 3) {
                datoDividido.Add(dato.Substring(0, 2));
                datoDividido.Add(dato.Substring(2, 2));
                datoDividido.Add(dato.Substring(4, 2));
            }
            else {
                datoDividido.Add(dato.Substring(0, 2));
            }

            for (int i = 0; i < v; i++) {
                data.Rows[pos[0]].Cells[pos[1]].Value = datoDividido[i];
                if (pos[1] == data.Columns.Count - 1) {
                    pos[1] = 0;
                    pos[0]++;
                }
                else {
                    pos[1]++;
                }
            }
        }

        /* Colorea 3 bytes en la direccion determinada por el color especificado */
        public static void Colorea(this DataGridView data, string direccion, Color color, int n) {
            int[] pos = data.Posicion(direccion);

            for (int i = 0; i < n; i++) {
                data[pos[1], pos[0]].Style.BackColor = color;
                if (pos[1] == data.Columns.Count - 1) {
                    pos[1] = 0;
                    pos[0]++;
                }
                else {
                    pos[1]++;
                }
            }
        }

    }
    #endregion
}
