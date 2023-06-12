namespace NokoodAssignment.Application.Dots
{
    public class ListQueryArgs
    {
        public string? Search { get; set; }
        public string? Sorting { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 50;
    }
}
