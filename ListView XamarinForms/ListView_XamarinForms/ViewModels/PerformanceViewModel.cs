using ListView_XamarinForms.Models;
using ListView_XamarinForms.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ListView_XamarinForms.ViewModels
{
    public class PerformanceViewModel : ViewModelBase
    {
        private ObservableCollection<Monkey> _monkeys;
        private int _count;

        public PerformanceViewModel()
        {
            Monkeys = new ObservableCollection<Monkey>();

            _count = 1;
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Monkeys.Insert(0,
                    new Monkey
                    {
                        Name = string.Format("Monkey {0}", _count),
                        Location = Countries[random.Next(0, Countries.Count)],
                        Image = Images[random.Next(0, Images.Count)]
                    });
                _count++;
            }
        }

        public List<string> Countries
        {
            get
            {
                return new List<string>
                {
                    "Spain",
                    "EEUU",
                    "México",
                    "Peru",
                    "Brazil"
                };
            }
        }

        public List<string> Images
        {
            get
            {
                return new List<string>
                {
                    "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg",
                    "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                    "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg",
                    "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
                };
            }
        }

        public ObservableCollection<Monkey> Monkeys
        {
            get { return _monkeys; }
            set
            {
                _monkeys = value;
                RaisePropertyChanged();
            }
        }
    }
}