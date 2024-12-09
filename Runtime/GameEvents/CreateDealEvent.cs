using DynamicBox.EventManagement;

namespace DynamicBox.GameEvents
{
	public class CreateDealEvent : GameEvent
	{
		public readonly float Amount;
		public readonly string ProductIdString;

		public CreateDealEvent (float amount, string productIdString)
		{
			Amount = amount;
			ProductIdString = productIdString;
		}
	}
}