using Microsoft.VisualBasic.CompilerServices;

namespace PortfolioSite.Models;

public static class WorksData
{
    public static readonly List<WorkItem> All =
    [
        new("k-means-iris", "project", "2026-05", "Algorytm k-śrenich do klasyfikacji danych iris",
            "K-means algorithm for Iris data clustering", ["C#", "ML", "Rider"],
            "https://github.com/Jakobb32866/NAI_MPP_5/tree/main", null),
        
        new("ta-strona", "project", "2026-04",
            "Ta strona", "This website",
            ["Blazor", "C#", ".NET", "HTML", "CSS", "Github", "Git", "Rider", "JavaScript"],
            "https://github.com/Jakobb32866/jakobb32866.github.io", "https://jakobb32866.github.io"),
    ];
}