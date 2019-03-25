using Android.Widget;
using ListView_XamarinForms.Models;
using ListView_XamarinForms.ViewModels.Base;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListView_XamarinForms.ViewModels
{
    public class CustomCellViewModel : ViewModelBase
    {
        //ConnectionClass cd = new ConnectionClass();
        public ObservableCollection<Monkey> Monkeys { get; set; }
        ICommand _tapCommand;

        public ICommand TapCommand
        {
            get { return _tapCommand = _tapCommand ?? new DelegateCommand(TapCommandExecute); }
        }

        private void TapCommandExecute()
        {
            Toast.MakeText(Android.App.Application.Context, "Hola", ToastLength.Long).Show();
            //_navigationService.NavigateTo<BasicViewModel>();
        }


        public CustomCellViewModel()
        {
            Monkeys = new ObservableCollection<Monkey>
            {
                new Monkey
                {
                    Name = "Flash",
                    Location = "Supervelocidad",
                    Details =
                        "La historia se basa en el superhéroe de DC Comics, Flash, específicamente en Barry Allen, el segundo individuo en tomar dicha identidad. Se trata además de un spin-off de Arrow, serie de televisión basada en Flecha Verde, por lo cual comparten el mismo universo de ficción",
                    Image =
                        "https://www.technobuffalo.com/wp-content/uploads/2016/06/The-Flash-200x200.jpg"
                },
                new Monkey
                {
                    Name = "Superman",
                    Location = "OP",
                    Details =
                        "Superman (cuyo nombre kryptoniano es Kal-El y su nombre terrestre es Clark Kent) es un personaje ficticio, un superhéroe de los cómics que aparece en las publicaciones de DC Comics",
                    Image =
                        "https://screenanarchy.com/assets_c/2017/05/superman-the-movie-1978-photo-01-630-thumb-860xauto-39193-thumb-200x200-66859.jpg"
                },
                new Monkey
                {
                    Name = "Batman",
                    Location = "Es rico",
                    Details =
                        "Batman (conocido inicialmente como The Bat-Man) es un personaje creado por los estadounidenses Bob Kane y Bill Finger,4​ y propiedad de DC Comics",
                    Image =
                        "https://www.technobuffalo.com/wp-content/uploads/2015/04/batman-suit-002-200x200.jpg"
                },
                new Monkey
                {
                    Name = "Wonder Woman",
                    Location = "Super vuelo, súper fuerza, inmortalidad, factor de curación, super velocidad, reflejos, resistencia, brazaletes que repelen cualquier tipo de arma, habilidad de lucha altamente desarrollada y posee un lazo mágico",
                    Details =
                        "La Mujer Maravilla (en inglés: Wonder Woman) es una superheroína ficticia creada por William Moulton Marston para la editorial DC Comics",
                    Image =
                        "https://todatecnologia.com/wp-content/uploads/2016/07/Wonder-Woman-200x200.jpg"
                },
                new Monkey
                {
                    Name = "Linterna Verde",
                    Location = "Uso de la luz para crear objetos",
                    Details =
                        "Linterna Verde (en inglés: Green Lantern) es el alias de varios superhéroes de la ficción del Universo DC",
                    Image =
                        "https://images-eu.ssl-images-amazon.com/images/I/412X7C8-G+L._AC_US200_.jpg"
                },
                new Monkey
                {
                    Name = "Aquaman",
                    Location = "Dominio del agua",
                    Details =
                        "Aquaman (cuyo verdadero nombre es Arthur Curry) es un superhéroe que aparece en los cómics estadounidenses publicados por DC Comics",
                    Image =
                        "https://todatecnologia.com/wp-content/uploads/2017/03/Jason-Momoa-como-Aquaman-200x200.jpg"
                },
                new Monkey
                {
                    Name = "Arrow",
                    Location = "Entrenado por la liga de asesinos",
                    Details =
                        "Green Arrow es un superhéroe ficticio que aparece en los cómics publicados por DC Comics. Creado por Mort Weisinger y diseñado por George Papp, apareció por primera vez en More Fun Comics #73 en noviembre de 1941",
                    Image =
                        "https://static.vix.com/es/sites/default/files/styles/thumbnail/public/btg/series.batanga.com/files/arrow-the-flash-crossover-adelantos-3.jpg?itok=C0aq8Stk"
                },
                new Monkey
                {
                    Name = "Hombre Halcón",
                    Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
                    Details =
                        "Hombre Halcón es el nombre de varios superhéroes alienígenas de DC Comics que comparten características comunes como el uso de armas antiguas y de alas artificiales. De estos personajes hay dos que se destacan sobre los demás, Carter Hall y Katar Hol",
                    Image =
                        "https://www.dhresource.com/200x200s/f2-albu-g5-M01-99-30-rBVaJFlow_KAGIAEAADI8wgqXWw975.jpg/camisa-de-hombre-gemelos-cabuj-n-de-cristal.jpg"
                },
                new Monkey
                {
                    Name = "Detective Marciano",
                    Location = "Borneo",
                    Details =
                        "El Martian Manhunter (J'onn J'onzz) es un superhéroe de la compañía estadounidense DC Comics.",
                    Image =
                        "https://images-eu.ssl-images-amazon.com/images/I/41H85MnNZeL._AC_US200_.jpg"
                },
                new Monkey
                {
                    Name = "Firestorm",
                    Location = "Central and South America",
                    Details =
                        "Spider monkeys of the genus Ateles are New World monkeys in the subfamily Atelinae, family Atelidae. Like other atelines, they are found in tropical forests of Central and South America, from southern Mexico to Brazil.",
                    Image = "https://i.pinimg.com/236x/45/33/26/453326659bf96b8b3cdd62a577aa4816--injustice--list-of-characters.jpg"
                }                
            };
        }
    }
}
