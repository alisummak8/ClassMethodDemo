using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client();
            client1.Id =1;
            client1.Name ="E";
            client1.LastName ="D";
            client1.CommunicationAddress="Diyarbakır";

            Client client2 = new Client();
            client2.Id = 2;
            client2.Name = "K";
            client2.LastName = "V";
            client2.CommunicationAddress = "İstanbul";

            Client client3 = new Client();
            client3.Id = 3;
            client3.Name = "Mehmet Ali";
            client3.LastName = "Summak";
            client3.CommunicationAddress = "İstanbul";


            ClientManager clientManager = new ClientManager();
            clientManager.Add(client3);
            clientManager.Delete(client3);
            clientManager.Update(client3);

        }
    }
}
