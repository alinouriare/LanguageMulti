using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LangMulti.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace LangMulti.Controllers
{
    public class NewsController : Controller
    {
        private readonly MyCMSContext _context;

        public NewsController(MyCMSContext context)
        {
            _context = context;
        }

        // GET: News
        public async Task<IActionResult> Index()
        {
            var myCMSContext = _context.Newses.Include(n => n.Language);
            return View(await myCMSContext.ToListAsync());
        }

        // GET: News/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.Newses
                .Include(n=>n.Language)
                .FirstOrDefaultAsync(m => m.News_Id == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // GET: News/Create
        public IActionResult Create()
        {
            ViewData["Lang_Id"] = new SelectList(_context.Languages, "Lang_Id", "LanguageTitle");
            return View();
        }

        // POST: News/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("News_Id,Lang_Id,Title,Description,ImageName,CreateDate")] News news,IFormFile imgNews)
        {
            if (ModelState.IsValid)
            {
                news.CreateDate = DateTime.Now;
                if (imgNews!=null)
                {
                    news.ImageName =Guid.NewGuid().ToString() + Path.GetExtension(imgNews.FileName);

                    string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/NewsImages", news.ImageName);

                    using (var stream=new FileStream(savePath,FileMode.Create))
                    {
                        imgNews.CopyTo(stream); 
                    }

                }
                _context.Add(news);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Lang_Id"] = new SelectList(_context.Languages, "Lang_Id", "LanguageTitle", news.Lang_Id);
            return View(news);
        }

        // GET: News/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.Newses.FindAsync(id);
            if (news == null)
            {
                return NotFound();
            }

            
                ViewData["Lang_Id"] = new SelectList(_context.Languages, "Lang_Id", "LanguageTitle", news.Lang_Id);
            return View(news);
        }

        // POST: News/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("News_Id,Lang_Id,Title,Description,ImageName,CreateDate")] News news)
        {
            if (id != news.News_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(news);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsExists(news.News_Id))
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
            ViewData["Lang_Id"] = new SelectList(_context.Languages, "Lang_Id", "LanguageTitle", news.Lang_Id);
            return View(news);
        }

        // GET: News/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.Newses
                .Include(n => n.Language)
                .FirstOrDefaultAsync(m => m.News_Id == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // POST: News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var news = await _context.Newses.FindAsync(id);
            _context.Newses.Remove(news);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsExists(int id)
        {
            return _context.Newses.Any(e => e.News_Id == id);
        }
    }
}
