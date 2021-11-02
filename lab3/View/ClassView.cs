using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace lab3.View
{
    public class ClassView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private List<MemberView> members;
        public List<MemberView> Members
        {
            get { return members; }
            set
            {
                members = value;
                OnPropertyChanged("Members");
            }
        }


        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
