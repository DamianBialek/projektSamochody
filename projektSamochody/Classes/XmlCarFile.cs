using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using projektSamochody.Classes;
using System.Windows.Forms;

namespace projektSamochody.Classes
{
    class XmlCarFile
    {
        static string filename = "samochody.xml";
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Path.DirectorySeparatorChar;

        public static void saveToFile(List<Samochod> listaSamchodow)
        {
            string fullFileName = path + filename;
            using(FileStream stream = new FileStream(fullFileName, FileMode.Create))
            {
                    var xml = new XmlSerializer(typeof(List<Samochod>));
                    xml.Serialize(stream, listaSamchodow);
            }

            MessageBox.Show("Pomyślnie zapisano do pliku: " + fullFileName, "Udało się !");
        }

        public static List<Samochod> readFile()
        {
            string fullFileName = path + filename;
            using (FileStream stream = new FileStream(fullFileName, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(List<Samochod>));
                return (List<Samochod>)xml.Deserialize(stream);
            }
        }
    }
}
