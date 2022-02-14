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

namespace _3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Dueno> duenos = new List<Dueno>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AgregarClick(object sender, EventArgs e)
        {
            var dueno = new Dueno() { Nombre = DuenoNombreTB.Text, Direccion = DuenoDireccionTB.Text, Mascota = new Mascota() { Nombre = MascotaNombreTB.Text, Especie = MascotaEspecieTB.Text } };
            Limpiar();
            duenos.Add(dueno);
            DuenosMascotasDG.ItemsSource = duenos;
        }

        private void Limpiar()
        {
            DuenoNombreTB.Text = "";
            DuenoDireccionTB.Text = "";
            MascotaNombreTB.Text = "";
            MascotaEspecieTB.Text = "";
        }
    }

    public struct Dueno
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public Mascota Mascota { get; set; }
    }

    public struct Mascota
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
    }

}
