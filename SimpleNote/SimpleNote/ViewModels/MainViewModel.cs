using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleNote.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private ObservableCollection<NoteViewModel> _notesSource;

        private ObservableCollection<NoteViewModel> NotesSource
        {
            get { return _notesSource; }
            set 
            { 
                _notesSource = value;
                OnPropertyChanged(nameof(NotesSource));
            }
        }
        public ICommand AddNoteCommand { get; }
       

        public MainViewModel()
        {
            AddNoteCommand = new Command(OnAddNoteCommand);
        }

        private void OnAddNoteCommand(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
