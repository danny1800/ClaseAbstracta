using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseAbstracta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class vehiculo 
        {
            //tipo de acceso_abstract_tipo de dato retorno_nombre del metodo
            public abstract double CantidadCombustible();

        }

        class Torton : vehiculo
        {
            public override double CantidadCombustible()
            {
                return 200;
            }
        }

        class Sedan : vehiculo 
        {
            public override double CantidadCombustible()
            {
                return 100;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "";
            vehiculo Vehiculo;
            Vehiculo = new Torton();
            double cantidadcombustible = Vehiculo.CantidadCombustible();
            texto = "la cantidad del combustible del torton es: " + cantidadcombustible + Environment.NewLine;
            Vehiculo = new Sedan();
            double combustiblesedan = Vehiculo.CantidadCombustible();
            texto += "la cantidad de combustible del Sedan es: " + combustiblesedan + Environment.NewLine;
            double combustible;
            combustible = cantidadcombustible + combustiblesedan;
            texto += "el total de combustible es; " + combustible + Environment.NewLine;
            textBox1.Text = texto;
        }
    }
}
