using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class ClientManager
    {
        public void Add(Client client) 
        {
            Console.WriteLine(client.Name + " " + client.LastName + " listeye eklendi.");
        }
        public void Delete(Client client)
        {
            Console.WriteLine(client.Name + " " + client.LastName + " listeden kaldırıldı.");
        }
        public void Update(Client client)
        {
            Console.WriteLine(client.Name + " " + client.LastName + " güncellendi.");
        }
    }
}
