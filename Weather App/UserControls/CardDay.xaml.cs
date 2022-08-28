﻿using System;
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

namespace Weather_App.UserControls
{
    /// <summary>
    /// CardDay.xaml 的交互逻辑
    /// </summary>
    public partial class CardDay : UserControl
    {
        public CardDay()
        {
            InitializeComponent();
        }

        public string Day
        {
            get { return (string)GetValue(DayProperty); }
            set { SetValue(DayProperty, value); }
        }

        public static readonly DependencyProperty DayProperty = DependencyProperty.Register("Day", typeof(string), typeof(CardDay));


        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(CardDay));


        public string MaxNum
        {
            get { return (string)GetValue(MaxNumProperty); }
            set { SetValue(MaxNumProperty, value); }
        }

        public static readonly DependencyProperty MaxNumProperty = DependencyProperty.Register("MaxNum", typeof(string), typeof(CardDay));


        public string MinNum
        {
            get { return (string)GetValue(MinNumProperty); }
            set { SetValue(MinNumProperty, value); }
        }

        public static readonly DependencyProperty MinNumProperty = DependencyProperty.Register("MinNum", typeof(string), typeof(CardDay));



    }
}
