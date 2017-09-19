using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStore.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public byte MembershipTypeId { get; set; }

        //类型和DTO对应，但属性名称和领域对应
        public MembershipTypeDto MembershipType { get; set; }

        public DateTime? Birthdate { get; set; }
    }
}