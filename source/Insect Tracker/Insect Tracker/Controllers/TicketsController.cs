using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Insect_Tracker.Data;
using Insect_Tracker.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.IO;
using Insect_Tracker.Configuration;

namespace Insect_Tracker.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public TicketsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Tickets
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ticket.ToListAsync());
        }

        // GET: Tickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket
                .Where(t => t.Id == id)
                .Include(t => t.Comments)
                .ThenInclude(c => c.Attachments)
                .Include(t => t.Author)
                .FirstOrDefaultAsync();


            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Tickets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Description")] TicketInputModel input)
        {
            if (ModelState.IsValid)
            {
                Ticket ticket = new Ticket();
                Comment comment = new Comment();

                ticket.Closed = false;
                ticket.DateReported = DateTime.UtcNow;
                ticket.LastModified = DateTime.UtcNow;
                ticket.Author = _userManager.GetUserAsync(User).Result;
                ticket.Title = input.Title;
                ticket.Comments = new List<Comment>();
                comment.Message = input.Description;
                comment.Author = ticket.Author;
                comment.DateSent = ticket.DateReported;

                if (Request.Form.Files.Count > 0)
                {
                    IFormFileCollection files = Request.Form.Files;

                    foreach (var formFile in files)
                    {
                        var rand = new Random();

                        Attachment fileAttachment = new Attachment();

                        string FileName = formFile.FileName;
                        string File = rand.Next(0, 10000).ToString() + "_" + formFile.FileName;

                        DirectoryInfo info = new DirectoryInfo(Directories.ATTACHMENTS);

                        if (!info.Exists)
                        {
                            info.Create();
                        }

                        string path = Path.Combine(Directories.ATTACHMENTS, File);

                        using (FileStream outputFileStream = new FileStream(path, FileMode.Create))
                        {
                            await formFile.CopyToAsync(outputFileStream);
                        }

                        fileAttachment.Comment = comment;

                        fileAttachment.FileName = FileName;
                        fileAttachment.File = File;

                        _context.Add(fileAttachment);

                        comment.Attachments.Add(fileAttachment);
                    }
                }

                ticket.Comments.Add(comment);

                _context.Add(comment);
                _context.Add(ticket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(input);
        }

        // GET: Tickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Closed,DateReported,DateClosed,LastModified")] Ticket ticket)
        {
            if (id != ticket.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ticket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(ticket.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ticket);
        }

        // GET: Tickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticket = await _context.Ticket
                .Where(t => t.Id == id)
                .Include(t => t.Comments)
                .ThenInclude(t => t.Attachments)
                .Include(t => t.Author)
                .FirstOrDefaultAsync();
            _context.Ticket.Remove(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(int id)
        {
            return _context.Ticket.Any(e => e.Id == id);
        }
    }
}
