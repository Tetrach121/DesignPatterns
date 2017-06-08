using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DesignPatterns.TemplateMethod
{
    abstract class DataAccessObject
    {
        protected string connectionString;
        protected DataSet dataSet;

        public virtual void Connect()
        {
            connectionString = "provider=Microsoft.JET.OLEDB.4.0; " + "data source=..\\..\\..\\db1.mdb";
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            connectionString = "";
        }

        // Metoda szablonowa - Template Method
        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}
