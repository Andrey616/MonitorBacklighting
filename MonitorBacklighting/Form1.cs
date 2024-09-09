using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;


namespace MonitorBacklighting
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string selectedPort;
        public string portName;
        public SerialPort serialPort;


        private void Form1_Load(object sender, EventArgs e)
        {
            

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                PortBox.Items.Add(port);
            }

           


        }
        private void PortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void butOpen_Click(object sender, EventArgs e)
        {
            
            selectedPort = (string)PortBox.SelectedItem;

            portName = selectedPort; 
            if (!(String.IsNullOrEmpty(portName)))
            {
                butOpen.Enabled = false;
                try
                {
                    serialPort = new SerialPort(portName, 9600);
                    Futor.Text = ("Открыт порт: " + selectedPort);
                    serialPort.Open();
                    

                }
                catch (IOException ex)
                {
                    Futor.Text = ($"Ошибка доступа к порту: {ex.Message}");
                }
            }
        }

        private void Futor_TextChanged(object sender, EventArgs e)
        {

        }

        private void butClose_Click(object sender, EventArgs e)
        {
            
            selectedPort = (string)PortBox.SelectedItem;
            portName = selectedPort;
            if (!(String.IsNullOrEmpty(portName)))
            {
                butOpen.Enabled = true;
                serialPort.Close();
                Futor.Text = ("Закрыт порт: " + selectedPort);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (OnOofTape.Checked == true)
            {
                Futor.Text = " Лента включена";
            }
            else
            {
                Futor.Text = " Лента выключена";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            //BackColor = Color.FromArgb(250,25,25);
            labelRed.Text = $"{trackBarRed.Value}";
            ColorBox.BackColor = System.Drawing.Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            labelGreen.Text = $"{trackBarGreen.Value}";
            ColorBox.BackColor = System.Drawing.Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            labelBlue.Text = $"{trackBarBlue.Value}";
            ColorBox.BackColor = System.Drawing.Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SpeedModeLable.Text = $"Скорость режимов: {trackSpeedMode.Value}";
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            labelBrightness.Text = $"Яркость режимов: {trackBrightness.Value}";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Futor.Text = "0";
        }

        private void Mode1_CheckedChanged(object sender, EventArgs e)
        {
            Futor.Text = "1";
        }

        private void Mode3_CheckedChanged(object sender, EventArgs e)
        {
            Futor.Text = "2";
        }

        private void Mode4_CheckedChanged(object sender, EventArgs e)
        {
            Futor.Text = "3";
        }

        private void Mode5_CheckedChanged(object sender, EventArgs e)
        {
            Futor.Text = "4";
        }

        private void Сollapse_Click(object sender, EventArgs e)
        {
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SpeedModeLable_Click(object sender, EventArgs e)
        {

        }
    }
}
