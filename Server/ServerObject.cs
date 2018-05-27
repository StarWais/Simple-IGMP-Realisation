using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    public class ServerObject
    {
        static TcpListener tcpListener;
        List<ClientObject> clients = new List<ClientObject>();
        Grups Groups = new Grups();
        private class Grups
        {
            private List<Group> grups = new List<Group>();
            public void Add(ClientObject cl, int grupid)
            {
                grups.Find(x => x.GroupId == grupid).Add(cl);
                cl.GroupId = grupid;
            }
            public void Remove(ClientObject cl, int grupid)
            {
                grups.Find(x => x.GroupId == grupid).Remove(cl);
                cl.GroupId = -1;
            }
            public void AddNewGroup(int grupid) => grups.Add(new Group() { GroupId = grupid, Clients = new List<ClientObject>() });
            public bool Exists(int grupid)
            {
                foreach(var g in grups)
                {
                    if (g.GroupId.Equals(grupid))
                        return true;
                }
                return false;
            }
            public string Get()
            {
                string st = String.Empty;
                foreach(var g in grups)
                {
                    st += g.GroupId + " ";
                }
                return st;
            }
        }
        private class Group
        {
            public Int32 GroupId;
            public List<ClientObject> Clients;
            public void Add(ClientObject cl) => Clients.Add(cl);
            public void Remove(ClientObject cl) => Clients.Remove(cl);
        }
        protected internal void AddToGroup(ClientObject cl, int grupid)
        {
            if (cl.GroupId == grupid)
                return;
            else
                Groups.Add(cl, grupid);
        }
        protected internal void GetGroups(string id)
        {
            string header = $"Command:Groups\r\nList:{Groups.Get()}";
            SendMessage(header, id);
        }
        protected internal bool CreateGroup(int grupid, string id)
        {
            if (!Groups.Exists(grupid))
            {
                Groups.AddNewGroup(grupid);
                SendMessage("Command:GroupCreated", id);
                return true;
            }
            else
                SendMessage("Command:GroupExists", id);
            return false;
        }
        /// <summary>
        /// Добавить соеденение
        /// </summary>
        /// <param name="clientObject">Объект клиента</param>
        protected internal void AddConnection(ClientObject clientObject) => clients.Add(clientObject);
        /// <summary>
        /// Разорвать соеденение от определенного пользователя
        /// </summary>
        /// <param name="id">ID пользователя</param>
        protected internal void RemoveConnection(string id)
        {
            ClientObject client = clients.FirstOrDefault(x => x.Id == id);
            if (client != null)
                clients.Remove(client);
        }
        /// <summary>
        /// Начать слушать сокет
        /// </summary>
        protected internal void Listen()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8888);
                tcpListener.Start();
                Console.WriteLine("Server started. Waiting for connections...");
                while (true)
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    Console.WriteLine($"Incoming connection from {tcpClient.Client.RemoteEndPoint}");
                    ClientObject clientObject = new ClientObject(tcpClient, this);
                    Thread clientThread = new Thread(new ThreadStart(clientObject.Process));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Disconnect();
            }
        }
        /// <summary>Отправить сообщение всем пользователям указанной группы</summary>
        /// <param name="message">Текст сообщения</param>
        /// <param name="id">ID пользователя</param>
        protected internal void BroadcastMessage(string message, string id, int groupid)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            for (int i = 0; i < clients.Count; i++)
            {
                if(clients[i].GroupId.Equals(groupid))
                    clients[i].client.Client.Send(data);
            }
        }
        protected internal void BroadcastAll(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            for (int i = 0; i < clients.Count; i++)
            {
                clients[i].client.Client.Send(data);
            }
        }
        /// <summary>Отправить сообщение определенному пользователю</summary>
        /// <param name="message">Текст сообщения</param>
        /// <param name="id">ID пользователя</param>
        protected internal void SendMessage(string message, string id)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].Id == id)
                {
                    clients[i].client.Client.Send(data);
                    break;
                }
            }
        }
        /// <summary>
        /// Отключить всех пользователей
        /// </summary>
        protected internal void Disconnect()
        {
            tcpListener.Stop(); 

            foreach(var client in clients)
            {
                client.Close(); 
            }
            Environment.Exit(0); 
        }
    }
}