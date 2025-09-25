using Zenject;

namespace BartekNizio.Unity.Template.Entitas.Core
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