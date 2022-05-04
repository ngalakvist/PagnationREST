using Pagination.WebApi.Filter;
using System;

namespace Pagination.WebApi.Services
{
    public interface IUriService
    {
        public Uri GetPageUri(PaginationFilter filter, string route);
    }
}