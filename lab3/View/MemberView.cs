using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace lab3.View
{
    public class MemberView
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string fullName;
        public string FullName
        {
            get { return fullName; }
            set
            {
                fullName = value;
                OnPropertyChanged("FullName");
            }
        }



        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
