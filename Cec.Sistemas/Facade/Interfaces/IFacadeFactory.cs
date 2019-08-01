namespace Cec.Sistemas.Facade.Interfaces
{
    public interface IFacadeFactory
    {
        IGrupoFacade GetGrupo();
        IClienteFacade GetCliente();
    }
}
