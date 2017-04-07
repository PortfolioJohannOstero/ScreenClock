using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms; // For getting the current monitors

namespace Screen_Clock.Data_Config
{
    public partial class SavedConfigs
    {
        /* Main Form start Configurations */
        private static int presetIndex;

        private static int minDeadline;

        /* Monitor Configuration */
        private static int monitor;

        /* Clock Form Always on top */
        private static bool alwaysOnTop;

        /* Change check - for optimization purposes */
        private static bool configChanged = true;


        public static void updateConfigs()
        {
            presetIndex = savedData.Default.PresetIndex;

            minDeadline = savedData.Default.MinutesUntilDeadline;
            alwaysOnTop = savedData.Default.AlwaysOnTop;

            monitor = savedData.Default.CurrentMonitor;
        }

        public static void saveData()
        {
            savedData.Default.Save();
            updateConfigs();
        }

        /* Getters */
        public static int getDefaultMinDeadline() { return minDeadline; }

        public static bool getDefaultTopStatus() { return alwaysOnTop; }

        public static int getPresetIndex(int maxSelectionOfIndexes) 
        {
            if (presetIndex > maxSelectionOfIndexes || presetIndex < 0)
                return 0;

            return presetIndex; 
        }

        protected static int getDefaultMonitor() { return monitor; }

        /* Setters */
        public static void setDefaultMinDeadline(int min)
        {
            minDeadline = min;
            savedData.Default.MinutesUntilDeadline = minDeadline;

            configChanged = true;
        }

        public static void setDefaulTopStatus(bool action)
        {
            savedData.Default.AlwaysOnTop = action;
            configChanged = true;
        }

        public static void setPresetIndex(int index, int maxSelectionOfIndexes)
        {
            if (presetIndex > maxSelectionOfIndexes)
                presetIndex = maxSelectionOfIndexes;
            else if (presetIndex < 0)
                presetIndex = 0;
            else
                presetIndex = index;
            
            
            savedData.Default.PresetIndex = presetIndex;
        }

        protected static void setDefaultMonitor(int index)
        {
            savedData.Default.CurrentMonitor = index;

            configChanged = true;
        }
    }
}
