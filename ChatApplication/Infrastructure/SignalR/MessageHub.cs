using ChatApplication.Application.DTOs;
using ChatApplication.Application.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace ChatApplication.Infrastructure.SignalR;

public class MessageHub : Hub<IMessageClient>
{
    public async Task SendMessage(MessageDto message)
    {
        await Clients.All.SendMessage(message);
    }
    
}