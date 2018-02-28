using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Authentification.ViewModel
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt; //pour afficher boite de dialogue


        public event PropertyChangedEventHandler PropertyChanged;

        //utilisée au lieu de
        //    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //    {   PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }




        //premier paramètre récuperé de UI
        private String login;
        public String Login //paramètre de Binding au niveau du view
        {
            get { return login; }
            set
            {
                login = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Login"));
            }
        }

        //deuxième paramètre récuperé de UI
        private String password;
        public String Password    //paramètre de Binding au niveau du view
        {
            get { return password; }
            set
            {
                password = value; //récuperer la valeur de champ
                PropertyChanged(this, new PropertyChangedEventArgs("Password")); //refraichir le champ automatiquement
            }
        }
        public ICommand SubmitCommand
        { protected set; get; }


        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
            if (login != "m.elleuch@root.sa" || password != "admin")
            {
                DisplayInvalidLoginPrompt();
            }
        }
    }
}
