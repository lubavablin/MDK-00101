using System;
using System.Collections.Generic;
using System.Linq;

public enum Category
{
    Technology,
    Science,
    Art,
    Nature,
    Sports,
    Business
}

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Category Category { get; set; }
    public double Complexity { get; set; }    // 0-100
    public double Innovation { get; set; }    // 0-100
    public double Impact { get; set; }        // 0-100

    public Project(int id, string name, Category category, double complexity, double innovation, double impact)
    {
        Id = id;
        Name = name;
        Category = category;
        Complexity = complexity;
        Innovation = innovation;
        Impact = impact;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Category: {Category}, Complexity: {Complexity:F1}, Innovation: {Innovation:F1}, Impact: {Impact:F1}";
    }
}