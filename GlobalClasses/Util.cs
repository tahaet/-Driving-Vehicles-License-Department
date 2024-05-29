using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MySolution.GlobalClasses
{
    public class clsUtil
    {
        public static string GenerateGUID()
        {
            Guid newGuid = Guid.NewGuid();
            return newGuid.ToString();
        }
        public static string ReplaceFileNameWithGuid(string FileName)
        {
           FileInfo fi=new FileInfo(FileName);
           string extension=fi.Extension;
            return GenerateGUID() + extension;
        }
        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch(IOException ex) 
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool CopyImageToProjectImageFolder(ref string SourceImageFile)
        {
            string DestinationFolder = @"C:\DVLD-People-Images\";
            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }
            string DestinationFile=DestinationFolder+ReplaceFileNameWithGuid(SourceImageFile);
            try
            {
                File.Copy(SourceImageFile, DestinationFile, true);
            }
            catch (IOException iox) 
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            SourceImageFile = DestinationFile;
            return true;
        }
    }
}
