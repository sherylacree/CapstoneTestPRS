using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapstoneTestPRS.Models;

public class User {
    public int Id { get; set; }     
    
    public string UserName { get; set; } = string.Empty;
    [StringLength(30)]
    public string Password { get; set; } = string.Empty;
    [StringLength(30)]
    public string Firstname { get; set; } = string.Empty;
    [StringLength(30)]
    public string Lastname { get; set; } = string.Empty;
    [StringLength(12)]
    public string? Phone { get; set; } = string.Empty;
    [StringLength(255)]
    public string? Email { get; set; } = string.Empty;
    [Column(TypeName = "bit")]
    public bool IsReveiwer { get; set; }
    [Column(TypeName = "bit")]
    public bool IsAdmin { get; set; }
}
