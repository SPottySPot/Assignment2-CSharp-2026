using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class TaskDForm : Form
    {
        // Code adapted from ChatGPT and modified by Sterling

        public class Car
        {
            public string Make;
            public string Model;
            public Engine CarEngine;

            public Car(string make, string model, string engineType, int horsepower)
            {
                Make = make;
                Model = model;
                CarEngine = new Engine(engineType, horsepower);
            }

            // Nested class
            public class Engine
            {
                public string Type;
                public int Horsepower;

                public Engine(string type, int horsepower)
                {
                    Type = type;
                    Horsepower = horsepower;
                }

                public string GetEngineDetails()
                {
                    return Type + " engine (" + Horsepower + " HP)";
                }
            }
        }
        public TaskDForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            Car car = new Car(txtMake.Text, txtModel.Text, txtEngineType.Text, int.Parse(txtHorsePower.Text));
            lblResult.Text += car.Make + " " + car.Model + " with " + car.CarEngine.GetEngineDetails();
        }
    }
}
