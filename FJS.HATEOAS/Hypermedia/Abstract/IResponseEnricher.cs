﻿using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace FJS.HATEOAS.Hypermedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutingContext context);
        Task Enrich(ResultExecutingContext context);
    }
}
