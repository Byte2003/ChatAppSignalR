using ChatAppSignalR.Models;
using Microsoft.AspNetCore.SignalR;

namespace ChatAppSignalR.Hubs
{
	public class ChatHub: Hub
	{
		public static List<MessageVM> listMessage = new List<MessageVM>();
		public async Task SendMessage(string user, string message)
		{
			listMessage.Add(new MessageVM(user,message));
			await Clients.All.SendAsync("ReceiveMessage",user, message);
		}
	}
}
