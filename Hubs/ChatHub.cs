using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.SignalR;
using System.Drawing;

namespace SignalR_MVC_Practice
{
    public class ChatHub : Hub
    {
        public void SendMessage(string message , string name){
            //Save in Db 
            //BroadCast to all online clients
             Clients.All.SendAsync("newmessage", message, name);
            // SendMessage: Server - side Hub method
            //newmessage : client-side handler that should be registered in the client 
        }

    }
}
