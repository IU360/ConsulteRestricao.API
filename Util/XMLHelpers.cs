using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ConsulteRestricao.Api.Util
{
    static class XMLHelpers
    {
        public static T DeserializeXMLToObject<T>(string XmlFilename)
        {   
            if (string.IsNullOrEmpty(XmlFilename)) return default(T);


            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(XmlFilename))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        public static string SerializeObjectToXML<T>(this T value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            try
            {
                var xmlserializer = new XmlSerializer(typeof(T));
                var stringWriter = new StringWriter();
                var settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.OmitXmlDeclaration = true;
                using (var writer = System.Xml.XmlWriter.Create(stringWriter, settings))
                {
                    xmlserializer.Serialize(writer, value);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }
    }
}
