using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagHelpers.Models;

namespace TagHelpers.Data
{
    public static class Datasource
    {
        public static List<BookModel> Books;
        static Datasource()
        {
            Books = new List<BookModel>()
            {
                new BookModel {Id=1, Name="Book 1", Description="Description 1"},
                new BookModel {Id=2, Name="Book 2", Description="Description 2"},
                new BookModel {Id=3, Name="Book 3", Description="Description 3"},
                new BookModel {Id=4, Name="Book 4", Description="Description 4"},
            };
        }
    }
}
