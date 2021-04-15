using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string BackgroundImagePath { get; set; }
        public string ProfilePicturePath { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (SendMessageTxtb.Text != "")
            {
                var message = new MessageUC
                {
                    MessageTextblock = SendMessageTxtb.Text,
                    MessageTimeTextblock = DateTime.Now.ToShortTimeString()
                };
                MessageListBox.Items.Add(message);
                SendMessageTxtb.Clear();
            }
        }

        private void backgroundBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                using (StreamReader reader = File.OpenText(openFileDialog.FileName))
                {
                    BackgroundImagePath = openFileDialog.FileName;
                    ImageBrush imageBrush = new ImageBrush();
                    Uri imageUri = new Uri(BackgroundImagePath, UriKind.Relative);
                    BitmapImage imageBitmap = new BitmapImage(imageUri);
                    imageBrush.ImageSource = imageBitmap;
                    MessageListBox.Background = imageBrush;
                }
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeUsernameTxtb.Text != "")
            {
                UsernameLbl.Content = ChangeUsernameTxtb.Text;
                ChangePPBtn.Visibility = Visibility.Hidden;
                ChangeUsernameBtn.Visibility = Visibility.Hidden;
                ChangeUsernameTxtb.Visibility = Visibility.Hidden;
                SaveBtn.Visibility = Visibility.Hidden;
            }
            else MessageBox.Show("Fill the area first!");
        }

        private void ChangeUsernameBtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeUsernameTxtb.IsEnabled = true;
        }

        private void ChangePPBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                using (StreamReader reader = File.OpenText(openFileDialog.FileName))
                {
                    ProfilePicturePath = openFileDialog.FileName;
                    ImageBrush imageBrush = new ImageBrush();
                    Uri imageUri = new Uri(ProfilePicturePath, UriKind.Relative);
                    BitmapImage imageBitmap = new BitmapImage(imageUri);
                    imageBrush.ImageSource = imageBitmap;
                    ImageBox.ImageSource = imageBrush.ImageSource;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ChangePPBtn.Visibility = Visibility.Visible;
            ChangeUsernameBtn.Visibility = Visibility.Visible;
            ChangeUsernameTxtb.Visibility = Visibility.Visible;
            SaveBtn.Visibility = Visibility.Visible;
            
        }
    }
}
