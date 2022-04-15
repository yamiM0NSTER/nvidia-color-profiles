using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nvidia_color_profiles {
  internal class DisplayManager {
    static DisplayManager _Instance = null;
    Display[] _displays = null;
    public DisplayManager() {
      NvAPIWrapper.NVIDIA.Initialize();
      var nvDisplays = NvAPIWrapper.Display.Display.GetDisplays();
      var winDisplays = WindowsDisplayAPI.Display.GetDisplays();

      var displays = new List<Display>();

      foreach(var nvDisplay in nvDisplays) {
        foreach(var winDisplay in winDisplays) {
          if(nvDisplay.Name == winDisplay.ScreenName) {
            displays.Add(new Display(nvDisplay, winDisplay));
          }
        }
      }

      _displays = displays.ToArray();
    }

    public static DisplayManager Instance { get {
        if(_Instance != null) 
          return _Instance;

        _Instance = new DisplayManager();
        return _Instance;
      }
    }

    public Display[] Displays {
      get { return _displays; }
    }
  }
}
