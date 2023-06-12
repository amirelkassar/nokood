using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NokoodAssignment.Application.Dots
{
    public class SingleApiResponse<TData>
    {
        public bool Success { get; set; }
        public TData Data { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }
        public object Error { get; set; }
    }
}
