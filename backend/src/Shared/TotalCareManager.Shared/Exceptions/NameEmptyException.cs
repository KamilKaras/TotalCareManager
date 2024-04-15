using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCareManager.Shared.Exceptions
{
    public sealed class NameEmptyException : AppException
    {
        public NameEmptyException(string nameType) : base($"Nazwa {nameType} nie może być pusta")
        {
        }
    }
}