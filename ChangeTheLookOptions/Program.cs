using System;

namespace ChangeTheLookOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "username@tenant.onmicrosoft.com";
            string password = "password";
            string siteUrl = "https://tenant.sharepoint.com/sites/yoursite";
            HeaderLayout layout = HeaderLayout.Standard;
            HeaderBackground background = HeaderBackground.Darker;
            MenuStyle menuStyle = MenuStyle.Cascading;

            try
            {
                ChangeTheLookOptionsHelper.ChangeHeaderLayout(siteUrl, layout, userName, password);
                Console.WriteLine($"Header Layout changed to {layout.ToString()} for {siteUrl}.");

                ChangeTheLookOptionsHelper.ChangeHeaderBackground(siteUrl, background, userName, password);
                Console.WriteLine($"Header Background changed to {background.ToString()} for {siteUrl}.");

                ChangeTheLookOptionsHelper.ChangeMenuStyle(siteUrl, menuStyle, userName, password);
                Console.WriteLine($"Menu Style changed to {menuStyle.ToString()} for {siteUrl}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error " + ex.Message);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
