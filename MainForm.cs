using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsDisplayAPI.DisplayConfig;

namespace nvidia_color_profiles {
  public partial class MainForm : Form {
    public MainForm() {
      NvAPIWrapper.NVIDIA.Initialize();
      InitializeComponent();

      this.PopulateDisplayComboBox();
    }

    private void PopulateDisplayComboBox() {
      displayComboBox.Items.Clear();
      displayComboBox.Items.AddRange(DisplayManager.Instance.Displays);
      displayComboBox.SelectedIndex = 0;
      UpdateSliders();
    }

    private void UpdateSliders() {
      var display = (Display)displayComboBox.SelectedItem;
      if(display == null) {
        dvLabel.Text = "0 %";
        hueLabel.Text = "0°";
        return;
      }

      dvLabel.Text = display.DigitalVibrance + "%";
      dvTrackBar.Value = display.DigitalVibrance;
      hueLabel.Text = display.HUEAngle + "°";
      hueTrackBar.Value = display.HUEAngle;
    }

    //private void button1_Click(object sender, EventArgs e) {
    //  var displays = NvAPIWrapper.Display.Display.GetDisplays();
    //  string text = "";
    //  foreach(var display in displays) {
    //    text += display.ToString() + " ";
    //  }

    //  //text += displays[0].DigitalVibranceControl.CurrentLevel.ToString();

    //  text += displays[0].DigitalVibranceControl.CurrentLevel.ToString() + " ";
    //  text += displays[0].DigitalVibranceControl.MinimumLevel.ToString() + " ";
    //  text += displays[0].DigitalVibranceControl.MaximumLevel.ToString() + " ";

    //  var disp = displays[0];
    //  text += "\n\n"  + disp.Name + " ";
    //  //text += disp.DisplayDevice.CurrentColorData.
    //  text += "\n\n";
    //  var displaysConfig = NvAPIWrapper.Display.PathInfo.GetDisplaysConfig();
    //  foreach(var display in displaysConfig) {
    //    text += display.ToString() + " ";
    //  }

    //  var targetInfo = new NvAPIWrapper.Display.PathTargetInfo(disp.DisplayDevice);
    //  text += targetInfo.DisplayDevice.ToString() + " ";
    //  //NvAPIWrapper.Display.
    //  var test = NvAPIWrapper.Native.DisplayApi.GetMonitorCapabilities(disp.DisplayDevice.DisplayId, NvAPIWrapper.Native.Display.MonitorCapabilitiesType.VSDB);
    //  //test.Value.
    //  //displays[0].DigitalVibranceControl.CurrentLevel = 50;

    //  var winDisplays = WindowsDisplayAPI.Display.GetDisplays();
    //  foreach(var display in winDisplays) {
    //    //text += display.DisplayName + " ";
    //    //text += display.ToPathDisplayTarget().FriendlyName + " ";
    //    //text += display.DeviceName + " ";
    //    text += "\n" + display.DisplayName + " ";
    //    //text += "\n" + display.ToPathDisplayTarget().DevicePath + " ";
    //    //text += "\n" + display.ToPathDisplayTarget().TargetId + " ";
    //    //text += "\n" + display.ToPathDisplayTarget().FriendlyName + " ";
    //    //text += "\n" + display.ToPathDisplaySource().Adapter.ToString();
    //    //display.CurrentSetting.
    //    text += "\n" + display.DevicePath;
    //    //var gammaramp = display.GammaRamp;
    //    //text += "\nRed: " + gammaramp.Red;
    //    //text += "\nBlue: " + gammaramp.Blue;
    //    //text += "\nGreen: " + gammaramp.Green;
    //    text += "\n" + display.ScreenName;
    //    text += "\n";
    //  }
      

    //  label1.Text = text;
    //  //NvAPIWrapper.Display.HUEInformation = new NvAPIWrapper.Display.HUEInformation()
    //}

    private void dvTrackBar_ValueChanged(object sender, EventArgs e) {
      var display = (Display)displayComboBox.SelectedItem;

      display.DigitalVibrance = dvTrackBar.Value;
      this.UpdateSliders();
    }

    private void hueTrackBar_ValueChanged(object sender, EventArgs e) {
      var display = (Display)displayComboBox.SelectedItem;

      display.HUEAngle = hueTrackBar.Value;
      this.UpdateSliders();
    }
  }
}
