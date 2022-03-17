using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNote.Models
{
    internal class Note
    {
        public string Title { get; }

        public string Description { get; }

        public Guid Id { get; }

        public Note(string title, string description)
        {
            Title = title;
            Description = description;

            if (string.IsNullOrEmpty(title))
            {
                throw new InvalidOperationException(nameof(title));
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new InvalidOperationException(nameof(description));
            }


        }

    }
}
