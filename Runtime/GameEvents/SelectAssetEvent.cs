using DynamicBox.EventManagement;

namespace DynamicBox.GameEvents
{
	public class SelectAssetEvent : GameEvent
	{
		public readonly long AssetId;

		public SelectAssetEvent (long assetId)
		{
			AssetId = assetId;
		}
	}
}