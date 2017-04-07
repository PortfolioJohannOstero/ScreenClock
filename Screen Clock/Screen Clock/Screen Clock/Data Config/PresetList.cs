using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Screen_Clock.Data_Config
{
    
    class PresetList
    {
        List<Preset> pList;
        string path;

        public PresetList(string filePath)
        {
            path = filePath;

            pList = new List<Preset>();
        }


        // De-serializing objects
        public void readFromFile() 
        {
            Stream stream;

            try
            {
                stream = File.Open(path, FileMode.Open);
            }
            catch (Exception)
            {
                stream = File.Open(path, FileMode.Create);
                stream.Close();
                stream = File.Open(path, FileMode.Open);
            }
            
            BinaryFormatter bFormatter = new BinaryFormatter();
            
            Console.WriteLine("Reading Preset Information: ");

            try
            {
                pList = ((List<Preset>)bFormatter.Deserialize(stream));
            }
            catch (Exception)
            {
                pList.Add(new Preset());
            }
                


            stream.Close();
        }

        // Serializing objects
        public void saveToFile()
        {
            Stream stream = File.Open(path, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();

            bFormatter.Serialize(stream, pList);
            stream.Close();
        }

        public void addPreset(int monitorNum, int sizeType, int loc_x, int loc_y, int size, int clockType, string name, AnalogLayout layout, ColourScheme digitalColour, bool displaySeconds)
        {
            Preset preset = new Preset(monitorNum, sizeType, loc_x, loc_y, size, clockType, name, layout, digitalColour, displaySeconds);
            pList.Add(preset);
        }

        public void removePresetAtIndex(int index)
        {
            if (index != 0)
                pList.RemoveAt(index);
        }


        /* ------------------------ ACCESSORS ------------------------ */
        public int Size()
        {
            return pList.Count;
        }

        /* Operator Overloading: Index (i.e [ ]) */
        public Preset this[int i]
        {
            get { return pList[i]; }
            set { pList[i] = value; }
        }
    }
}
