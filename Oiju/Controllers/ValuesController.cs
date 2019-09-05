using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oiju.Models;

namespace Oiju.Controllers
{
    [Route("api/messages")]
    [ApiController]
    public class MessagesController : Controller
    {
        private MdbContext _context;

        public MessagesController(MdbContext a)
        {
            _context = a;
        }

        // GET api/messages
        [HttpGet]
        public JsonResult Get()
        {
            return Json(_context.Messages.ToList());
        }

        // GET api/messages/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return Json(_context.Messages.Find(id));
        }

        // POST api/messages
        [HttpPost]
        public void Post([FromBody] Message value)
        {
            _context.Messages.Add(value);
            _context.SaveChanges();
        }

        // PUT api/messages/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            Message m = _context.Messages.Find(id);
            m.message = value;
            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Message m = _context.Messages.Find(id);
            _context.Messages.Remove(m);
            _context.SaveChanges();
        }
    }
}
