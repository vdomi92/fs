using fullstack_quiz_app_elte.Server.BLL.DTOS;
using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Quizzes;

namespace fullstack_quiz_app_elte.Server.BLL.Mapping
{
    public static class MappingExtensions
    {
        public static Quiz FromDTO(this QuizDTO quizDTO)
        {
            return new Quiz
            {
                Title = quizDTO.Title,
                Description = quizDTO.Description,
                Questions = quizDTO.Questions.Select(q => q.FromDTO()).ToList()
            };
        }

        public static Question FromDTO(this QuestionDTO questionDTO)
        {
            return new Question
            {
                QuestionText = questionDTO.QuestionText,
                Points = questionDTO.Points,
                AnswerOptions = questionDTO.AnswerOptions.Select(a => a.FromDTO()).ToList()
            };
        }

        public static Answer FromDTO(this AnswerDTO answerDTO)
        {
            return new Answer
            {
                AnswerText = answerDTO.AnswerText,
                IsCorrect = answerDTO.IsCorrect
            };
        }
    }
}
