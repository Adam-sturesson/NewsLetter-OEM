using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewsLetter_OEM.data_access;
using NewsLetter_OEM.models;

namespace NewsLetter_OEM.Pages.Newsletter
{
    public class IndexModel : PageModel
    {
        private readonly INewsLetterRepository _newsLetterRepository;
        [BindProperty]
        public NewsLetter NewsLetter { get; set; }

        public string ErrorMessage { get; set; }
        
        public IndexModel(INewsLetterRepository newsLetterRepository)
        {
            _newsLetterRepository = newsLetterRepository;        
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                bool emailAlreadySignedUp = await _newsLetterRepository.IsAlreadyReceivingNewsLetters(NewsLetter.Email);
                if (!emailAlreadySignedUp)
                {
                    await _newsLetterRepository.RegisterForNewsLetter(NewsLetter);
                    return RedirectToPage("/nyhetsbrev/ny-prenumerant");
                }
                else
                {
                    ErrorMessage = "Den mailen är redan registrerad";
                    return Page();
                }
            }
            else
            {
                return Page();
            }
        }
    }
}
