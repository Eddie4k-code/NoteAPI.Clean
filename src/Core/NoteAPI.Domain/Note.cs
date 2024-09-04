using System.ComponentModel.DataAnnotations;

namespace NoteAPI.Domain {
    public class Note : BaseEntity {

        [MaxLength(25)]
        public string NoteTitle {get; set;}

        [MaxLength(300)]
        public string NoteContent {get; set;}

        public int UserId {get; set;}
        public User User {get; set;}

    }

}