using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvM_Notes.Models;

namespace MvvM_Notes.ViewModels
{
    public class NoteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        NotesListViewModel lvm;

        public Note Note { get; private set; }

        public NoteViewModel()
        {
            Note = new Note();
        }

        public NotesListViewModel ListViewModel
        {
            get { return lvm; }
            set
            {
                if (lvm != value)
                {
                    lvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }
        public string Head
        {
            get { return Note.Head; }
            set
            {
                if (Note.Head != value)
                {
                    Note.Head = value;
                    OnPropertyChanged("Head");
                }
            }
        }
        public string Text
        {
            get { return Note.Text; }
            set
            {
                if (Note.Text != value)
                {
                    Note.Text = value;
                    OnPropertyChanged("Text");
                }
            }
        }
       
        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Head.Trim())) ||
                    (!string.IsNullOrEmpty(Text.Trim())));
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
