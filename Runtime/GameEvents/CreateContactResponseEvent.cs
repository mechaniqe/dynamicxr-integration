using DynamicBox.EventManagement;

namespace DynamicBox.DynamicXRIntegration.GameEvents
{
	public class CreateContactResponseEvent : GameEvent
	{
		public readonly bool IsSuccess;

		public CreateContactResponseEvent (bool isSuccess)
		{
			IsSuccess = isSuccess;
		}
	}
}