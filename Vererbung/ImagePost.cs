using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vererbung
{
    // ImagePost erbt von Post und fügt eine Eigenschaft (ImageURL) und zwei Konstruktoren hinzu


    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.IsPublic = isPublic;

            // Eigenschaft ImageURL welche ein Member der ImagePost Klasse ist. Jedoch nicht von Post.
            this.ImageURL = imageURL;
        }

        // Virtual Methoden können von erbenden Klassen überschrieben werden
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - von {3}", this.ID, this.ImageURL, this.Title, this.SendByUserName);
        }
    }
}
