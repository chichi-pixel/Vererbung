using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vererbung
{
    class Post
    {
        private static int currentPostId;

        // Eigenschaften/Properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        // Default Konstruktor
        public Post()
        {
            ID = 0;
            Title = "Mein erster Post";
            IsPublic = true;
            SendByUserName = "Denis Panjuta";
        }

        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUsername;
        }

        // Virtual Methoden können von erbenden Klassen überschrieben werden
        public override string ToString()
        {
            return String.Format("{0} - {1} - von {2}", this.ID, this.Title, this.SendByUserName);
        }


        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

    }
}
