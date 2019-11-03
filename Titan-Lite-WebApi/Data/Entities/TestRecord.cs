using System.ComponentModel.DataAnnotations.Schema;

namespace Titan.Data.Entities
{
    public class TestRecord
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}