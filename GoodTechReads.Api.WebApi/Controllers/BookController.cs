using GoodTechReads.Api.WebApi.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GoodTechReads.Api.WebApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BookController : ControllerBase
  {
    [HttpGet]
    public IActionResult Get()
    {
      var books = new Book[]
      {
        new Book
        {
          BookId = 1,
          Title = "Book 1",
          PublicationDate = DateTime.Now,
          Authors = Array.Empty<Author>()
        },
        new Book
        {
          BookId = 1,
          Title = "Book 1",
          PublicationDate = DateTime.Now,
          Authors = Array.Empty<Author>()
        },
        new Book
        {
          BookId = 1,
          Title = "Book 1",
          PublicationDate = DateTime.Now,
          Authors = Array.Empty<Author>()
        }
      };
      return Ok(books);
    }
  }
}