using Microsoft.Win32;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace ISchemm.WinFormsOAuth {
    public static class IECompatibility {
        public enum Mode {
            IE11IgnoreDoctype = 11001,
            IE11 = 11000,
            IE10IgnoreDoctype = 10001,
            IE10 = 10000,
            IE9IgnoreDoctype = 9999,
            IE9 = 9000,
            IE8IgnoreDoctype = 8888,
            IE8 = 8000,
            IE7 = 7000
        }

        public static void SetForCurrentProcess(Mode mode = Mode.IE11) {
            // don't change the registry if running in-proc inside Visual Studio
            if (LicenseManager.UsageMode != LicenseUsageMode.Runtime)
                return;

            string appName = Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName);

            Registry.SetValue(
                @"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION",
                appName,
                (int)mode,
                RegistryValueKind.DWord);
        }
    }
}
