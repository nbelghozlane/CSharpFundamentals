using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public enum GenreType
    {
        Horror = 1,
        RomCom,
        SciFi,
        Documentary,
        Bromance,
        Drama,
        Action
    }
    //Plain Old C# Object -- POCO
    public class StreamingContent
    {
        public string Title { get; set; }    //properties - prop tab tab    Properties (Title, Description, StarRating, etc) can go into the next method below. 
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public double StarRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenreType TypeOfGenre { get; set; }

        public StreamingContent() { }

        public StreamingContent(string title, string description, string maturityRating, double starRating, bool isFamilyFriendly, GenreType genre)    //<-- write ctor tab tab - code snippet
        {
            Title = title;                  
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            IsFamilyFriendly = isFamilyFriendly;
            TypeOfGenre = genre;
              
            //But, can't take these properties (title, description, maturityRating, etc.) out and use in method above.
        }

    }
}
