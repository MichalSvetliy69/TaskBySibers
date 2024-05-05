using System.ComponentModel.DataAnnotations;

namespace TaskBySibers.Models
{
    /// <summary>
    /// Model model for any other model. (Have only Id field)
    /// </summary>
    public class BaseModel
    {
        [Key]
        public int Id { get; set; } 
    }
}

