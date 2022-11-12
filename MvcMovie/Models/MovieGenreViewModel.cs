using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
    public string? Sort { get; set;  }
    //public bool Sort
    //{
    //    set
    //    {
    //        if (value)
    //        {
    //            Movies.OrderByDescending(m => m.ReleaseDate);
    //            _set = true;
    //        }
                
    //        else
    //        {
    //            Movies.OrderBy(m => m.Title);
    //            _set = false;
    //        }
                
    //    }

    //    get
    //    {
    //        return _set;
    //    }

    //}

    //private bool _set = false;

    public static string[] options = {

    "Scary"
};

}

