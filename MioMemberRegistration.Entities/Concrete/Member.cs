using MioBlog.Core.Entities;
using System;

namespace MioMemberRegistration.Entities.Concrete
{
    public class Member : IEntity
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string TcNo { get; set; }
    }
}
