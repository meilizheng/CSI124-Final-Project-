using FinalProjectClassLibrary;
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
using System.Windows.Shapes;

namespace CSI124_Final_Project_
{
    /// <summary>
    /// Interaction logic for Workout.xaml
    /// </summary>
    public partial class Workout : Window
    {
        List<Exercies> _exercise = new List<Exercies> ();
        public Workout()
        {
            InitializeComponent();
            Preload();
            lvExercises.ItemsSource = _exercise;

        }

        public void Preload()
        {
            _exercise.Add(new Exercies("Run", 1000));
            _exercise.Add(new Exercies("Weights", 400));
        }
    }
}
