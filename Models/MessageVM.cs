namespace ChatAppSignalR.Models
{
	public class MessageVM
	{
		public string UserName { get; set; }
		public string Message { get; set; }

		public MessageVM(string userName, string message)
		{
			UserName= userName;
			Message = message;
		}
	}
}
