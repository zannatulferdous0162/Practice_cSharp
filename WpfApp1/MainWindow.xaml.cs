using System.IO;
using System.Windows;
using Newtonsoft.Json;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Method to save user information to a JSON file
        private void SaveUserInfo(UserInfo userInfo)
        {
            string json = JsonConvert.SerializeObject(userInfo, Formatting.Indented);
            File.WriteAllText("userInfo.json", json);
        }

        // Method to load user information from a JSON file
        private UserInfo LoadUserInfo()
        {
            if (File.Exists("userInfo.json"))
            {
                string json = File.ReadAllText("userInfo.json");
                return JsonConvert.DeserializeObject<UserInfo>(json);
            }
            return null;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            UserInfo userInfo = new UserInfo
            {
                Username = UsernameTextBox.Text,
                Password = PasswordBox.Password,
                FullName = FullNameTextBox.Text,
                Email = EmailTextBox.Text,
                SchoolName = SchoolNameTextBox.Text
            };

            // Save user info to JSON file
            SaveUserInfo(userInfo);

            // Load user info from JSON file (just for demonstration)
            UserInfo loadedUserInfo = LoadUserInfo();
            if (loadedUserInfo != null)
            {
                MessageBox.Show($"Loaded User Info:\n\nUsername: {loadedUserInfo.Username}\nFull Name: {loadedUserInfo.FullName}\nEmail: {loadedUserInfo.Email}\nSchool: {loadedUserInfo.SchoolName}", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
