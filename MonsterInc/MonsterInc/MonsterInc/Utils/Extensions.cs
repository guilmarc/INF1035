using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public static void OnPropertyCHange(this PropertyChangedEventHandler propertyChanged, object sender, string propertyName)
        {
            if (propertyChanged != null)
            {
                propertyChanged(sender, new PropertyChangedEventArgs(propertyName));
            }
        }


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

        public static T Load<T>()
        {

            if (typeof(T) is Core.Model.Skill)
            {

            }

            if (typeof(T) is Core.Model.MonsterTemplate)
            {

            }

            if (typeof(T) is Core.Model.Item)
            {

            }


            throw new NotImplementedException();
        }


        /// <summary>Deserializes an xml string in to an object of Type T</summary>
        /// <typeparam name="T">Any class type</typeparam>
        /// <param name="xml">Xml as string to deserialize from</param>
        /// <returns>A new object of type T is successful, null if failed</returns>
        public static T XmlDeserialize<T>(this string xml) where T : class, new()
        {
            if (xml == null) throw new ArgumentNullException("xml");
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(xml))
            {
                try { return (T)serializer.Deserialize(reader); }
                catch { return null; } // Could not be deserialized to this type.
            }
        }
    }
}

