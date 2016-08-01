using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MigrationWorkflow
{
    public class Cat
    {
        [Key]
        public long CatId { get; set; }

        public string FavoriteNappingSpot { get; set; }

        public long HumanId { get; set; }

        public Cat()
        {

        }
    }
}
