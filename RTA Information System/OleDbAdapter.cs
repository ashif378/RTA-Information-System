using System.Data.OleDb;

namespace RTA_Information_System
{
    internal class OleDbAdapter
    {
        private OleDbCommand cmd;

        public OleDbAdapter(OleDbCommand cmd)
        {
            this.cmd = cmd;
        }
    }
}