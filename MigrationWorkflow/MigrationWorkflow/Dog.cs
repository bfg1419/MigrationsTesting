using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationWorkflow
{
    public class Dog
    {
        public long DogId { get; set; }

        public string Breed { get; set; }

        public long HumanId { get; set; }

        [ForeignKey("HumanId")]
        public Human Owner { get; set; }

        public Dog()
        {

        }
    }
}
