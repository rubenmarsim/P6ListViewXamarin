using ListView_XamarinForms.Models;
using ListView_XamarinForms.ViewModels.Base;
using System.Collections.ObjectModel;

namespace ListView_XamarinForms.ViewModels
{
    public class TextCellViewModel : ViewModelBase
    {
        public ObservableCollection<Monkey> Monkeys { get; set; }

        public TextCellViewModel()
        {
            Monkeys = new ObservableCollection<Monkey>
            {
                new Monkey
                {
                    Name = "Baboon",
                    Location = "Africa & Asia"
                },
                new Monkey
                {
                    Name = "Capuchin Monkey",
                    Location = "Central & South America"
                },
                new Monkey
                {
                    Name = "Blue Monkey",
                    Location = "Central and East Africa"
                },
                new Monkey
                {
                    Name = "Squirrel Monkey",
                    Location = "Central & South America"
                },
                new Monkey
                {
                    Name = "Golden Lion Tamarin",
                    Location = "Brazil"
                },
                new Monkey
                {
                    Name = "Howler Monkey",
                    Location = "South America"
                },
                new Monkey
                {
                    Name = "Japanese Macaque",
                    Location = "Japan"
                },
                new Monkey
                {
                    Name = "Mandrill",
                    Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo"
                },
                new Monkey
                {
                    Name = "Proboscis Monkey",
                    Location = "Borneo"
                },
                new Monkey
                {
                    Name = "Spider Monkey",
                    Location = "Central and South America"
                },
                new Monkey
                {
                    Name = "Saki Monkey",
                    Location = "South America"
                },
                new Monkey
                {
                    Name = "Emperor Tamarin",
                    Location = "Amazon Basin"
                },
                new Monkey
                {
                    Name = "Spectacled Langur",
                    Location = "Malaysia"
                },
                new Monkey
                {
                    Name = "Colobus Monkey",
                    Location = "Africa"
                },
                new Monkey
                {
                    Name = "De Brazza's Monkey",
                    Location = "Africa"
                },
                new Monkey
                {
                    Name = "Chimpanzee",
                    Location = "West and Central Africa"
                }
            };
        }
    }
}
