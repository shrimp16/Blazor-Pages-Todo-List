using System.ComponentModel.DataAnnotations;
public class TodoModel
{

    [Required(ErrorMessage = "Please insert a todo!")]
    public string? Todo { get; set; }

}

public class TodoStorage
{
    public List<string> Todos { get; set; } = new();
}