using DynamicBox.DynamicXRIntegration.Domain;
using DynamicBox.EventManagement;
using System.Collections.Generic;

namespace DynamicBox.DynamicXRIntegration.GameEvents
{
	public class RetrieveAssetsResponseEvent : GameEvent
	{
		public readonly List<AssetData> Assets;

		public RetrieveAssetsResponseEvent (List<AssetData> assets)
		{
			Assets = assets;
		}
	}
}