using SQLite;

namespace PeopleEM.Models
{
    [Table("people")]
    public class PeopleEM
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250), Unique]
        public string Name { get; set; }
    }
}
