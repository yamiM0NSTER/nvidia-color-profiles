using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nvidia_color_profiles {
  internal class Display {
    NvAPIWrapper.Display.Display _nvDisplay = null;
    WindowsDisplayAPI.Display _winDisplay = null;
    public Display(NvAPIWrapper.Display.Display nvDisplay, WindowsDisplayAPI.Display winDisplay) {
      _nvDisplay = nvDisplay;
      _winDisplay = winDisplay;
    }

    public string Name {
      get { return _winDisplay.ToPathDisplayTarget().FriendlyName; }
    }

    public int HUEAngle {
      get { return _nvDisplay.HUEControl.CurrentAngle; }
      set { _nvDisplay.HUEControl.CurrentAngle = value; }
    }

    public int DigitalVibrance {
      get { return _nvDisplay.DigitalVibranceControl.CurrentLevel; }
      set { _nvDisplay.DigitalVibranceControl.CurrentLevel = value; }
    }

    public override string ToString() {
      return this.Name;
    }
  }
}
