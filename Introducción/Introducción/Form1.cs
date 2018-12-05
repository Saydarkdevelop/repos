using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introducción
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad = 30;
            aumentaEdad(edad);
            Console.WriteLine("edad es de: {0}", edad);
        }
        private static void aumentaEdad (int edad){
            edad = edad + 5;
            Console.WriteLine("se aumento la edad en {1} años, ahora es de:{0}",edad,5);

         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] edad = { 30 };
            aumentaedad(edad);
            Console.WriteLine("edad es de: {0}", edad[0]);
        }
        private static void aumentaedad(int[] edad)
        {
            edad[0] = edad[0] + 5;
            Console.WriteLine("se aumento la edad en 5 años a la edad {0}",edad[0]);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("la suma de {0} {1} {2} = {3}", 3, "+", 8, (3 + 8));

            Console.WriteLine("la resta de {0} {1} {2} = {3}", 3, "-", 8, (3 - 8));

            Console.WriteLine("la multiplicacion de {0} {1} {2} = {3}", 3, "*", 8, (3 * 8));

            Console.WriteLine("El residuo de {0} {1} {2} = {3}", 17, "%", 8, (17 % 8));

            Console.WriteLine("la igualdad de {0} {1} {2} = {3}", 8, "==", 8, (8 == 8));
        }
    }
}
