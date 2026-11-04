using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.SignalR;
using SignalR_MVC_Practice.Models;
using System.Drawing;

namespace SignalR_MVC_Practice
{
    public class ChatHub : Hub
    {
        private readonly ChatContext db;
        public ChatHub(ChatContext chatContext)
        {
            db = chatContext;
        }
        public void SendMessage(string name , string message){
            
            //BroadCast to all online clients
             Clients.All.SendAsync("newmessage", name, message);
            // SendMessage: Server - side Hub method
            //newmessage : client-side handler that should be registered in the client 

            //Save in Db 
            Chatmessage mess = new Chatmessage
            {
                Username = name,
                Messagetxt = message
            };
            db.Chatmessages.Add(mess);
            db.SaveChanges();
        }

    }
}
