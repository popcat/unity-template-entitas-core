using Zenject;

namespace BartekNizio.EntitasSystem
{
	public class ContextInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.BindInstance( Contexts.sharedInstance );
			Container.Bind<ContextService>().AsSingle();
		}
	}
}