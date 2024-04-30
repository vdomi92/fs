using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class GivenAnswer : Entity
    {
        public required Answer Answer { get; set; }

        public required Question Question { get; set; }
    }
}
