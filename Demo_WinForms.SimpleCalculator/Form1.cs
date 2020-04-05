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
            (double length, double width, double height, double emptyWeight) inputValues;

            //
            // get and set values from the ValidateInputs method
            //
            string errorMessage = ValidateInputs(out inputValues);
            double length = inputValues.length;
            double width = inputValues.width;
            double height = inputValues.height;
            double emptyWeight = inputValues.emptyWeight;

            //
            // calculate payload weight
            //
            if (errorMessage == "")
            {
                Enum.TryParse(cmbBox_Material.Text, out MaterialName materialName);
                double payloadWeight = _materialDensities[materialName];

                switch (_systemOfUnits)
                {
                    case UnitSystem.Imperial:
                        payloadWeight *= 1;
                        break;
                    case UnitSystem.Metric:
                        payloadWeight /= CUBIC_METERS_PER_CUBIC_FOOT;
                        break;
                    default:
                        throw new Exception("Unknown system of units.");
                        break;
                }

                //
                // update form text boxes
                //
                txtBox_EmptyWeight.Text = emptyWeight.ToString("n0");
                txtBox_PayloadWeight.Text = (Volume(length, width, height) * payloadWeight).ToString("n0");
                txtBox_GrossWeight.Text = (emptyWeight + payloadWeight).ToString("n0");
            }

            //
            //
            //
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        /// <summary>
        /// calculate volume
        /// </summary>
        /// <param name="length">length</param>
        /// <param name="width">width</param>
        /// <param name="height">height</param>
        /// <returns>volume</returns>
        private double Volume(double length, double width, double height)
        {
            return length * width * height;
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

        /// <summary>
        /// update system of units based on radio button
        /// </summary>
        private void RadBtn_Imperial_CheckedChanged(object sender, EventArgs e)
        {
            _systemOfUnits = UnitSystem.Imperial;

            //
            // update units
            //
            lbl_LengthUnits.Text = "(feet)";
            lbl_WeightUnits.Text = "(pounds)";
        }

        /// <summary>
        /// update system of units based on radio button
        /// </summary>
        private void RadBtn_Metric_CheckedChanged(object sender, EventArgs e)
        {
            _systemOfUnits = UnitSystem.Metric;

            //
            // update units
            //
            lbl_LengthUnits.Text = "(meters)";
            lbl_WeightUnits.Text = "(kilograms)";
        }

        /// <summary>
        /// validate inputs
        /// return valid values or an error message
        /// </summary>
        /// <param name="inputValues">length, width, height, empty weight tuple</param>
        /// <returns>error message</returns>
        private string ValidateInputs(out (double length, double width, double height, double emptyWeight) inputValues)
        {
            double length = 0;
            double width = 0;
            double height = 0;
            double emptyWeight = 0;

            string errorMessage = "";

            //
            // check for empty input boxes
            //
            if (
                txtBox_Length.Text == "" ||
                txtBox_Width.Text == "" ||
                txtBox_Height.Text == "" ||
                txtBox_EmptyWeight.Text == ""
                )
            {
                errorMessage = "Inputs for Length, Width, Height and Truck Weight must be entered.";
            }

            //
            // check for valid input values
            //
            if (
                !(
                double.TryParse(txtBox_Length.Text, out length) &&
                double.TryParse(txtBox_Width.Text, out width) &&
                double.TryParse(txtBox_Height.Text, out height) &&
                double.TryParse(txtBox_EmptyWeight.Text, out emptyWeight)
                )
                )
            {
                errorMessage += "\nInputs for Length, Width, Height and Truck Weight must be numbers.";
            }

            inputValues.length = length;
            inputValues.width = width;
            inputValues.height = height;
            inputValues.emptyWeight = emptyWeight;

            return errorMessage;
        }
    }
}
