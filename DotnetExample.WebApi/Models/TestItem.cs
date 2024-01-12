using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotnetExample.WebApi.Models;

public class TestItem {
    public long Id { get; set; }
    [Required]
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}