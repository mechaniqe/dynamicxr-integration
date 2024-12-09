using DynamicBox.EventManagement;

namespace DynamicBox.DynamicXRIntegration.GameEvents
{
	public class CreateContactEvent : GameEvent
	{
		public readonly string FirstName;
		public readonly string LastName;
		public readonly string Email;
		public readonly string Phone;

		public CreateContactEvent (string firstName, string lastName, string email, string phone)
		{
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Phone = phone;
		}
	}
}