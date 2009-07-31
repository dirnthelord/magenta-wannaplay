namespace Magenta.Shared.Validation
{
    public class ValidationFailure
    {
        public ValidationFailure(string errorId)
            : this(errorId, null)
        {
        }

        public ValidationFailure(string errorId, object[] parameters)
        {
            ErrorId = errorId;
            Parameters = parameters;
        }

        public string ErrorId { get; private set; }

        public object[] Parameters { get; private set; }
    }
}