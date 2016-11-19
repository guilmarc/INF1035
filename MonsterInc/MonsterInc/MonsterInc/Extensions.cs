using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Core
{
    public static class Extensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objectToSerialize"></param>
        /// <param name="nameOfFile"></param>
        /// <param name="defaultPath">System.Reflection.Assembly.GetExecutingAssembly().Location</param>
        /// <returns></returns>
        public static void XmlSerialize<T>(this T objectToSerialize, string nameOfFile, bool defaultPath )
        {
            if (!nameOfFile.ToLower().Contains(".xml"))
            {
                nameOfFile = nameOfFile + ".xml";
            }
            string directory ="";
            if (defaultPath)
            {
                directory = System.Reflection.Assembly.GetExecutingAssembly().Location;
            }
            string fullPath = $@"{directory}\{nameOfFile}";
            ///forstring
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            //StringWriter stringWriter = new StringWriter();
            //XmlTextWriter xmlWriter = new XmlTextWriter(stringWriter);

            //xmlWriter.Formatting = Formatting.Indented;
            //xmlSerializer.Serialize(xmlWriter, objectToSerialize);

            //return stringWriter.ToString();



            //todocument
            XmlSerializer serialiser = new XmlSerializer(typeof(T));
            TextWriter Filestream = new StreamWriter(fullPath);
            serialiser.Serialize(Filestream, objectToSerialize);
            Filestream.Close();

        }
    }


}

