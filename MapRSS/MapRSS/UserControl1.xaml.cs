using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls.Maps;
using BingMapsRESTToolkit;
using Microsoft.Maps.MapControl.WPF;
using Point = System.Windows.Point;

namespace MapRSS
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public event EventHandler PushPinClicked;
        public string pushPinText;
        public string pushPinDesc;
        public UserControl1()
        {
            InitializeComponent();
        }
        
        public void AddPin(Coordinate coord, KeyValuePair<string, string[]> location)
        {
            Pushpin pushpin = new Pushpin()
            {
                Location = new Microsoft.Maps.MapControl.WPF.Location(coord.Latitude, coord.Longitude),
                ToolTip = location.Key,
                Tag = new pinData()
                {
                    Title = location.Key,
                    Description = location.Value[0]
                }
            };

            pushpin.MouseDown += OnPin_clicked;
            Map.Children.Add(pushpin);
        }

        protected virtual void OnPin_clicked(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            Pushpin pin = sender as Pushpin;
            pinData data = (pinData)pin.Tag;
            pushPinText = data.Title;
            pushPinDesc = data.Description;
            EventHandler handler = PushPinClicked;
            handler?.Invoke(this, e);
        }

        public string GetPinText()
        {
            return pushPinText;
        }

        public string GetPinDesc()
        {
            return pushPinDesc;
        }

        public delegate void PushPinClickedEventHandler(object sender, EventArgs e);

        public struct pinData
        {
            public string Title { get; set; }
            public string Description { get; set; }
            
            public pinData(string title, string description)
            {
                Title = title;
                Description = description;
            }

            
        }

    }
}
