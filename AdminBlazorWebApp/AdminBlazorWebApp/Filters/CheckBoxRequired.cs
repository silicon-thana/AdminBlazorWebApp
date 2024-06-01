using System.ComponentModel.DataAnnotations;

namespace AdminBlazorWebApp.Filters;

public class CheckBoxRequired : ValidationAttribute
{
    public override bool IsValid(object? value) => value is bool b && b;
}
