using Prism.DryIoc;
using Prism.Ioc;

using QF.Notices.Views;

using System.Configuration;
using System.Data;
using System.Windows;

namespace QF.Notices
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Login>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }

}
