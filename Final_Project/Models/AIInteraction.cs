using Final_Project.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class AIInteraction
    {
        [Key]
        public int InteractionID { get; set; }  // Unique ID for each AI interaction

        
        [Required]
        public string UserId { get; set; }  // Stores the ID of the user who interacted with the AI
        public virtual ApplicationUser? User { get; set; }  // Navigation property to access user details

        // Relationship to the Course Topic 
        // (Since Topic is linked to Course, we only need TopicID to find both)
        [Required]
        public int TopicID { get; set; }
        public virtual CourseTopic? Topic { get; set; }

        public DateTime InteractionDate { get; set; } = DateTime.Now;
        // Stores when the interaction happened (default = current date/time)
        // Optional: We can track the specific Material/Assignment that triggered the session
        public int? MaterialID { get; set; }
        public virtual Material? Material { get; set; }
    }
}
// this is ai interaction model which will be used to store the interactions of the users with the ai sessions. it will have the user id, topic id, interaction date and material id (if any). this will help us to track the interactions of the users with the ai sessions and also to analyze the data later on.