using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MigrationWorkflow
{
    public class Human
    {

        public long HumanId { get; set; }

        public string name { get; set; }

        public int age { get; set; }

        public long DogId { get; set; }

        public long CatId { get; set; }

        [ForeignKey("CatId")]
        public Cat Overlord { get; set; }

       public Human()
        {

        }
    }
}
