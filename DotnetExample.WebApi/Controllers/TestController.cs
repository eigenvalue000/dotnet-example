using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DotnetExample.WebApi.Models;

namespace DotnetExample.WebApi.Controllers;
{
    [Route("api/Test")]
    [ApiController]
    [Produces("application/json")]
    public class TestController : ControllerBase
    {
        private readonly TestContext _context;
        public TestController(TestContext context){
            _context = context;
        }
        /// <summary>
        /// Posts a new TestItem.
        /// </summary>
        /// <param name="testItem"></param>
        /// <returns>A newly created TestItem</returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /TestItems
        ///     {
        ///         "id": 1,
        ///         "name": "Item 1"
        ///     }
        ///     
        /// </remarks>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TestItem>> PostTestItem(TestItem testItem){
            _context.TestItems.Add(testItem);
            await _context.SaveChangesAsync();
            Console.WriteLine("hi");
            
            return CreatedAtAction(nameof(GetTestItem), new { id = testItem.Id }, testItem);
        }
        // GET: api/TestItems/id
        [HttpGet("{id}")]
        public async Task<ActionResult<TestItem>> GetTestItem(long id){
            var testItem = await _context.TestItems.FindAsync(id);
            if (testItem == null) {
                return NotFound();
            }
            return testItem;
        }
        // GET: api/TestItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestItem>>> GetTestItems()
        {
            return await _context.TestItems.ToListAsync();
        }

        // PUT: api/Test/id
        // public async Task<IActionResult> PutTestItem(long id, TestItem testItem){
        //     if (id != testItem.Id){
        //         return BadRequest();
        //     }

        //     _context.Entry(testItem).State = EntityState.Modified;

        //     try {
        //         await _context.SaveChangesAsync();
        //     } catch (DbUpdateConcurrencyException) {
        //         if (testItem == null) {
        //             return NotFound();
        //         } else {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }
    }
}
