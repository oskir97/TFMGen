using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFMGen.ApiTests.Models
{
    public class ResponseModel<T>
    {
        public T data { get; set; }
        public bool error { get; set; }
    }
}
