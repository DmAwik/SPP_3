using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace lab3.View
{
    public class NamespaceView : INotifyPropertyChanged
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

        private List<ClassView> classes;
        public List<ClassView> Classes
        {
            get { return classes; }
            set
            {
                classes = value;
                OnPropertyChanged("Classes");
            }
        }

      

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
