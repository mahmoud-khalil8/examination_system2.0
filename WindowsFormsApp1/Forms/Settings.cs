using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccess;

namespace WindowsFormsApp1.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            // Populate ComboBoxes
            languageComboBox.Items.AddRange(new string[] { "English", "Arabic", "French" });
            DateCombo.Items.AddRange(new string[] { "dd/MM/yyyy", "MM/dd/yyyy" });

            // Load settings from the database using DatabaseHelper
            string query = "SELECT SettingName, SettingValue FROM Settings";
            DataTable settingsTable = DatabaseHelper.ExecuteQuery(query);

            foreach (DataRow row in settingsTable.Rows)
            {
                string settingName = row["SettingName"].ToString();
                string settingValue = row["SettingValue"].ToString();

                if (settingName == "Language")
                {
                    if (settingValue == "en")
                        languageComboBox.SelectedItem = "English";
                    else if (settingValue == "ar")
                        languageComboBox.SelectedItem = "Arabic";
                    else if (settingValue == "fr")
                        languageComboBox.SelectedItem = "French";
                    else
                        languageComboBox.SelectedItem = "English"; 
                }
                else if (settingName == "DateFormat")
                {
                    DateCombo.SelectedItem = settingValue;
                }
            }
        }

      


        private void savebtn_Click_1(object sender, EventArgs e)
        {

            string selectedLanguage = "en";

            if (languageComboBox.SelectedItem != null)
            {
                string selectedItem = languageComboBox.SelectedItem.ToString();

                if (selectedItem == "English")
                    selectedLanguage = "en";
                else if (selectedItem == "Arabic")
                    selectedLanguage = "ar";
                else if (selectedItem == "French")
                    selectedLanguage = "fr";
            }


            string selectedDateFormat = DateCombo.SelectedItem.ToString();

            // Update settings in the database using DatabaseHelper
            string query = @"
                UPDATE Settings SET SettingValue = @language WHERE SettingName = 'Language';
                UPDATE Settings SET SettingValue = @dateFormat WHERE SettingName = 'DateFormat';
            ";

            SqlParameter[] parameters = {
                new SqlParameter("@language", selectedLanguage),
                new SqlParameter("@dateFormat", selectedDateFormat)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);

            MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            

            this.Close();
        }
    }
}
