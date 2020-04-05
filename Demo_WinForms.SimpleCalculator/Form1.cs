using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_WinForms.SimpleCalculator
{
    public enum MaterialName
    {
        Topsoil,
        Sand,
        Limestone,
        Concrete,
        Clowns
    }

    public partial class MainForm : Form
    {

        private Dictionary<MaterialName, double> _materialDensities = new Dictionary<MaterialName, double>();
        private List<string> _materialNames = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            InitializeDensityTable();

            cmbBox_Material.DataSource = Enum.GetNames(typeof(MaterialName));
        }

        /// <summary>
        /// initialize the density table, lbs/cubic foot
        /// </summary>
        private void InitializeDensityTable()
        {
            _materialDensities.Add(MaterialName.Topsoil, 100);
            _materialDensities.Add(MaterialName.Sand, 101.8);
            _materialDensities.Add(MaterialName.Limestone, 150);
            _materialDensities.Add(MaterialName.Concrete, 145);
            _materialDensities.Add(MaterialName.Clowns, 145);
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {

        }

        private double volume()
        {
            return
                Convert.ToDouble(txtBox_Length) *
                Convert.ToDouble(txtBox_Width) *
                Convert.ToDouble(txtBox_Height);
        }

        private void Btn_Help_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Clear();

            sb.AppendLine("\tInstructions");
            sb.AppendLine("1) Enter the length, width and height of the dump box.");
            sb.AppendLine("2) Enter the empty weight of the truck or trailer.");
            sb.AppendLine("3) Set the units to either pounds or kilograms.");
            sb.AppendLine("4) Set the material type.");
            sb.AppendLine("5) Click 'Calculate Weight'.");
            
            string instructions = sb.ToString();

            //
            // use help form
            //
            HelpForm helpForm = new HelpForm(instructions);
            helpForm.Show();

            //
            // use help dialog box
            //
            //MessageBox.Show(instructions);
        }
    }
}
