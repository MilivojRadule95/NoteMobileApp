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
