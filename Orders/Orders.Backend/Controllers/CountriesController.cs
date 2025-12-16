using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orders.Backend.Data;
using Orders.Backend.UnitsOfWorks.Interfaces;
using Orders.Shared.Entities;

namespace Orders.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountriesController : GenericController<Country>
{
    public CountriesController(IGenericUnitOfWork<Country> unitOfWork) : base(unitOfWork)
    {
    }
}