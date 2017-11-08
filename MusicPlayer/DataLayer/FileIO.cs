using System;
using System.Collections.Generic;
using System.IO;
using Winforms = System.Windows.Forms;

public static class FileIO
{
    /// <summary>
    /// This method reads the front cover, back cover, autobiography and tracks from file and returns it as an dictionary
    /// </summary>
    /// <returns>An dictionary containing a music album</returns>
    public static Dictionary<string, byte[]> GetAlbum()
    {
        try
        {
            string albumPath = "";
            string generalAlbumInfoPath;
            string albumTracksPath;
            string key;
            Dictionary<string, byte[]> albumData = new Dictionary<string, byte[]>();

            Winforms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            if (fbd.ShowDialog() == Winforms.DialogResult.OK)
            {
                albumPath = fbd.SelectedPath;
            }
            else
            {
                albumData = null;
                return albumData;
            }
            generalAlbumInfoPath = albumPath + "\\generalAlbumInfo";
            albumTracksPath = albumPath + "\\tracks";

            string[] generalAlbumInfoFiles = Directory.GetFiles(generalAlbumInfoPath);
            string[] albumTracksFiles = Directory.GetFiles(albumTracksPath);

            foreach (string filePath in generalAlbumInfoFiles)
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] binaryObject = br.ReadBytes((int)fs.Length);
                //Get the key out of the filePath
                key = GetFileNameFromPath(filePath);
                albumData.Add(key, binaryObject);
            }

            foreach (string filePath in albumTracksFiles)
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] binaryObject = br.ReadBytes((int)fs.Length);
                //Get the key out of the filePath
                key = GetFileNameFromPath(filePath);
                albumData.Add(key, binaryObject);
            }
            return albumData;
        }
        catch (IOException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private static string GetFileNameFromPath(string path)
    {
        string[] splitPath = path.Split('\\');
        string[] splitFile = splitPath[splitPath.Length - 1].Split('.');
        string key = splitFile[0].ToString();
        return key;
    }
}