using SimpleNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleNote.DataAccess
{
    internal class NotesRepository
    {
        private List<Note> _notes = new List<Note>();

        public NotesRepository()
        {
            _notes.Add(new Note("Lala ding dong", "Pesma  Vampira izasla 1982 blabalbla"));
            _notes.Add(new Note("wfergrtgret", "fwfweferferf fwefwfwef fwefwef"));
        }

        public void AddNote(Note note)
        {
            _notes.Add(note);
        }

        public void DeleteNote(Guid id)
        {
            _notes = _notes.Where(note => note.Id != id).ToList();
        }

        public IEnumerable<Note> GetAllNotes()
        {
            return new List<Note>();
        }
    }
}
