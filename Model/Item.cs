using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Model
{
    public class Item
    {
        public int Id { get; set; }
        [StringLength(200, ErrorMessage = "Your name is extremely long")]
        public string Name { get; set; }
        [DataType(DataType.Date, ErrorMessage = "You need to input a valid date")]
        public DateTime Due { get; set; }
    }
}
