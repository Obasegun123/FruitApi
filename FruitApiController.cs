using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FruitApi.Model;

namespace FruitApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitApiController : ControllerBase
    {
         Fruit[] fruits = new Fruit[12]
        {
            new Fruit { Id = 1, Name = "Apple", Category = "Core"},
            new Fruit { Id = 2, Name = "Tangerine", Category = "Toys"},
            new Fruit { Id = 3, Name = "Peach", Category = "Pits"},
            new Fruit { Id = 4, Name = "Stawberry", Category = "Berry"},
            new Fruit { Id = 5, Name = "Watermelon", Category = "Melon"},
            new Fruit { Id = 6, Name = "Grape", Category = "Berry"},
            new Fruit { Id = 7, Name = "Lemon", Category = "Citrus"},
            new Fruit { Id = 8, Name = "Orange", Category = "Citrus"},
            new Fruit { Id = 9, Name = "Banana", Category = "Tropical"},
            new Fruit { Id = 10, Name = "Cucumber", Category = "Tropical"},
            new Fruit { Id = 11, Name = "Mango", Category = "Tropical"},
            new Fruit { Id = 12, Name = "Guava", Category = "Tropical"}
        };
        public IEnumerable<Fruit> Get()
        {
            return fruits;
        }

    [HttpGet("{id:int}")]
    public string GetById(int id)
    {
        return id.ToString();
    }

     [HttpGet("{Name}")]
     public string GetByName(string name)
    {
        return name ;
    }


    }
       
}