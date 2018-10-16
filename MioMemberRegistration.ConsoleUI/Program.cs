using System;
using MioMemberRegistration.Business.Abstract;
using MioMemberRegistration.Business.DependencyResolvers.Ninject;
using MioMemberRegistration.Entities.Concrete;

namespace MioMemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IMemberService memberService = InstanceFactory.GetInstance<IMemberService>();
                memberService.Add(new Member
                {
                    Email = "your email",
                    FirstName = "your name",
                    LastName = "your last name",
                    DateOfBirth = new DateTime(2018, 10, 16), //today
                    TcNo = "your tc no"
                });

                Console.WriteLine("added");
                Console.ReadLine();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.ReadLine();
            }
        }
    }
}
