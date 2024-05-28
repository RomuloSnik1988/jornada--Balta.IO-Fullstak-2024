﻿using System.Diagnostics;
using System.Runtime;
using System.Text.Json.Serialization;

namespace Fina.Core.Responses;

public class PagedResponse<TData> : Response<TData>
{
    [JsonConstructor]
    public PagedResponse(TData? data, int totalCount, int currentPage = 1, int pageSize = Configuration.DefaltPageSize) : base(data)
    {
        Data = data;
        TotalCount = totalCount;
        CurrentPage = currentPage;
        PageSize = pageSize;
    }

    public PagedResponse(TData data, int code = Configuration.DefaltStatusCode, string? message = null) : base(data, code, message)
    {
    }

    public int CurrentPage { get; set; }
    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
    public int PageSize { get; set; } = Configuration.DefaltPageSize;
    public int TotalCount { get; set; }
}

