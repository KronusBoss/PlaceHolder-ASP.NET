using PlaceHolder.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlaceHolder.Models
{
    [Table("tickets")]
    public class Ticket : BaseEntity
    {
        public string Description { get; set; }

        [StringLength(30)]
        public string Category { get; set; }

        [StringLength(30)]
        public string SubCategory { get; set; }

        [StringLength(50)]
        public string? Responsible { get; set; }

        [StringLength(50)]
        public string? Employee { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public int Severity { get; set; }

        public DateTime? CreationDate { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Status.StatusEnum Status { get; set; }

        [JsonIgnore]
        public User User { get; set; }

        public TicketAddress Address { get; set; }

        public long UserId { get; set; }

        public List<Historic>? Historical { get; set; }

        public Ticket() { }

        public Ticket(string description, string? category, string? subCategory, string? responsible, string? employee, string title, int severity, DateTime? creationDate, Status.StatusEnum status, User user, TicketAddress address, long userId, List<Historic>? historical)
        {
            Description = description;
            Category = category;
            SubCategory = subCategory;
            Responsible = responsible;
            Employee = employee;
            Title = title;
            Severity = severity;
            CreationDate = creationDate;
            Status = status;
            User = user;
            Address = address;
            UserId = userId;
            Historical = historical;
        }
    }
}
