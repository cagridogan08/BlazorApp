using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorGiris.Data
{
    public class UserModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string s)
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(s));
            }
        }
        private int  _id;
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(ID));
            }
        }
        [Required]
        [StringLength(10,ErrorMessage="Username Is Too Long!!")]
        private string? username;
        [Required]
        private string? password;
        [Required]
        private string? e_mail;
        public string Username
        {
            get { return username; }
            set { username = value; OnPropertyChanged("Username"); }
        }
        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged("Password"); }
        }
        public string E_mail
        {
            get { return e_mail; }
            set { e_mail = value;
            OnPropertyChanged(nameof (E_mail));}
        }
    }
}
