using ListView_XamarinForms.Models;
using ListView_XamarinForms.ViewModels.Base;
using System.Collections.ObjectModel;

namespace ListView_XamarinForms.ViewModels
{
    public class DataBindingViewModel : ViewModelBase
    {
        public ObservableCollection<Monkey> Monkeys { get; set; }

        public DataBindingViewModel()
        {
            Monkeys = new ObservableCollection<Monkey>
            {
                new Monkey
                {
                    Name = "Baboon"
                },
                new Monkey
                {
                    Name = "Capuchin Monkey"
                },
                new Monkey
                {
                    Name = "Blue Monkey"
                },
                new Monkey
                {
                    Name = "Squirrel Monkey"
                },
                new Monkey
                {
                    Name = "Golden Lion Tamarin"
                },
                new Monkey
                {
                    Name = "Howler Monkey"
                },
                new Monkey
                {
                    Name = "Japanese Macaque"
                },
                new Monkey
                {
                    Name = "Mandrill"
                },
                new Monkey
                {
                    Name = "Proboscis Monkey"
                },
                new Monkey
                {
                    Name = "Spider Monkey"
                },
                new Monkey
                {
                    Name = "Saki Monkey"
                },
                new Monkey
                {
                    Name = "Emperor Tamarin"
                },
                new Monkey
                {
                    Name = "Spectacled Langur"
                },
                new Monkey
                {
                    Name = "Colobus Monkey"
                },
                new Monkey
                {
                    Name = "De Brazza's Monkey"
                },
                new Monkey
                {
                    Name = "Chimpanzee"
                }
            };
        }
    }
}