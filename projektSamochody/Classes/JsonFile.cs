using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using System.Windows.Forms;

namespace projektSamochody.Classes
{
    public static class JsonFile
    {
        static string filename = "json.txt";
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+Path.DirectorySeparatorChar;

        public static void writeToFile(object objectToWrite)
        {
            string json = new JavaScriptSerializer().Serialize(objectToWrite);
            string fullFileName = JsonFile.path + JsonFile.filename;

            File.WriteAllText(fullFileName, json);

            MessageBox.Show("Pomyślnie zapisano do pliku: " + fullFileName, "Udało się !");
        }

        public static List<Samochod> readJsonFile()
        {
            string fullFileName = JsonFile.path + JsonFile.filename;

            if (!File.Exists(fullFileName))
                throw new Exception("Nie znaleziono pliku ! \r\n"+fullFileName);

            string fileText = File.ReadAllText(fullFileName);

            List<Samochod> lista = (List<Samochod>)new JavaScriptSerializer().Deserialize(fileText, typeof(List<Samochod>));

            return lista;
        }

        public static void pobierzSciezkeDoPliku(string type = "read")
        {
            string fileName = String.Empty;
            if (String.Equals(type, "read"))
            {
                OpenFileDialog fileBrowser = new OpenFileDialog();
                fileBrowser.ShowDialog();
                fileName = fileBrowser.FileName;
            }
            else if (String.Equals(type, "write"))
            {
                SaveFileDialog fileBrowser = new SaveFileDialog();
                fileBrowser.ShowDialog();
                fileName = fileBrowser.FileName;
            }

            Console.WriteLine(fileName);
        }

    }
}
