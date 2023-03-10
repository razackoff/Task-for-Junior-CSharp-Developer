using System;

namespace Market.Application.Common.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException()
            : base("Error installment range.") { }
    }
}
