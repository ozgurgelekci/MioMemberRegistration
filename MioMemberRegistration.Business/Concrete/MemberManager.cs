using System;
using MioBlog.Core.Aspects.Postsharp;
using MioMemberRegistration.Business.Abstract;
using MioMemberRegistration.Business.ServiceAdapters.Abstract;
using MioMemberRegistration.Business.ValidationRules.FluentValidation;
using MioMemberRegistration.DataAccess.Abstract;
using MioMemberRegistration.Entities.Concrete;

namespace MioMemberRegistration.Business.Concrete
{
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;
        private IKpsService _kpsService;

        public MemberManager(IMemberDal memberDal, IKpsService kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }

        [FluentValidationAspect(typeof(MemberValidator))]
        public void Add(Member member)
        {
            CheckIfMemberExists(member);
            CheckIfUserValidFromKps(member);

            _memberDal.Add(member);
        }

        private void CheckIfUserValidFromKps(Member member)
        {
            var kpsValidateUser = _kpsService.ValidateUser(member);
            if (!kpsValidateUser)
            {
                throw new Exception("user authentication is not valid");
            }
        }

        private void CheckIfMemberExists(Member member)
        {
            if (_memberDal.Get(m => m.TcNo == member.TcNo) != null)
            {
                throw new Exception("registered user");
            }
        }
    }
}
