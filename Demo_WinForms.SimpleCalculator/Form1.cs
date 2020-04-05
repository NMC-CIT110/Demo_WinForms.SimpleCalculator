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

    public enum UnitSystem
    {
        Imperial,
        Metric
    }

    public partial class MainForm : Form
    {

        private Dictionary<MaterialName, double> _materialDensities = new Dictionary<MaterialName, double>();
        private List<string> _materialNames = new List<string>();
        private UnitSystem _systemOfUnits;

        const double CUBIC_METERS_PER_CUBIC_FOOT = 0.0283168;

        public MainForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            InitializeDensityTable();

            cmbBox_Material.DataSource = Enum.GetNames(typeof(MaterialName));

            _systemOfUnits = UnitSystem.Imperial;
            radBtn_Imperial.Checked = true;
            lbl_LengthUnits.Text = "(feet)";
            lbl_WeightUnits.Text = "(pounds)";
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
            double emptyWeight = Convert.ToDouble(txtBox_EmptyWeight.Text);

            //
            // calculate payload weight
            //
            Enum.TryParse(cmbBox_Material.Text, out MaterialName materialName);
            double payloadWeight = _materialDensities[materialName];
            switch (_systemOfUnits)
            {
                case UnitSystem.Imperial:
                    payloadWeight *= 1;
                    break;
                case UnitSystem.Metric:
                    payloadWeight *= CUBIC_METERS_PER_CUBIC_FOOT;
                    break;
                default:
                    throw new Exception("Unknown system of units.");
                    break;
            }

            //
            // update form text boxes
            //
            txtBox_EmptyWeight.Text = emptyWeight.ToString("n0");
            txtBox_PayloadWeight.Text = (volume() * payloadWeight).ToString("n0");
            txtBox_GrossWeight.Text = (emptyWeight + payloadWeight).ToString("n0");
        }

        private double volume()
        {
            return
                Convert.ToDouble(txtBox_Length.Text) *
                Convert.ToDouble(txtBox_Width.Text) *
                Convert.ToDouble(txtBox_Height.Text);
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
