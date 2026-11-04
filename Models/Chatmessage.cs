using System;
using System.Collections.Generic;

namespace SignalR_MVC_Practice.Models;

public partial class Chatmessage
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Messagetxt { get; set; }
}
