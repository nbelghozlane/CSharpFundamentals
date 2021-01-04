using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        private List<StreamingContent> _listOfContent = new List<StreamingContent>(); //<--- _listOfContent is a field
       
        //CRUD: Create, Read, Update, Delete
        //Create
        public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content);   // <-- field is _ camel case  ; properties is pascal case (example: ListOfContent)
        }

        //Read
        public List<StreamingContent> GetContentList()
        {
            return _listOfContent;
        }

        //Update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            //Find the content
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            //Update the content
            if(oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool RemoveContentFromList(string title)
        {
            StreamingContent content = GetContentByTitle(title);

            if(content == null)
            {
                return false;
            }

            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if(initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper method (or ReadByTitle or GetByTitle) - helps other methods
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _listOfContent)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }

            return null;   // if I don't find that object, return null
        }
    }
}
