using Microsoft.Win32;

//Seb add
//https://github.com/File-New-Project/EarTrumpet/blob/master/EarTrumpet/Services/UserSystemPreferencesService.cs
namespace ComponentFactory.Krypton.Toolkit
{
    public static class UserSystemPreferencesService
    {
        public static bool IsTransparencyEnabled
        { 
            get 
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    return (int)baseKey.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize").GetValue("EnableTransparency", 0) > 0;
                }
            }
        }

        public static bool UseAccentColor
        {
            get
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    return (int)baseKey.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize").GetValue("ColorPrevalence", 0) > 0;
                }
            }
        }
    }
}
