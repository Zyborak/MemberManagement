using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MM_Entities.Entities
{
    public class Member
    {
        [Key]
        [Display(Name = "ID")]
        public int MemberID { get; set; }
        [Display(Name = "Title")]
        public string MemberTitle { get; set; }
        [Display(Name = "Image")]
        public string MemberImage { get; set; }
        [Display(Name = "First Name")]
        public string MemberFirstName { get; set; }
        [Display(Name = "Last Name")]
        public string MemberLastName { get; set; }
        [Display(Name = "Active")]
        public bool IsActive { get; set; }
        [Display(Name = "Created Date")]
        public DateTime? CreatedDateTime { get; set; }
        [Display(Name = "Updated Date")]
        public DateTime? UpdatedDateTime { get; set; }
    }
}
