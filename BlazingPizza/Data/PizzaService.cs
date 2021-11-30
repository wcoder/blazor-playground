using System;
using System.Threading.Tasks;

namespace BlazingPizza.Data
{
 public class PizzaService
 {
  public Task<Pizza[]> GetPizzasAsync()
  {
   return Task.FromResult<Pizza[]>(null);
  }
 }
}