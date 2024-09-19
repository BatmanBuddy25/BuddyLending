using BuddyLending.DatabaseContext;
using BuddyLendingShared.Model.Manpower;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BuddyLending.Controllers.MemberControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly DataBaseConfiguration _context;

        public MembersController(DataBaseConfiguration context)
        {
            _context = context;
        }

        // GET: api/Members
        [HttpGet("Getmasterlist")]
        public async Task<ActionResult<IEnumerable<MemberModel>>> GetMemberTable()
        {
            return await _context.MemberTable.ToListAsync();
        }

        // GET: api/Members/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MemberModel>> GetMemberModel(int id)
        {
            var memberModel = await _context.MemberTable.FindAsync(id);

            if (memberModel == null)
            {
                return NotFound();
            }

            return memberModel;
        }

        // PUT: api/Members/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMemberModel(int id, MemberModel memberModel)
        {
            if (id != memberModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(memberModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MemberModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Members
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("Postobj")]
        public async Task<ActionResult<MemberModel>> PostMemberModel(MemberModel memberModel)
        {
            _context.MemberTable.Add(memberModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMemberModel", new { id = memberModel.Id }, memberModel);
        }

        // DELETE: api/Members/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMemberModel(int id)
        {
            var memberModel = await _context.MemberTable.FindAsync(id);
            if (memberModel == null)
            {
                return NotFound();
            }

            _context.MemberTable.Remove(memberModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MemberModelExists(int id)
        {
            return _context.MemberTable.Any(e => e.Id == id);
        }
    }
}
