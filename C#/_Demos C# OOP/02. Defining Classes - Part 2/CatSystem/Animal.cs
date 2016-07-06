namespace CatSystem
{
    using System.ComponentModel.DataAnnotations;

    public class Animal
    {
        [Required]

        public string Name { get; set; }
    }
}