using AppRazorApplication.Data;
using AppRazorApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AppRazorApplication.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext db_context;
        public IEnumerable<Contact> contacts;

        public IndexModel(AppDbContext db_context)
        {
            this.db_context = db_context;
        }
        public async Task OnGet()
        {
          contacts = await db_context.contacts.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var c = await db_context.contacts.FindAsync(id);
            if (c == null)
            {
                return NotFound();
            }
            db_context.Remove(c);
            await db_context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
