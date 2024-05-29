using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace MySolution.GlobalClasses
{
    public class clsGlobal
    {
        private const string valueName = "DVLDUserCredintials";
        private const string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLDUserCredintials";

        public static clsUser CurrentUser;

        public static bool RememberUserNameAndPassword(string UserName,string Password)
        {
            string value = $"{UserName}#//#{Password}";
            try
            {
                Registry.SetValue(keyPath, valueName, value, RegistryValueKind.String);
                return true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
        public static bool GetStoredCredintial(ref string UserName,ref string Password)
        {
            try
            {
              
                string value=Registry.GetValue(keyPath, valueName,null) as string;
                
                if (value != null)
                {
                    string[] result = value.Split(new string[]{"#//#"},StringSplitOptions.None);
                    UserName= result[0];
                    Password= result[1];
                    return true;
                }
                else
                    return false;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }
        
    }
}
