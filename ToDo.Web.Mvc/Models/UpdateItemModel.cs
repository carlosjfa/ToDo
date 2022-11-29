using System.ComponentModel.DataAnnotations;

namespace ToDo.Web.Mvc.Models
{

    public class UpdateItemModel
    {
        public Guid Id { get; private set; }
        [StringLength(256, MinimumLength = 5)]
        public string Description { get; set; }
        public bool Done { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
