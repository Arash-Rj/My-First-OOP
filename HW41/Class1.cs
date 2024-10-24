using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Book
{
    public string Feild { get; set; }
    private string ID;
    public string Id
    { 
        get
        {
             string id = "Num";
            for (int i = 0; i < Title.Length; i++)
            {
                id += Convert.ToInt32(Title[i]).ToString();
            }
            ID = id;
            return ID;
        }
        
        set
        {}
       
    }
    public string Title { get; set; }
    public string Author { get; set; }
    public int yearpublished { get; set; }
    public string Edition {  get; set; }
    public int pages {  get; set; }

    private int Price; 
    public int price
    {
        get 
        {
            Price = pages * 1000 + 100000;
             return Price;  
        }
        set
        { }
    }
    
    public Book(string feild,string author,string title,int Yearpublished,string edition,int Pages)
    {
        Feild = feild;
        Title = title;
        yearpublished = Yearpublished;
        Edition = edition;
        pages = Pages;
        Author = author.ToUpper();
    }
    public int priceincrease(int x)
    {
        Price += x;
        return Price;
    }
    public void changeEdition(string newEdition)
    {
        Edition = newEdition;
    }
    public void changepages(int newamount)
    {
        pages = newamount;
    }
    //public string titlebyauthor(string Author1)
    //{
    //    string A = Author1.ToUpper();
    //    if( Author == A)
    //    {
    //        return Title;
    //    }
    //    return "";
    //}
    public string getbookinfo()
    {
      string Info ="";
        Info += $" Title: {Title},    " +
            $"Author: {Author},    " +
            $"Edition: {Edition},    " +
            $"PublishedYear: {yearpublished},    " +
            $"Number of Pages: {pages}";
        return Info;
    }
  



}