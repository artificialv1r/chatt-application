using ChatApplication.Application.DTOs;

namespace ChatApplication.Application.Interfaces;

public interface IMessageClient
{
    Task SendMessage(MessageDto message);
}