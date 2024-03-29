﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using EdmanOnlineShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EdmanOnlineShop.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }
           
 
            [Required]
            [Display(Name = "Username")]
            public string UserName { get; set; }
            
            [Required]
            [Display(Name = "Mobile")]
            [RegularExpression(@"^[0][1-9]\d{9}$|^[1-9]\d{9}$", ErrorMessage = "Please enter a valid number")]
            public string Mobile { get; set; }
            
            [Range(0, Int32.MaxValue, ErrorMessage = "Must be a valid format")]
            [Display(Name = "Phone")]

            public int Phone { get; set; }

            [Required] [Display(Name = "Address")] public string Address { get; set; }
            [Required]
            [Display(Name = "Gender")]
            public ApplicationUser.Gender Gender { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var check = await _userManager.Users.SingleOrDefaultAsync(u => u.Email == Input.Email);
                if (check != null)
                {
                    ModelState.AddModelError(Input.Email, "Email is already taken");
                    return Page();
                }
                var user = new ApplicationUser { IsActive = true, UserGender = Input.Gender, UserName = Input.UserName, Email = Input.Email, FirstName = Input.FirstName, LastName = Input.LastName, Address = Input.Address, DateRegistered = DateTime.Now, Phone = Input.Phone, Mobile = Input.Mobile};
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);
                    
                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"<h4 style='font-size: 24px!important;'> Thank you for registering <i> {Input.FirstName } </i> </h4> <br> To continue shopping, please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'> clicking here </a>.");
                    
                    string Customer = "Customer";
                    await _userManager.AddToRoleAsync(user, Customer);


                    // await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
