using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FamilyShoppingRestAPI.Models;

namespace FamilyShoppingRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        private shoppingdbContext db = new();

        [HttpGet]
        public List<Item> GetItems()
        {
            List<Item> items = db.Items.ToList();
            return items;
        }

        [HttpPost]
        public ActionResult AddItem([FromBody] Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
            return Ok("Added: " + item.ItemName + " " + item.Pieces + "pieces");
        }

        [HttpDelete("{id}")]
        public ActionResult removeItem(int id)
        {
            var item = db.Items.Find(id);
            db.Items.Remove(item);
            db.SaveChanges();
            return Ok("Deleted item with id " + id + ". " + "Named " + item.ItemName);
        }
    }
}
