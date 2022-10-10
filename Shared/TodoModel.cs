using System.ComponentModel.DataAnnotations;

public class TodoModel
{

    [Required (ErrorMessage = "Please insert a todo!")]
    public string? Todo { get; set; }
}