using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public interface IGenresController
    {
        IActionResult Create();
        Task<IActionResult> Create(Genre genre);
        Task<IActionResult> Delete(int? id);
        Task<IActionResult> Index();
    }
}