using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace AmilDiplom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AC ac;
        public MainWindow()
        {
            InitializeComponent();
            ac = new AC();
            updateNews();
            

        }

        public void updateNews() {
            ac = new AC();
            var r = ac.News.ToList();
            NewsList.ItemsSource = r;
        }
        public void updateanimal() {
            ac = new AC();
            var r = ac.Animals.ToList();
            AnimalList.ItemsSource = r;
           
        }
        public void updateDonate() {
            ac = new AC();
            var r = ac.Donates.ToList();
            DonateList.ItemsSource = r;
        }

        public void updateusers() {
            ac = new AC();
            var r = ac.Admins.ToList();
            AllusersList.ItemsSource = r;
        }

        private void NewsButton_Click(object sender, RoutedEventArgs e)
        {
            if (NewsList.Visibility == Visibility.Hidden)
            {
                MainText.Content = "Новости";
                AnimalList.Visibility = Visibility.Hidden;
                AboutGrid.Visibility = Visibility.Hidden;
                DonateGrid.Visibility = Visibility.Hidden;
                NewsList.Visibility = Visibility.Visible;
                updateNews();
            }
            else { 
                
            }

        }

        private void OurHisButton_Click(object sender, RoutedEventArgs e)
        {
            if (AnimalList.Visibility == Visibility.Hidden)
            {
                MainText.Content = "Наши животные";
                NewsList.Visibility = Visibility.Hidden;
                AboutGrid.Visibility = Visibility.Hidden;
                DonateGrid.Visibility = Visibility.Hidden;
                AnimalList.Visibility = Visibility.Visible;
                updateanimal();

            }
            else
            {

            }
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            if (AboutGrid.Visibility == Visibility.Hidden)
            {
                MainText.Content = "О нас";
                NewsList.Visibility = Visibility.Hidden;
                AnimalList.Visibility = Visibility.Hidden;
                DonateGrid.Visibility = Visibility.Hidden;
                AboutGrid.Visibility = Visibility.Visible;
                AboutText.Text = "Фонд помощи бездомным животным \"Счастливый друг\" был основан в 2010 году и стал одним из ведущих организаций, занимающихся спасением и защитой бездомных животных. Фонд \"Счастливый друг\" посвящен предоставлению безопасности, заботы и поиску новых домов для животных, оказавшихся в трудной жизненной ситуации.\r\n\r\nОсновная цель фонда заключается в снижении количества бездомных животных путем их спасения, медицинского ухода, стерилизации и усыновления. Организация стремится не только предоставить временный приют и лечение бездомным животным, но и поощрять ответственное владение питомцами и осознанное принятие решений о приобретении животных.\r\n\r\nФонд \"Счастливый друг\" активно сотрудничает с волонтерами, специалистами по защите животных и другими организациями, чтобы максимально расширить свою деятельность и достичь наилучших результатов в спасении и уходе за бездомными животными. Организация также проводит различные мероприятия и кампании для привлечения внимания общественности к проблеме бездомных животных и продвижению ответственного отношения к ним.\r\n\r\nЗа годы своей работы фонд \"Счастливый друг\" сумел спасти и обеспечить новый дом для сотен бездомных животных, помогая им преодолеть трудности и найти любящие семьи. Организация также активно работает над программами образования и информирования, направленными на пропаганду осознанного владения питомцами и борьбу с бездомностью животных.\r\n\r\nФонд \"Счастливый друг\" стремится к тому, чтобы каждое бездомное животное имело шанс на счастливую и безопасную жизнь, а каждый человек осознавал свою роль в защите и заботе о животных.";
                AboutText.Text += "\n\nТелефон: 8 (999) 123-12-12\nEmail: email@email.com";
            }
            else
            {

            }
        }

        private void PayButton_Click(object sender, RoutedEventArgs e)
        {
            if (DonateGrid.Visibility == Visibility.Hidden)
            {
                MainText.Content = "Помощь животным";
                NewsList.Visibility = Visibility.Hidden;
                AnimalList.Visibility = Visibility.Hidden;
                AboutGrid.Visibility = Visibility.Hidden;
                DonateGrid.Visibility = Visibility.Visible;
                updateDonate();
                DonateText.Text = "Пожертвование бездомным животным играет важную роль в обеспечении им помощи, заботы и возможности найти новый дом. Бездомные животные часто нуждаются в медицинском уходе, качественном питании, укрытии и других жизненно важных услугах. Пожертвования от добрых сердец помогают фондам и организациям, занимающимся помощью бездомным животным, предоставить им необходимую поддержку.\r\n\r\nПожертвования могут приниматься в различных формах, включая денежные средства, материальные ценности, услуги и время волонтеров. Денежные пожертвования позволяют фондам финансировать медицинские процедуры, стерилизацию, вакцинацию, содержание приютов, поиск новых домов для бездомных животных и проведение образовательных мероприятий. Они также помогают обеспечить корм и уход для бездомных животных, особенно в периоды кризиса или нехватки ресурсов.\r\n\r\nМатериальные пожертвования включают корм, одежду, подстилки, лекарства, медицинское оборудование и другие необходимые предметы. Они помогают обеспечить комфорт и заботу для бездомных животных в приютах, улучшить их условия содержания и обеспечить необходимые средства для их ухода.\r\n\r\nУслуги и время волонтеров также являются ценными формами пожертвования. Волонтеры могут помогать в уходе за животными, обучении, проведении мероприятий, административной работе и других задачах, что помогает фондам сократить расходы на персонал и эффективно использовать ресурсы.\r\n\r\nПожертвования бездомным животным имеют огромную значимость, так как они способствуют спасению и улучшению жизни многих животных. Они позволяют организациям продолжать свою работу, заботиться о бездомных животных, и делают возможным их возвращение в заботливые и любящие семьи. Каждое пожертвование является шагом к созданию лучшего мира для бездомных животных и проявлением сострадания и заботы к ним.";
            }
            else
            {

            }
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            if (AdminSignGrid.Visibility == Visibility.Hidden) { 
                AdminSignGrid.Visibility = Visibility.Visible;
                StatusLabel.Visibility = Visibility.Hidden;
            }
            else { 
                AdminSignGrid.Visibility = Visibility.Hidden;
                StatusLabel.Visibility = Visibility.Hidden;
            }
        }

        private void VhodButton_Click(object sender, RoutedEventArgs e)
        {
            var r = ac.Admins.Where(w => w.login == AdminLoginText.Text).FirstOrDefault();
            if (r != null)
            {
                if (AdminPassText.Password == r.password)
                {
                    YetButton.Visibility = Visibility.Visible;
                    YetButton.Content = r.login;
                    StatusLabel.Visibility = Visibility.Visible;
                    StatusLabel.Content = "Успешно";
                    StatusLabel.Foreground = Brushes.Green;
                    AdminLoginText.Clear();
                    AdminPassText.Clear();
                    Class1.log = r.login;
                }
                else
                {
                    StatusLabel.Visibility = Visibility.Visible;
                    StatusLabel.Content = "Ошибка";
                    StatusLabel.Foreground = Brushes.Red;
                    AdminLoginText.Clear();
                    AdminPassText.Clear();
                }
            }
            else { 
                StatusLabel.Visibility = Visibility.Visible;
                StatusLabel.Content = "Ошибка";
                StatusLabel.Foreground = Brushes.Red;
                AdminLoginText.Clear();
                AdminPassText.Clear();
            }
        }

        private void YetButton_Click(object sender, RoutedEventArgs e)
        {
            if (AdminGrid.Visibility == Visibility.Hidden)
            {
                AdminGrid.Visibility = Visibility.Visible;
            }
            else { 
                AdminGrid.Visibility= Visibility.Hidden;
            }
        }

        private void AddNewsButton_Click(object sender, RoutedEventArgs e)
        {
            Class1.Choose = 1;
            AddWindow add = new AddWindow();
            add.Show();
        }

        private void AddAnimalButton_Click(object sender, RoutedEventArgs e)
        {
            Class1.Choose = 2;
            AddWindow add = new AddWindow();
            add.Show();
        }

        private void ShowAllUsers_Click(object sender, RoutedEventArgs e)
        {
            if (AllUsersGrid.Visibility == Visibility.Visible)
            {
                AllUsersGrid.Visibility = Visibility.Hidden;
            }
            else {
                AllUsersGrid.Visibility = Visibility.Visible;
                updateusers();
            }

        }

        private void CloseUsersGrid_Click(object sender, RoutedEventArgs e)
        {
            AllUsersGrid.Visibility = Visibility.Hidden;
        }

        private void EditYourAccButton_Click(object sender, RoutedEventArgs e)
        {

            if (AdminEditGrid.Visibility == Visibility.Visible)
            {
                AdminEditGrid.Visibility = Visibility.Hidden;
            }
            else
            {
                AdminEditGrid.Visibility = Visibility.Visible;
                var r = ac.Admins.Where(w => w.login == Class1.log).FirstOrDefault();
                AdminLoginText2.Text = r.login;
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var r = ac.Admins.Where(w => w.login == Class1.log).FirstOrDefault();
                r.login = AdminLoginText2.Text;
                r.password = AdminPassText2.Password;
                ac.SaveChanges();
                AdminEditGrid.Visibility = Visibility.Hidden;
                YetButton.Visibility = Visibility.Visible;
                YetButton.Content = AdminLoginText2.Text;
            }
            catch {
                StatusLabel2.Visibility = Visibility.Visible;
                StatusLabel2.Content = "Ошибка!";
                StatusLabel2.Foreground = Brushes.Red;
            }
        }

        private void CloseEditGrid_Click(object sender, RoutedEventArgs e)
        {
            AdminEditGrid.Visibility = Visibility.Hidden;
        }

        private void PayDonateButton_Click(object sender, RoutedEventArgs e)
        {
            if (DonateGridInDonateGrid.Visibility == Visibility.Visible)
            {
                DonateGridInDonateGrid.Visibility = Visibility.Hidden;
            }
            else {
                DonateGridInDonateGrid.Visibility = Visibility.Visible;
                CurBox.Items.Add("рубли");
                CurBox.Items.Add("доллары");
                CurBox.Items.Add("евро");
            }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;
        }

        private void PayDonateButtonOnGrid_Click(object sender, RoutedEventArgs e)
        {
            Donate donate = new Donate()
            {
                name = NameText.Text,
                AmountDonate = Convert.ToInt32(SumText.Text),
                currency = CurBox.SelectedItem.ToString(),
                dateDonate = DateTime.Now.ToString(),
                comment = CommentText.Text,
            };
            ac.Donates.Add(donate);
            ac.SaveChanges();
            DonateGridInDonateGrid.Visibility = Visibility.Hidden;
            updateDonate();
        }

        private void EditAnimalButton_Loaded(object sender, RoutedEventArgs e)
        {
            var buttondel = (Button)sender;
            if (Class1.log == null)
            {

            }
            else
            {
                buttondel.Visibility = Visibility.Visible;
            }
        }

        private void DeleteAnimalButton_Loaded(object sender, RoutedEventArgs e)
        {
            var buttondel = (Button)sender;
            if (Class1.log == null)
            {

            }
            else
            {
                buttondel.Visibility = Visibility.Visible;
            }
        }

        private void EditAnimalButton_Click(object sender, RoutedEventArgs e)
        {
            var buttondel = (Button)sender;
            var an = (Animal)buttondel.DataContext;
            Class1.saveanimal = an.AnimalID;
            Class1.Choose = 2;
            AddWindow addWindow = new AddWindow();
            addWindow.Show();
            
        }

        private void DeleteAnimalButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Уверены что вы хотите удалить данные?", "Счастливый друг", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var buttondel = (Button)sender;
                var an = (Animal)buttondel.DataContext;
                ac.Animals.Remove(an);
                ac.SaveChanges();
                updateNews();
            }
            else { 
                
            }
        }

        private void DeleteNewsButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Уверены что вы хотите удалить данные?", "Счастливый друг", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var buttondel = (Button)sender;
                var ne = (New)buttondel.DataContext;
                ac.News.Remove(ne);
                ac.SaveChanges();
                updateanimal();
            }
            else
            {

            }
        }

        private void EditNewsButton_Click(object sender, RoutedEventArgs e)
        {
            var buttondel = (Button)sender;
            var ne = (New)buttondel.DataContext;
            Class1.savenew = ne.NewID;
            Class1.Choose = 1;
            AddWindow addWindow = new AddWindow();
            addWindow.Show();
        }

        private void EditNewsButton_Loaded(object sender, RoutedEventArgs e)
        {
            var buttondel = (Button)sender;
            if (Class1.log == null)
            {

            }
            else
            {
                buttondel.Visibility = Visibility.Visible;
            }
        }

        private void DeleteNewsButton_Loaded(object sender, RoutedEventArgs e)
        {
            var buttondel = (Button)sender;
            if (Class1.log == null)
            {

            }
            else
            {
                buttondel.Visibility = Visibility.Visible;
            }
        }
    }
}
