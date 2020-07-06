using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_mvvm_data_binding.Models;

namespace wpf_mvvm_data_binding.ViewModel
{
    class ChansonViewModel : INotifyPropertyChanged
    {
        private Chanson _model;

        public ChansonViewModel()
        {
            _model = new Chanson { Name = "Song", Gender = "PoP" };
        }

        public string ChansonName
        {
            get { return _model.Name; }
            set
            {
                _model.Name = value;
                OnPropertyChanged("ChansonName");
            }
        }

        public string ChansonGender
        {
            get { return _model.Gender; }
            set
            {
                _model.Gender = value;
                OnPropertyChanged("ChansonGender");
            }
        }

        //Event binds view to ViewModel.
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, e);
            }
        }

    }
}