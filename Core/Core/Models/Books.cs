using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class Books
    {
        public int No{ get; set; }
        public string Name {  get; set; }
        public string AuthorName {  get; set; }
        public int PageCount {  get; set; }
        public Books(int no, string name, string authorName, int pageCount)
        {
            No = no;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }
    }
}
