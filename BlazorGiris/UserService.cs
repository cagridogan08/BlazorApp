using BlazorGiris.Data;
using System.Collections.ObjectModel;

namespace BlazorGiris
{
    public class UserService
    {

        /// DataContext için service yazımı?????

        /// <summary>
        /// 
        /// </summary>
        public ObservableCollection<UserModel> _users = new ObservableCollection<UserModel>();

        public void AddUser(UserModel _user)
        {
            _users.Add(_user);
        }
        public UserModel GetUserByID(int _id)
        {
            return _users.FirstOrDefault(e => e.ID == _id);
        }
        public void DeleteUserByID(int _id)
        {
            var item = _users.FirstOrDefault(e => e.ID == _id);
            if (item != null)
            {
                _users.Remove(item);
            }
        }
    }
}
