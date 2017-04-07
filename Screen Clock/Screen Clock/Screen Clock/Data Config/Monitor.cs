using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Clock.Data_Config
{
    class Monitor : SavedConfigs
    {
/* ----------- Data Members ----- */
        static Screen[] allMonitors = Screen.AllScreens;
        static Screen primaryMonitor = Screen.PrimaryScreen;

        static int monIndex = 0;
        static int numOfMonitors = 0;

        static bool isFullScreen = false;

/* ----------- Constructor & init methods ------ */

        static public void update()
        {
            allMonitors = Screen.AllScreens;
            primaryMonitor = Screen.PrimaryScreen;

            numOfMonitors = allMonitors.Length;

            MonitorIndex = Data_Config.SavedConfigs.getDefaultMonitor();
            Data_Config.SavedConfigs.setDefaultMonitor(monIndex); 
        }

/* ----------- GETTERS AND SETTERS ------ */
        static public int MonitorIndex
        {
            get { return monIndex; }
            set { monIndex = getValidatedIndex(value); }
        }

        static public System.Windows.Forms.Screen PrimaryMonitor
        {
            get { return primaryMonitor; }
        }

        static public Screen[] AllMonitors
        {
            get { return allMonitors; }
        }

        static public Screen[] AllButPrimaryMonitor()
        {
            Screen[] temp = new Screen[numOfMonitors-1];

            for (int i = 0, j = 0; i < numOfMonitors; i++)
            {
                if (allMonitors[i] == primaryMonitor)
                {
                    j++;
                    continue;
                }

                temp[i - j] = allMonitors[i];
            }

            return temp;
        }

        static public Screen CurrentScreen()
        {
            return allMonitors[monIndex];
        }

        static public bool IsFullScreen
        {
            get { return isFullScreen; }
            set { isFullScreen = value; }
        }

/* ----------- Check Methods ------ */
        static public bool isOnlyOneMonitor()
        {
            return allMonitors.Length == 1;
        }

        /* Checks to see if the assigned monitor index is valid or not, and if not then the value will be changed to something which is...*/
        static private int getValidatedIndex(int index)
        {
            int temp = 0;

            if (isOnlyOneMonitor() || index < 0)
                return 0;

            if (index >= numOfMonitors)
                temp = numOfMonitors;

            if (allMonitors[temp] == primaryMonitor)
            {
                for (int i = 0; i < numOfMonitors; i++)
                    temp = (allMonitors[i] == primaryMonitor) ? 0 : i; 
            }

            return temp;
        }


        /*
        static Screen[] allMonitors = Screen.AllScreens;
        static Screen primaryMonitor = Screen.PrimaryScreen;
        static int monIndex = 0;

        static Timer monitorCheck = new Timer();
        static bool oneMonLoopToggler = true;

        static bool isFullScreen = true;
        static bool monSetupIsChanged = false;




        static public bool MonSetupIsChanged
        {
            get { return monSetupIsChanged; }
            set { monSetupIsChanged = value; }
        }

        public static void initMonitorCheck(int checkTimeInMilliseconds)
        {
            monitorCheck.Interval = checkTimeInMilliseconds;
            monitorCheck.Tick += new EventHandler(monitorCheck_Tick);

            monIndex = SavedConfigs.getDefaultMonitor();
        }

        public static void toggleMonitorCheck(bool state)
        {
            if (state)
            {
                monitorCheck.Enabled = true;
                monitorCheck.Start();
            }
            else
            {
                monitorCheck.Enabled = false;
                monitorCheck.Stop();
            }
        }

        public static void update()
        {
            allMonitors = Screen.AllScreens;
            primaryMonitor = Screen.PrimaryScreen;

        }

        private static void monitorCheck_Tick(object sender, EventArgs e)
        {
            primaryMonitor = Screen.PrimaryScreen;
            if (currMonIsEqualToPrimMon() && allMonitors.Length != 1)
            {
                reCalibrateMon();
                monSetupIsChanged = true;
            }

            if (!moreThanOneMon())
            {
                if (oneMonLoopToggler)
                {
                    allMonitors = Screen.AllScreens;
                    reCalibrateMon();
                    monSetupIsChanged = true;
                }

                oneMonLoopToggler = false;
            }
            else
            {
                oneMonLoopToggler = true;
            }
        }

        public static void reCalibrateMon()
        {
            if (moreThanOneMon())
            {
                update();
                int index = 0;
                bool quit = false;
                while (!quit)
                {
                    if (allMonitors[index].DeviceName == primaryMonitor.DeviceName)
                        quit = true;


                    if (index < allMonitors.Length - 1)
                        index++;
                    else
                        index--;
                }
                monIndex = index;
                setCurrentMonitor(monIndex);
            }
        }

        public static bool currMonIsEqualToPrimMon()
        {
            if (moreThanOneMon())
            {
                int primaryIndex = getPrimaryIndex();

                return monIndex == primaryIndex;
            }
            else
                return true; 
        }

        private static int getPrimaryIndex()
        {
            int index = 0;

            while (allMonitors[index] != primaryMonitor)
                index++;

            return index;
        }

        public static bool moreThanOneMon()
        {
            return (allMonitors.Length > 1) ? true : false;
        }

        public static void isItFullScreen(bool answer)
        {
            isFullScreen = answer;
        }

        public static Screen[] getAllMonButPrimMon()
        {
            Screen[] temp;

            if (moreThanOneMon())
            {
                temp = new Screen[allMonitors.Length - 1];

                for (int i = 0, j = 0; i < allMonitors.Length; i++)
                {
                    if (allMonitors[i].DeviceName == primaryMonitor.DeviceName)
                    {
                        j++;
                        continue;
                    }

                    temp[i - j] = allMonitors[i];
                }
            }
            else
            {
                temp = allMonitors;
            }

            return temp;
        }

        public static Screen getPrimaryMon()
        {
            return primaryMonitor;
        }

        public static Screen getCurrentScreen()
        {
            if (allMonitors.Length == 1)
                monIndex = 0;

            return allMonitors[monIndex];
        }

        public static int getCurrentMonitorIndex()
        {
            update();
            return validateIndexValue(SavedConfigs.getDefaultMonitor());
        }

        public static void setCurrentMonitor(int index)
        {
            monIndex = index;

            if (isFullScreen)
            {
                if (currMonIsEqualToPrimMon())
                    reCalibrateMon();
            }

            SavedConfigs.setDefaultMonitor(monIndex);
        }

        private static int validateIndexValue(int index)
        {
            update();
            int maxSize = getAllMonButPrimMon().Length;
            int temp = 0;

            if (index < 0)
                temp = 0;
            else if (index > maxSize - 1)
                temp = maxSize - 1;
            else
                temp = index;

            if (temp != index)
                setCurrentMonitor(temp);

            return temp;
        }
         * */
    }
}
