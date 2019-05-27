using Xamarin.Forms;
using System.IO;
using LicoreraRebajaApp.Services;
using LicoreraRebajaApp.Droid.Services;

[assembly: Dependency(typeof(BaseDatosAndroid))]
namespace LicoreraRebajaApp.Droid.Services
{
    public class BaseDatosAndroid : IBaseDatos
    {
        public string GetDatabasePath()
        {
            return Path.Combine(
                System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal),
                Constantes.NombreBD);
        }
    }
}

