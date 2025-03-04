using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp25
{
    internal class Person
    {

        private string name;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnNameChanged();
            }
        }


        public event EventHandler NameChanged;
        private void OnNameChanged()
        {
            if (NameChanged != null)
            {
                NameChanged(this, EventArgs.Empty);
            }
        }
    }
}
