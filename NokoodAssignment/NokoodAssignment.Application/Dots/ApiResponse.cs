namespace NokoodAssignment.Application.Dots
{
    public class ApiResponse<TData>
    {
        public bool Success { get; set; }
        public TData Data { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }
        public object Error { get; set; }
    }
}
