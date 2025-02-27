using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataAccess;

namespace WindowsFormsApp1.BusinessLogic
{
    internal class TranslationHelper
    {
        public static string GetTranslation(string resourceKey)
        {
            string languageCode = GetSetting("Language"); // "en", "ar", "fr"

            string query = "SELECT ResourceValue FROM Translations WHERE LanguageCode = @languageCode AND ResourceKey = @resourceKey";
            SqlParameter[] parameters = {
                new SqlParameter("@languageCode", languageCode),
                new SqlParameter("@resourceKey", resourceKey)
            };

            object result = DatabaseHelper.ExecuteScalar(query, parameters);
            return result?.ToString() ?? resourceKey; // Fallback to the key if not found
        }

        public static string GetSetting(string settingName)
        {
            string query = "SELECT SettingValue FROM Settings WHERE SettingName = @settingName";
            SqlParameter[] parameters = {
                new SqlParameter("@settingName", settingName)
            };

            object result = DatabaseHelper.ExecuteScalar(query, parameters);
            return result?.ToString() ?? string.Empty;
        }

    }
}
