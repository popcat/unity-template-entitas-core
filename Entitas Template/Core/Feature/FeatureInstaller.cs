using Zenject;

namespace BartekNizio.EntitasSystem
{
	public class FeatureInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			InstallFeatures();
		}

		private void InstallFeatures()
		{
			//Features to install goes there...
		}
	}
}