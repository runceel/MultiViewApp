using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiWindowApp
{
    class Counter : INotifyPropertyChanged
    {
        public static Counter Instance { get; } = new Counter();

        public event PropertyChangedEventHandler PropertyChanged;

        private static readonly PropertyChangedEventArgs CountPropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(Count));

        private int count;

        public int Count
        {
            get { return this.count; }
            set
            {
                if (this.count == value) { return; }
                this.count = value;
                this.PropertyChanged?.Invoke(this, CountPropertyChangedEventArgs);
            }
        }

    }
}
