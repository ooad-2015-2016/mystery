using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Maker.RemoteWiring;
using Microsoft.Maker.Serial;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatAlarmniSistem
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Aktivacija : Page
    {
        private RemoteDevice _arduino;
        public bool IsOn { get; private set; } = false;
        Boolean stanje = true;
        public Aktivacija()
        {
            var usb = new UsbSerial("VID_1A86", "PID_7523");
            this.InitializeComponent();
            _arduino = new RemoteDevice(usb);
            _arduino.DeviceReady += Setup;
            usb.begin(57600, SerialConfig.SERIAL_8N2);
        }
        private void Setup()
        {
            _arduino.pinMode(13, PinMode.OUTPUT);
        }
        public void Toggle()
        {
            if (IsOn)
            {
                _arduino.digitalWrite(13, PinState.LOW);
                Ispis.Text = "Alarm deaktiviran";
            }
            else
            {
                _arduino.digitalWrite(13, PinState.HIGH);
                Ispis.Text = "Alarm aktiviran";
            }
            IsOn = !IsOn;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoginKorisnik), null);
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Toggle();
            /*if (stanje == true)
            {
                stanje = false;
                _arduino.digitalWrite(9, PinState.LOW);
                Ispis.Text = "Alarm je deaktiviran";
            }
            else
            {
                stanje = true;
                _arduino.digitalWrite(9, PinState.HIGH);
                Ispis.Text = "Alarm je aktiviran";
            }*/
        }
    }
}
