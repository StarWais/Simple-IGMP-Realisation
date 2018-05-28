using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Kursach
{
    class Listener
    {
        private static Listener instance;
        public TcpClient client = new TcpClient();
        private Listener()
        {
            client = new TcpClient();
            try
            {
                client.Connect("127.0.0.1", 8888);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, $"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Listener getInstance()
        {
            if (instance == null)
                instance = new Listener();
            return instance;
        }
    }
}
