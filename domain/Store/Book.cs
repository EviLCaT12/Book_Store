﻿using System;
namespace Store;
//мать коли 
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }

    public Book(int id, string title)
    {
        Id = id;
        Title = title;
    }
}