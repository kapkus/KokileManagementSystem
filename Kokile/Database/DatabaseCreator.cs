using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Kokile.Database
{
    public class DatabaseCreator
    {
        public static void Create()
        {
            CopyDatabaseFromEmbeddedResource();
        }

        // method to copy database with initial data from embedded resource to local file since inserting big amounts of data was too slow
        private static void CopyDatabaseFromEmbeddedResource()
        {
            string resourceName = "Kokile.Database.kokile.db";
            string outputFileName = @"data\kokile.db";

            Assembly assembly = Assembly.GetExecutingAssembly();

            using (Stream resourceStream = assembly.GetManifestResourceStream(resourceName))
            {
                if (resourceStream == null)
                {
                    throw new Exception("Embedded resource not found.");
                }

                if (File.Exists(outputFileName))
                {
                    MessageBox.Show("Baza danych już istnieje.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (FileStream fileStream = new FileStream(outputFileName, FileMode.Create))
                {
                    resourceStream.CopyTo(fileStream);
                }
            }
        }
    }
}
