using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.CSharp.RuntimeBinder;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace AmilDiplom
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        AC ac;
        string path;
        
        public AddWindow()
        {
            InitializeComponent();
            ac = new AC();
            if (Class1.Choose == 1) { 
                AddNewsGrid.Visibility = Visibility.Visible;
                AddAnimalGrid.Visibility = Visibility.Hidden;
                Class1.Choose = 0;
            }
            else if(Class1.Choose == 2)
            {
                AddAnimalGrid.Visibility = Visibility.Visible;
                AddNewsGrid.Visibility = Visibility.Hidden;
                Class1.Choose = 0;
            }
        }

        private void AddPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            path = openFileDialog.FileName;
        }

        private void AddNewsButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (Class1.savenew == 0)
                {
                    string fromad;
                    if (FromAdText.Text == null)
                    {
                        fromad = "";
                    }
                    else
                    {
                        fromad = FromAdText.Text;
                    }
                    New neww = new New()
                    {
                        title = TitleText.Text,
                        datePost = DateTime.Now.ToString(),
                        mainText = MainText.Text,
                        pathImage = path,
                        fromAdmins = fromad,
                    };
                    ac.News.Add(neww);
                    ac.SaveChanges();
                    this.Close();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.updateNews();
                }
                else
                {
                    string fromad;
                    if (FromAdText.Text == null)
                    {
                        fromad = "";
                    }
                    else
                    {
                        fromad = FromAdText.Text;
                    }
                    var r = ac.News.Where(c => c.NewID == Class1.savenew).FirstOrDefault();
                    if (r != null)
                    {
                        r.title = TitleText.Text;
                        r.mainText = MainText.Text;
                        r.pathImage = path;
                        r.fromAdmins = fromad;
                        ac.SaveChanges();
                        this.Close();
                    }
                }
            }
            catch { 
                
            }
        }

        private void AddAnimalButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Class1.saveanimal == 0)
                {

                    Animal animal = new Animal()
                    {
                        name = NameText.Text,
                        history = HistoryText.Text,
                        pathImage = path,
                    };
                    ac.Animals.Add(animal);
                    ac.SaveChanges();
                    this.Close();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.updateNews();
                }
                else { 
                    var r = ac.Animals.Where(c => c.AnimalID == Class1.saveanimal).FirstOrDefault();
                    if (r != null)
                    {
                        r.name = NameText.Text;
                        r.history = HistoryText.Text;
                        r.pathImage = path;
                        ac.SaveChanges();
                        this.Close();
                    }
                }
            }
            catch
            {

            }
        }

        private void AddPhotoAnimalButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            path = openFileDialog.FileName;
        }
    }
}
