using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Producto> productos = new List<Producto>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AgregarProductoClick(object sender, EventArgs e)
        {
            var nuevoProducto = new Producto() { Nombre = NombreTB.Text, Precio = Convert.ToDouble(PrecioTB.Text), Cantidad = Convert.ToInt32(CantidadTB.Text) };
            Limpiar();
            productos.Add(nuevoProducto);
            ProductosDG.ItemsSource = productos;
        }

        private void Limpiar()
        {
            NombreTB.Text = "";
            PrecioTB.Text = "";
            CantidadTB.Text = "";
        }
    }


    public struct Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

    }
}
