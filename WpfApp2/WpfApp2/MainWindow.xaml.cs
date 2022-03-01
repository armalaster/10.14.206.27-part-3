using System;
using System.Collections.Generic;
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
using WpfApp2.db;
using System.Data.Entity;

namespace WpfApp2
{
  
    public partial class MainWindow : Window
    {
        public group363_09Entities connect = new group363_09Entities();
        public MainWindow()
        {
            InitializeComponent();
            BuilMaterials(0);
        }

        void BuilMaterials(int page)
        {
            var list = connect.Material.OrderBy(n => n.Name).ToList();
            People.Children.Clear();
            int pages = page * 3;
            for (int i = pages; i<pages + 3; i++)
            {
                Border border = new Border();
                border.Margin = new Thickness(20,10,20,10);
                border.BorderThickness = new Thickness(2);
                border.BorderBrush = Brushes.Black;

                StackPanel stack1 = new StackPanel();
                stack1.Orientation = Orientation.Horizontal;

                Image image = new Image();
                image.Width = 150;
                image.Height = 120;
                image.Margin = new Thickness(10);
                image.HorizontalAlignment = HorizontalAlignment.Left;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                if (list[i].Image == null)
                {
                    bitmap.UriSource = new Uri("/materials/picture.png", UriKind.Relative);
                }
                else
                {
                    bitmap.UriSource = new Uri(list[i].Image, UriKind.Relative);
                }
                bitmap.EndInit();
                image.Stretch = Stretch.UniformToFill;
                image.Source = bitmap;
                StackPanel stack2 = new StackPanel();
                stack2.Orientation = Orientation.Vertical;
                stack2.Width = 400;
                stack2.Margin = new Thickness(10);

                TextBlock  tbType = new TextBlock();
                tbType.Text = list[i].MaterialType.Name + " | " + list[i].Name;
                tbType.TextWrapping = TextWrapping.Wrap;
                tbType.FontSize = 20;

                TextBlock tbCount = new TextBlock();
                tbCount.Text = "Минимальное количество: " + list[i].MinCount + " " + list[i].Unit;
                tbCount.FontSize = 16;
                var providers = list[i].Provider.ToList();
                string a = "";
                foreach (var pr in providers)
                {
                    a += pr.Name + ", ";                
                }

                if (a.Length > 2)
                {
                    a = a.Substring(0, a.Length - 2);
                }
                TextBlock tbProvider = new TextBlock();
                tbProvider.Text = "Поставщики: " + a;
                tbProvider.TextWrapping = TextWrapping.Wrap;
                tbProvider.FontSize = 16;

                stack2.Children.Add(tbType);
                stack2.Children.Add(tbCount);
                stack2.Children.Add(tbProvider);

                Label label = new Label();
                label.HorizontalContentAlignment = HorizontalAlignment.Right;
                label.Width = 230;
                label.Margin = new Thickness(10);
                label.FontSize = 15;
                label.Content = "Остаток " + list[i].Count + " " + list[i].Unit;


                border.Child = stack1;
                stack1.Children.Add(image);
                stack1.Children.Add(stack2);
                stack1.Children.Add(label);
                People.Children.Add(border);
            }

            // =)
            int countPage = list.Count / 3;
            if (list.Count % 3 != 0)
            {
                countPage += 1;
            }
            BdPagination(countPage, page);
        }

        void BdPagination(int count, int activePage)
        {
            People1.Children.Clear();
            People1.Children.Add(createTextBlock("<", false));
            for (int i = count; i >0; i--)
            {
                People1.Children.Add(createTextBlock("" + i, i == activePage));
            }
            People1.Children.Add(createTextBlock(">", false));
        }

        private TextBlock createTextBlock(string text, bool underline)
        {
            TextBlock textBlock = new TextBlock();
            textBlock.FontSize = 12;
            textBlock.Text = text;
            textBlock.Margin = new Thickness(2, 5, 2, 5);
            if (underline == true)
            {
                textBlock.TextDecorations.Add(TextDecorations.Underline);
            }
            else 
            {
                textBlock.Cursor = Cursors.Hand;
                textBlock.MouseLeftButtonDown += onChangePage;
            }
            return textBlock;
        }
        private void onChangePage(object sender, MouseButtonEventArgs e)
        {
            var textBlock = sender as TextBlock;
            if (textBlock != null)
            {
                try
                {
                    int page = int.Parse(textBlock.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        
        }

       
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }      
    }
}
