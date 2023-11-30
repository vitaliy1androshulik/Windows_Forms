using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
namespace _10_CarsHomeWork
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();
            CarList.Items.AddRange(cars.ToArray());
            ColorComboBox.Text = "--Select color--";
            CarList.DataSource = cars;
        }

        private void UpdateOrderComboBox()
        {
            CarList.DataSource = null;
            CarList.DataSource = cars;

        }
        private void ClearAll()
        {
            ModelTextBox.Clear();
            YearNumericUpDown.Value = 2000;
            ColorComboBox.Text = "White";
            ProbigNumericUpDown.Value = 0;
            VolumeNumericupDown.Value = 0;
        }
        private void AddNewCarBtn_Click(object sender, EventArgs e)
        {
            if (ModelTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter model!");
            }
            else if (ModelTextBox.Text.Length > 0)
            {
                cars.Add(new Car(ModelTextBox.Text, (int)YearNumericUpDown.Value, ColorComboBox.SelectedItem.ToString(), (int)ProbigNumericUpDown.Value, (double)VolumeNumericupDown.Value));
                UpdateOrderComboBox();
                ClearAll();
                MessageBox.Show("Car added!");
            }
        }

        private void ShowCarBtn_Click(object sender, EventArgs e)
        {
            if (CarList.Items.Count == 0)
            {
                MessageBox.Show("You don`t have a car!");
                return;
            }
            MessageBox.Show(CarList.SelectedItem.ToString(), "Selected Item");
        }

        private void DeleteCarBtn_Click(object sender, EventArgs e)
        {
            if (CarList.SelectedIndex == -1)
            {
                return;
            }
            cars.RemoveAt(CarList.SelectedIndex);
            MessageBox.Show("Car was removed!");
            UpdateOrderComboBox();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (cars.Count > 0)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream fs = File.Create("Car.bin"))
                {
                    formatter.Serialize(fs, cars);
                }
                MessageBox.Show("Cars has been saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cars don`t saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<Car> LoadFromFile()
        {
            List<Car> loadCars = new List<Car>();
            try
            {

                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream fs = File.OpenRead("Car.bin"))
                {
                    loadCars = (List<Car>)formatter.Deserialize(fs);
                }


                MessageBox.Show("Cars loaded!", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cars don`t loaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return loadCars;
        }
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            List<Car> loadCar = LoadFromFile();
            cars.AddRange(loadCar);
            UpdateOrderComboBox();
        }
    }
}