﻿using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace CapstoneTestPRS.Models;

public class Vendor {
    public int Id { get; set; }
    [StringLength(30)]
    public string Code { get; set; } =  string.Empty;
    [StringLength(30)]
    public string Name { get; set; } = string.Empty;
    [StringLength(30)]
    public string Address { get; set; } = string.Empty;
    [StringLength(30)]
    public string City { get; set; } = string.Empty;
    [StringLength(2)]
    public string State { get; set; } = string.Empty ;
    [StringLength(5)]
    public string ZipCode { get; set; } = string.Empty;
    [StringLength(12)]
    public string? Phone {  get; set; } = string.Empty;
    [StringLength(255)]
    public string? Email {  get; set; } = string.Empty;
}
