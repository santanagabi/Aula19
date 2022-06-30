using System.Windows;
using Caliburn.Micro;
using Aula19.ViewModels;

namespace Aula19
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            base.Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // Define qual será o Controlador padrão
            // Nota: O controlador MainViewModel ainda não foi criado nessa etapa.
            base.DisplayRootViewFor<MainViewModel>();
        }
    }
}