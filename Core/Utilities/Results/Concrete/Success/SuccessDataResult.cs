namespace Core.Utilities.Results.Concrete.Success
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        

        public SuccessDataResult(T data, string Message) : base(data, true, Message){}
        public SuccessDataResult(T data) : base(data, true) { }
    }
}
