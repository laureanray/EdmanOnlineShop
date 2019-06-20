using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdmanOnlineShop.Data;
using EdmanOnlineShop.Models;
using EdmanOnlineShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace EdmanOnlineShop.Controllers
{
    public class FeedbacksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public FeedbacksController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize(Roles = "Customer")]

        public async Task<IActionResult> Index()
        {
            FeedBackViewModel vm = new FeedBackViewModel();
            vm.Messages = new List<MessageDetails>();
            vm.ArchivedMessages = new List<MessageDetails>();
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (user != null)
            {
                var userId = user.Id;
                var messages = await _context.Messages.Where(m => m.ToUserID == userId && m.IsArchived == false).ToListAsync();
                var archivedMessages = await _context.Messages.Where(m => m.ToUserID == userId && m.IsArchived == true).ToListAsync();
                if (messages != null)
                {
                    foreach (var message in messages)
                    {
                        var fromUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == message.FromUserID);
                        var toUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == message.ToUserID);

                        var messageDetails = new MessageDetails
                        {
                            FromUserID = message.FromUserID,
                            FromUser = fromUser,
                            ToUserID = message.ToUserID,
                            ToUser = toUser,
                            MessageContent = message.MessageContent,
                            MessageID = message.MessageID,
                            DateCreated = message.DateCreated
                        };
                        
                        vm.Messages.Add(messageDetails);
                    }

                    vm.UserID = userId;

                }
                if (archivedMessages != null)
                {
                    foreach (var aMessage in archivedMessages)
                    {
                        var fromUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == aMessage.FromUserID);
                        var toUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == aMessage.ToUserID);

                        var messageDetails = new MessageDetails
                        {
                            FromUserID = aMessage.FromUserID,
                            FromUser = fromUser,
                            ToUserID = aMessage.ToUserID,
                            ToUser = toUser,
                            MessageContent = aMessage.MessageContent,
                            MessageID = aMessage.MessageID,
                            DateCreated = aMessage.DateCreated
                        };
                        
                        vm.ArchivedMessages.Add(messageDetails);
                    }

                    vm.UserID = userId;

                }

                var x = vm.ArchivedMessages.Count;
                var y = vm.Messages.Count;
                
                return View(vm);
            }

            return View();
        }

        public IActionResult WriteFeedback(int productId)
        {
            var model = new WriteFeedbackViewModel();

            model.ProductID = productId;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> WriteFeedback(WriteFeedbackViewModel model)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            
                var feedback = new Feedback
                {
                    FeedbackMessage = model.FeedbackMessage,
                    UserID = user.Id,
                    DateCreated = DateTime.Now,
                    IsArchived = false,
                    Rating = model.Rating,
                    ProductID = model.ProductID
                };

                _context.Feedbacks.Add(feedback);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Success));
            

        }
        
        [Authorize(Roles = "Admin, SalesClerk, OperationsManager")]
        public async Task<IActionResult> FeedbacksTable()
        {
            var feedbacks = await _context.Feedbacks.Where(f => f.IsArchived == false).ToListAsync();
            FeedbackTableViewModel vm = new FeedbackTableViewModel();
            vm.Feedbacks = new List<FeedbackDetails>();

            if (feedbacks != null)
            {

                foreach (var fb in feedbacks)
                {
                    var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == fb.UserID);

                    var fbDetails = new FeedbackDetails
                    {
                        User = user,
                        DateCreated = fb.DateCreated,
                        FeedbackMessage = fb.FeedbackMessage,
                        IsArchived = fb.IsArchived,
                        FeedbackID = fb.FeedbackID
                    };
                    
                    vm.Feedbacks.Add(fbDetails);
                }

                return View(vm);
            }

            return View();

        }
        [Authorize(Roles = "Admin, SalesClerk, OperationsManager")]
        public async Task<IActionResult> ArchiveTable()
        {
            var feedbacks = await _context.Feedbacks.Where(f => f.IsArchived == true).ToListAsync();
            FeedbackTableViewModel vm = new FeedbackTableViewModel();
            vm.Feedbacks = new List<FeedbackDetails>();

            if (feedbacks != null)
            {

                foreach (var fb in feedbacks)
                {
                    var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == fb.UserID);

                    var fbDetails = new FeedbackDetails
                    {
                        User = user,
                        DateCreated = fb.DateCreated,
                        FeedbackMessage = fb.FeedbackMessage,
                        IsArchived = fb.IsArchived,
                        FeedbackID = fb.FeedbackID
                    };
                    
                    vm.Feedbacks.Add(fbDetails);
                }

                return View(vm);
            }

            return View();

        }

        public IActionResult Success()
        {
            return View();
        }

        public async Task<IActionResult> ViewMessage(int messageId)
        {
            var message = await _context.Messages.FirstOrDefaultAsync(m => m.MessageID == messageId);

            if (message != null)
            {
                var fromUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == message.FromUserID);
                var messageDetails = new MessageDetails
                {
                    DateCreated = message.DateCreated,
                    FromUser = fromUser,
                    MessageContent = message.MessageContent,
                    MessageID = message.MessageID,
                };
                return View(messageDetails);
            }

            return NotFound();
        }
        
        [Authorize(Roles = "Admin, SalesClerk, OperationsManager")]

        public async Task<IActionResult> ViewFeedback(int id)
        {
            var feedback = await _context.Feedbacks.FirstOrDefaultAsync(f => f.FeedbackID == id);
            if (feedback != null)
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == feedback.UserID);
                var details = new FeedbackDetails
                {
                    User = user,
                    DateCreated = feedback.DateCreated,
                    FeedbackMessage = feedback.FeedbackMessage,
                    FeedbackID = feedback.FeedbackID,
                    IsArchived = feedback.IsArchived
                };

                return View(details);
            }

            return NotFound();
        }

        
        [Authorize(Roles = "Admin, SalesClerk, OperationsManager")]

        public async Task<IActionResult> Archive(int id)
        {
            var feedback = await _context.Feedbacks.FirstOrDefaultAsync(f => f.FeedbackID == id);

            if (feedback != null)
            {
                feedback.IsArchived = true;
                _context.Entry(feedback).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(FeedbacksTable));
            }

            return NotFound();

        }
        
        public async Task<IActionResult> ArchiveMessage(int id)
        {
            var message = await _context.Messages.FirstOrDefaultAsync(f => f.MessageID == id);

            if (message != null)
            {
                message.IsArchived = true;
                _context.Entry(message).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return NotFound();

        }
        
        [Authorize(Roles = "Admin, SalesClerk, OperationsManager")]

        
        public async Task<IActionResult> Reply(int id)
        {
            var feedback = await _context.Feedbacks.FirstOrDefaultAsync(f => f.FeedbackID == id);

            if (feedback != null)
            {            
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var userId = user.Id;
                var fromUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
                var toUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == feedback.UserID);
                MessageDetails m = new MessageDetails
                {
                    FromUser = user,
                    ToUser = toUser,
                    ToUserID = toUser.Id,
                };

                return View(m);
            }

            return NotFound();
        }

        public IActionResult ReplySuccess()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ReplyFinal(MessageDetails m)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var userId = user.Id;

                var message = new Message
                {
                    MessageContent = m.MessageContent,
                    FromUserID = userId,
                    ToUserID = m.ToUserID,
                    DateCreated = DateTime.Now
                };

                _context.Messages.Add(message);
//                message.IsArchived = true;
//
//                _context.Entry(message).State = EntityState.Modified;
                
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(FeedbacksTable));
            }



            return View("Index");
        }
    }
    
    
}