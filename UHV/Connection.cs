using System;

namespace UHV
{
    class Connection
    {
        static string direct = Environment.CurrentDirectory;
        public static string Connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + direct + @"\DB\UHV_DB.mdf;Integrated Security=True;Connect Timeout=30";
    }
}
