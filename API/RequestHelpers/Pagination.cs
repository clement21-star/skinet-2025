using System;

namespace API.RequestHelpers;

public class Pagination<T>(int pageIndex, int pageSize, int Count, IReadOnlyList<T> data)
{
    public int PageIndex { get; set; } = pageIndex;
    public int PageSize { get; set; } = pageSize;
    public int Count { get; set; } = Count;
    public IReadOnlyList<T> Data { get; set; } = data;

}
