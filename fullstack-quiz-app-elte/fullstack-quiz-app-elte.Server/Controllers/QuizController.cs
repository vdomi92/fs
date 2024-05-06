using fullstack_quiz_app_elte.Server.BLL.Contracts;
using fullstack_quiz_app_elte.Server.BLL.DTOS;
using fullstack_quiz_app_elte.Server.BLL.Mapping;
using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Common;
using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Quizzes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace fullstack_quiz_app_elte.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {

        private readonly IQuizService _quizService;

        private readonly IUserStore<AppUser> _userManager;

        public QuizController(IQuizService quizService, IUserStore<AppUser> userManager)
        {
            _quizService = quizService;
            _userManager = userManager;
        }

        [HttpPost(Name = "CreateQuiz")]
        public async Task<IActionResult> CreateQuiz([FromBody] QuizDTO quizDto)
        {
            Quiz quiz = quizDto.FromDTO();

            _quizService.CreateQuiz(quiz);

            //find user 
            var username = User.Identity?.Name;
            if(username == null)
            {
                return BadRequest();
            }

            var user = await _userManager.FindByNameAsync(username, HttpContext.RequestAborted);

            //user->quizzes->add(quiz)

            _quizService.SaveChanges();

            return Ok(quiz);
        }
    }
}
