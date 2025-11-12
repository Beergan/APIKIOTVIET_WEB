using System.Collections.Generic;

public class PageListModel
{
    public IDictionary<string, string> Phrases { get; set; } = new Dictionary<string, string>();

    public KeyValuePair<string, string>[] Breadcrumbs { get; set; }

    public string Title { get; set; }

    public string MetaDescription { get; set; }

    public string MetaKeywords { get; set; }

    public int PageSize { get; set; } = 8;

    public long TotalPages { get; set; }

    public long CurrentPage { get; set; }
}