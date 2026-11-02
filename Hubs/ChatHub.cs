using Microsoft.AspNetCore.SignalR;

namespace SignalR_MVC_Practice
{
    public class ChatHub : Hub
    {
        public void sendmessage(string message , string name){
            //Save in Db 
            //BroadCast to all online clients
            Clients.All.SendAsync("Hello world", message, name);
        }

    }
}
