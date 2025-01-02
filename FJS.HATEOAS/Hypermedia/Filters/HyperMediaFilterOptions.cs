using FJS.HATEOAS.Hypermedia.Abstract;
using System.Collections.Generic;

namespace FJS.HATEOAS.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
