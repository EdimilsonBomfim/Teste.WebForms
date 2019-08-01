using Cec.Sistemas.Facade.Interfaces;

namespace Cec.Sistemas.Facade
{
    public class FacadeFactory : IFacadeFactory
    {
        public static IFacadeFactory Main
        {
            get
            {
                return new FacadeFactory();
            }
        }

        public IClienteFacade GetCliente()
        {
            return IoC.IoCMain.Resolve<IClienteFacade>();
        }

        public IGrupoFacade GetGrupo()
        {
            return IoC.IoCMain.Resolve<IGrupoFacade>();
        }
    }
}
