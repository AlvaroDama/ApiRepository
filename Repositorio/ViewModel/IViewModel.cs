namespace Repositorio.ViewModel
{
    public interface IViewModel<TModelo> where TModelo:class //el where retringe
    {
        TModelo ToBaseDatos();

        void FromBaseDatos(TModelo modelo);

        void UpdateBaseDatos(TModelo modelo);

    }
}