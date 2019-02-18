using System;
using System.Runtime.Serialization;

namespace Inventory.Configuration
{
    class Config
    {
        private string connString;
        private static object @lock = new object();
        private static Config theInstance;

        public Config()
        {
            var dbAccess = new MainConn(); // Making a new instance of the MainConn Class
            connString = dbAccess.ConnectionString; // Getting the DataSource Property and passing the value             
        }

        public string Connection
        {
            get { return connString; } // Returning the database connection string from the instantiated class
        }

        public static Config Instance
        {
            get
            {
                lock (@lock)
                {
                    if (theInstance == null)
                    {
                        theInstance = new Config();
                    }
                }
                return theInstance;
            }
        }

        // Serialization functionality
        [Serializable()]
        public class SerializationHelper : ISerializable
        {
            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                var theSingleton = Instance;
                lock (theSingleton) { }
            }
        }

    }
}
