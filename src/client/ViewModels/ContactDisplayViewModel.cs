namespace com.ashleigh.angora.client.ViewModels
{
	public class ContactDisplayViewModel
	{
		public string FullName { get; set; } = string.Empty;

		public string LastMessage { get; set; } = string.Empty;

		public bool LastMessageDelivered { get; set; } = false;

		public DateTime? LastMessageDeliveredTime { get; set; }

		public bool LastMessageRead { get; set; } = false;

		public DateTime? LastMessageReadTime { get; set; }

	}
}
