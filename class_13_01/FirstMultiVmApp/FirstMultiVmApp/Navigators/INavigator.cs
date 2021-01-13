using GalaSoft.MvvmLight;

namespace FirstMultiVmApp.Navigators
{
    public interface INavigator
    {
        ViewModelBase Navigate(string param);
    }
}