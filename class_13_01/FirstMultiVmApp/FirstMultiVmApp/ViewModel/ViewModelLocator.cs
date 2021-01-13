/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:FirstMultiVmApp"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;


namespace FirstMultiVmApp.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<MasterDataVm>(true);
            SimpleIoc.Default.Register<ReportVm>();
            SimpleIoc.Default.Register<DynamicDataVm>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public MasterDataVm MasterData
        {
            get { return ServiceLocator.Current.GetInstance<MasterDataVm>();
            }
        }
        public DynamicDataVm DynData
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DynamicDataVm>();
            }
        }

        public ReportVm Reports
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ReportVm>();
            }
        }
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}