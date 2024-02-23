namespace clashofclans.server.Services
{
    public class QuerySimpleStatusResponse<TResult>
    {
        public bool Success { get; set; }
        public TResult Result { get; set; }

        public QuerySimpleStatusResponse() { }

        public QuerySimpleStatusResponse(bool success) => Success = success;

        public QuerySimpleStatusResponse(bool success, TResult result) : this(success) => Result = result;

        public QuerySimpleStatusResponse(TResult result) : this(true, result) { }
    }

    public class SuccessQuerySimpleStatusResponse<TResult> : QuerySimpleStatusResponse<TResult>
    {
        public SuccessQuerySimpleStatusResponse(TResult result) : base(true, result) { }
    }

    public class ErrorQuerySimpleStatusResponse<TResult> : QuerySimpleStatusResponse<TResult>
    {
        public ErrorQuerySimpleStatusResponse(TResult result) : base(false, result) { }

        public ErrorQuerySimpleStatusResponse() : base(false, default) { }
    }
}