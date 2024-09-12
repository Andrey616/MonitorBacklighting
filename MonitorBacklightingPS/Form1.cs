using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
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
        int keyOpen = 0;
        int mode = 0;
        int colorPalette = 0;
        int OnOff = 0;
        int ColorTop = 0;
        string data;


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
                    keyOpen = 1;
                    main();



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
                keyOpen = 0;
                Futor.Text = ("Закрыт порт: " + selectedPort);
            }
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (OnOffTape.Checked == true)
            {
                Futor.Text = " Лента включена";
                OnOff = 1;
                main();
            }
            else
            {
                Futor.Text = " Лента выключена";
                OnOff = 0;
                main();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            if (checkBoxColor.Checked)
            {
                main();
            }
            //BackColor = Color.FromArgb(250,25,25);
            labelRed.Text = $"{trackBarRed.Value}";
            ColorBox.BackColor = System.Drawing.Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            if (checkBoxColor.Checked)
            {
                main();
            }
            labelGreen.Text = $"{trackBarGreen.Value}";
            ColorBox.BackColor = System.Drawing.Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            if (checkBoxColor.Checked)
            {
                main();
            }
            labelBlue.Text = $"{trackBarBlue.Value}";
            ColorBox.BackColor = System.Drawing.Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SpeedModeLable.Text = $"Скорость режимов: {trackSpeedMode.Value}";
            main();
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            labelBrightness.Text = $"Яркость режимов: {trackBrightness.Value}";
            main();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Futor.Text = "0";
            mode = 0;
            main();
        }

        private void Mode1_CheckedChanged(object sender, EventArgs e)
        {
            Futor.Text = "1";
            mode = 1;
            main();
        }

        private void Mode3_CheckedChanged(object sender, EventArgs e)
        {
            Futor.Text = "2";
            mode = 2;
            main();
        }

        private void Mode4_CheckedChanged(object sender, EventArgs e)
        {
            Futor.Text = "3";
            mode = 3;
            main();
        }

        private void Mode5_CheckedChanged(object sender, EventArgs e)
        {
            Futor.Text = "4";
            mode = 4;
            main();
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

        private void Push_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            main();
        }

        private void main()
        {
            Thread.Sleep(100);
            if (keyOpen == 1)
            {                

                switch (mode)
                {
                    case 0:
                        data = $"{OnOff}|0|{trackSpeedMode.Value}|{trackBrightness.Value}";
                        Futor.Text = data;
                        serialPort.WriteLine(data);

                        break;

                    case 1:
                        data = $"{OnOff}|1|{trackSpeedMode.Value}|{trackBrightness.Value}";
                        Futor.Text = data;
                        serialPort.WriteLine(data);

                        break;

                    case 2:
                        if (checkBoxColor.Checked)
                        {
                            data = $"{OnOff}|2|{trackSpeedMode.Value}|{trackBrightness.Value}|{trackBarRed.Value}|{trackBarGreen.Value}|{trackBarBlue.Value}";
                            Futor.Text = data;
                            serialPort.WriteLine(data);
                        }
                        else
                        {
                            data = $"{OnOff}|2|{trackSpeedMode.Value}|{trackBrightness.Value}|{ColorPaletteList[colorPalette]}";
                            Futor.Text = data;
                            serialPort.WriteLine(data);
                        }
                        
                        break;

                    case 3:
                        if (checkBoxColor.Checked)
                        {
                            data = $"{OnOff}|3|{trackSpeedMode.Value}|{trackBrightness.Value}|{trackBarRed.Value}|{trackBarGreen.Value}|{trackBarBlue.Value}";
                            Futor.Text = data;
                            serialPort.WriteLine(data);
                        }
                        else
                        {
                            data = $"{OnOff}|3|{trackSpeedMode.Value}|{trackBrightness.Value}|{ColorPaletteList[colorPalette]}";
                            Futor.Text = data;
                            serialPort.WriteLine(data);
                        }

                        break; 

                    case 4:
                        if (checkBoxColor.Checked)
                        {
                            data = $"{OnOff}|4|{trackSpeedMode.Value}|{trackBrightness.Value}|{trackBarRed.Value}|{trackBarGreen.Value}|{trackBarBlue.Value}|{ColorTop}";
                            Futor.Text = data;
                            serialPort.WriteLine(data);
                        }
                        else
                        {
                            data = $"{OnOff}|4|{trackSpeedMode.Value}|{trackBrightness.Value}|{ColorPaletteList[colorPalette]}|{ColorTop}";
                            Futor.Text = data;
                            serialPort.WriteLine(data);
                        }

                        break; 

                }
            }
        }

        List<string> ColorPaletteList = new List<string>() { "255|0|0", "0|255|255", "0|255|0", "255|0|255", "255|255|0", "255|80|0", "0|0|255", "228|0|127", "46|167|224", "96|25|134", "255|255|255", "140|179|36", "255|156|51", "209|113|174" };

        private void ColorRed_CheckedChanged(object sender, EventArgs e)
        {
            colorPalette = 0;
            main();
        }
       
        private void ColorCyan_CheckedChanged(object sender, EventArgs e)
        {
            colorPalette = 1;
            main();
        }

        private void ColorLime_CheckedChanged(object sender, EventArgs e)
        {
            colorPalette = 2;
            main();
        }

        private void ColorMagenta_CheckedChanged(object sender, EventArgs e)
        {
            colorPalette = 3;
            main();
        }

         private void ColorYellow_CheckedChanged(object sender, EventArgs e)
        {
            colorPalette = 4;
            main();
        }

        private void ColorOrange_CheckedChanged(object sender, EventArgs e)
        {
            colorPalette = 5;
            main();
        }

        private void ColorBlue_CheckedChanged(object sender, EventArgs e)
        {
            colorPalette = 6;
            main();
        }

        private void ColorDarkPink_CheckedChanged(object sender, EventArgs e)
        {
            colorPalette = 7;
            main();
        }

        private void ColorDarkCany_CheckedChanged(object sender, EventArgs e)
        {
            colorPalette = 8;
            main();
        }

        private void ColorDarkMagenta_CheckedChanged(object sender, EventArgs e)
        {
            colorPalette = 9;
            main();
        }

        private void ColorWhite_CheckedChanged(object sender, EventArgs e)
        {
            colorPalette = 10;
            main();
        }

        private void ColorSwamp_CheckedChanged(object sender, EventArgs e)
        {
            colorPalette = 11;
            main();
        }

        private void ColorWhiteOrange_CheckedChanged(object sender, EventArgs e)
        {
            colorPalette = 12;
            main();
        }

        private void ColorPalePink_CheckedChanged(object sender, EventArgs e)
        {
            colorPalette = 13;
            main();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            ColorTop = 0;
            main();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ColorTop = 1;
            main();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ColorTop = 2;
            main();
        }

        private void checkBoxColor_CheckedChanged(object sender, EventArgs e)
        {
            main();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (keyOpen == 1)
            {
                serialPort.WriteLine($"0|0|0");
            }
            
        }
    }
}
