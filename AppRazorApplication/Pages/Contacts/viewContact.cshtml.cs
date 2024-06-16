using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppRazorApplication.Models;
using AppRazorApplication.Data;

namespace AppRazorApplication.Pages.Contacts
{
    public class ContactDetailsModel : PageModel
    {
        private readonly AppDbContext _context;

        public ContactDetailsModel(AppDbContext context)
        {
            _context = context;
        }

        public Contact Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            Contact = await _context.contacts.FindAsync(id);

            if (Contact == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
