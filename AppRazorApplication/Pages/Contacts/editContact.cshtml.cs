using AppRazorApplication.Data;
using AppRazorApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AppRazorApplication.Pages.Contacts
{
    public class EditContactModel : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty]
        public Contact contact { get; set; }
        public EditContactModel(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            contact = await _context.contacts.FindAsync(id);

            if (contact == null)
            {
                return NotFound();
            }

            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.contacts.Update(contact);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
