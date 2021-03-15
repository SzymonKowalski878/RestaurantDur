using Microsoft.AspNetCore.Mvc;
using RestaurantDur.DataAccess.RepositoryInterfaces;
using RestaurantDur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDur.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TableController:Controller
    {
        private readonly Lazy<ITableRepository> _tableRepository;
        protected ITableRepository TableRepository => _tableRepository.Value;

        public TableController(Lazy<ITableRepository> tableRepository)
        {
            _tableRepository = tableRepository;
        }

        [HttpPost,Route("AddTable")]
        public IActionResult Post(Table data)
        {
            if (data == null)
            {
                return BadRequest("data was null");
            }

            TableRepository.Add(data);
            TableRepository.SaveChanges();

            return Ok("Git");

        }

        [HttpGet,Route("GetAll")]
        public IActionResult Get()
        {
            var data = TableRepository.GetAll();

            if (data == null)
            {
                return Ok("NO data in table table");
            }

            return Ok(data);
        }

        [HttpGet,Route("GetById")]
        public IActionResult Get(int id)
        {
            var data = TableRepository.GetById(id);

            if (data == null)
            {
                return BadRequest("No user with that id");
            }

            return Ok(data);
        }
    }
}
