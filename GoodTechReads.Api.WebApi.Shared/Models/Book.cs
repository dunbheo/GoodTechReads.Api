using System;

namespace GoodTechReads.Api.WebApi.Shared.Models
{
  public class Book
  {
    public int BookId { get; set; }
    public string Title { get; set; }
    public DateTime PublicationDate { get; set; }
    public Author[] Authors { get; set; }
  }
}
