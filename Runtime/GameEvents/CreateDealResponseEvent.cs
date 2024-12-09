using DynamicBox.EventManagement;

namespace DynamicBox.DynamicXRIntegration.GameEvents
{
	public class CreateDealResponseEvent : GameEvent
	{
		public readonly bool IsSuccess;

		public CreateDealResponseEvent (bool isSuccess)
		{
			IsSuccess = isSuccess;
		}
	}
}