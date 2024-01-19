using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CataboiSystem.Application.Models
{
    public class ResponseModel
    {
        public bool Success { get; set; } = true;
        public string? Message { get; set; }
        public object? Data { get; set; }
    }
}