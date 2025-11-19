using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Win32;
using Excel = Microsoft.Office.Interop.Excel;

public class OneDrivePathConverter
{
    // Trouve tous les dossiers OneDrive dans le profil utilisateur
    private static List<string> GetOneDriveFolders()
    {
        var oneDriveFolders = new List<string>();
        string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        if (Directory.Exists(userProfile))
        {
            var folders = Directory.GetDirectories(userProfile, "OneDrive*");
            oneDriveFolders.AddRange(folders);
        }

        return oneDriveFolders;
    }

    // Convertit une URL OneDrive en chemin local
    public static string ConvertUrlToLocalPath(string url)
    {
        if (!url.StartsWith("http", StringComparison.OrdinalIgnoreCase))
            return url; // Déjà un chemin local

        // Extraire le nom de fichier et quelques dossiers parents depuis l'URL
        Uri uri = new Uri(url);
        string[] urlSegments = uri.AbsolutePath.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

        // Décoder les segments (espaces = %20, etc.)
        for (int i = 0; i < urlSegments.Length; i++)
        {
            urlSegments[i] = Uri.UnescapeDataString(urlSegments[i]);
        }

        // Chercher dans tous les dossiers OneDrive
        var oneDriveFolders = GetOneDriveFolders();

        foreach (string oneDriveFolder in oneDriveFolders)
        {
            // Essayer de matcher avec différentes longueurs de chemin
            // (on ne sait pas exactement où commence le chemin relatif dans l'URL)
            for (int startIndex = 0; startIndex < urlSegments.Length - 1; startIndex++)
            {
                string relativePath = string.Join("\\", urlSegments.Skip(startIndex));
                string fullPath = Path.Combine(oneDriveFolder, relativePath);

                if (File.Exists(fullPath))
                {
                    return fullPath;
                }
            }
        }

        return null; // Pas trouvé
    }


}