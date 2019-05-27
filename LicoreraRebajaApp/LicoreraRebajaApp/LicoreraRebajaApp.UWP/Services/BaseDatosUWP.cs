using System.IO;
using Xamarin.Forms;
using Windows.Storage;
using LicoreraRebajaApp.UWP.Services;
using LicoreraRebajaApp.Services;

[assembly: Dependency(typeof(BaseDatosUWP))]
namespace LicoreraRebajaApp.UWP.Services
{
    public class BaseDatosUWP : IBaseDatos
    {
        public string GetDatabasePath()
        {
            return Path.Combine(
                ApplicationData.Current.LocalFolder.Path,
                Constantes.NombreBD);
        }
    }
}
