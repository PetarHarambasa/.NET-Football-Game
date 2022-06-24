using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WorldCupLibrary.Model;
using WorldCupLibrary.Utils;

namespace WorldCupLibrary.User
{
    public class User
    {
        private const string SETTINGS = @"../../../AppSettings.json";
        private const string IMAGE = "@../../../../../PlayerPictures.json";

        public static Settings settings = new Settings();
        public static IList<ImageSettings> imageSettings = new List<ImageSettings>();

        public static string CountryName { get; set; }

        public static void SaveSettings()
        {
            FileUtils<Settings>.SaveDataToJSON(settings, SETTINGS);
        }


        public static void LoadSettings()
        {
            settings = FileUtils<Settings>.LoadDataFromJSON(SETTINGS);

            if (settings == null)
            {
                settings = new Settings();
            }
        }

        public static void SaveImageSettings()
        {
            FileUtils<IList<ImageSettings>>.SaveDataToJSON(imageSettings, IMAGE);
        }

        public static void SetLanguage(string language)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
        }

        public static IList<ImageSettings> LoadImageSettings()
        {
            imageSettings = FileUtils<IList<ImageSettings>>.LoadDataFromJSON(IMAGE);

            if (imageSettings == null)
            {
                imageSettings = new List<ImageSettings>();
            }

            return imageSettings;
        }

        public static string GetCountryCode(string contry)
        {
            string[] details = contry.Split(' ');
            string contryCode = "";

            if (details.Length == 2)
            {
                CountryName = details[0];
                contryCode = details[1];
                contryCode = contryCode.TrimStart('(').TrimEnd(')');
            }
            else if (details.Length == 3)
            {
                CountryName = details[0] + " " + details[1];
                contryCode = details[2];
                contryCode = contryCode.TrimStart('(').TrimEnd(')');
            }

            return contryCode;
        }

    }
}
