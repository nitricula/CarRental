namespace Core.Utilities.Results.Concrete.Errors
{
    public class ErrorDataResult<T> : DataResult<T>
    {
       

        public ErrorDataResult(T data, string Message) : base(data, false, Message)
        {
        }
        public ErrorDataResult(T data) : base(data, false)
        {
        }
    }

}
