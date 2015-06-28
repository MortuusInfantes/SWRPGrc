using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace SWRPGrc.Classes
{
    public static class DataWriter
    {
    }

    class MySerializer
    {
        Type targetType;

        public MySerializer(Type targetType)
        {
            this.targetType = targetType;
            if (!targetType.IsDefined(typeof(DataContractAttribute), false))
                throw new Exception("Invalid serialization type");
        }
        public void WriteObject(Stream stream, object graph)
        {
            IEnumerable<PropertyInfo> serializableProperties =
                targetType.GetProperties().Where(p => p.IsDefined(typeof(DataMemberAttribute), false));
            var writer = new StreamWriter(stream);
            //writeShit
            writer.Write("");
        }
    }
}
