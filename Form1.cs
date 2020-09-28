using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipLoadingGame
{
    public partial class Form1 : Form
    {
        private Ship ship = new Ship();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_newShip_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            updateUI();
            track_motorCycles.Value = 0;
            track_cars.Value = 0;
            track_trucks.Value = 0;
            track_trainCars.Value = 0;
        }

        private void updateUI()
        {
            // set all the controls to match the ship properties.
            progressBar1.Maximum = ship.Capacity;

            if (ship.getShipLoad() <= ship.Capacity)
                progressBar1.Value = ship.getShipLoad();

            label_shipLabel.Text = ship.ToString();

            // motocycles
            label_motorCycles.Text = ship.CycleCount.ToString();
            label_trucks.Text = ship.TruckCount.ToString();
            label_cars.Text = ship.CarCount.ToString();
            label_trainCars.Text = ship.TrainCount.ToString();

            // Win conditions
            if (ship.overUnder() == 0)
            {
                progressBar1.ForeColor = Color.Green;
            }
            if (ship.overUnder() > 0)
            {
                progressBar1.ForeColor = Color.Yellow;
            }
            if (ship.overUnder() < 0)
            {
                progressBar1.ForeColor = Color.Red;
            }
        }

        private void track_motorCycles_Scroll(object sender, EventArgs e)
        {
            ship.CycleCount = track_motorCycles.Value;
            updateUI();
        }

        private void track_cars_Scroll(object sender, EventArgs e)
        {
            ship.CarCount = track_cars.Value;
            updateUI();
        }

        private void track_trucks_Scroll(object sender, EventArgs e)
        {
            ship.TruckCount = track_trucks.Value;
            updateUI();
        }

        private void track_trainCars_Scroll(object sender, EventArgs e)
        {
            ship.TrainCount = track_trainCars.Value;
            updateUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
        }
    }
}