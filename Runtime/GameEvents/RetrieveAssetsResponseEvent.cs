using System.Collections.Generic;
using DynamicBox.DynamicXRIntegration.Runtime.Domain;
using DynamicBox.EventManagement;

namespace DynamicBox.GameEvents
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