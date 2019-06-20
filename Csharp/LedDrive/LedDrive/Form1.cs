using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arduino4Net;
using Arduino4Net.Models;

namespace LedDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange
                (System.IO.Ports.SerialPort.GetPortNames());
        }

        enum TypeOfLed
        {
            Red = 5,
            Blue = 6,
            Green = 7
        }
        Arduino arduino;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            arduino = new Arduino(((ComboBox)sender).SelectedItem.ToString());
            ((ComboBox)sender).Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arduino.DigitalWrite((int)TypeOfLed.Red,DigitalPin.High);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arduino.DigitalWrite((int)TypeOfLed.Red, DigitalPin.Low);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arduino.DigitalWrite((int)TypeOfLed.Blue, DigitalPin.High);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arduino.DigitalWrite((int)TypeOfLed.Blue, DigitalPin.Low);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            arduino.DigitalWrite((int)TypeOfLed.Green, DigitalPin.High);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            arduino.DigitalWrite((int)TypeOfLed.Green, DigitalPin.Low);
        }
    }
}
