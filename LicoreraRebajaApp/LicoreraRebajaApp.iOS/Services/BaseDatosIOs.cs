using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using LicoreraRebajaApp.Services;

[assembly: Dependency(typeof(BaseDatosIOs))]
namespace LicoreraRebajaApp.iOS.Services
{
    public class BaseDatosIOs : IBaseDatos
    {
        public string GetDatabasePath()
        {
            return Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments),
                "..",
                "Library",
                Constantes.NombreBD);
        }
    }
}