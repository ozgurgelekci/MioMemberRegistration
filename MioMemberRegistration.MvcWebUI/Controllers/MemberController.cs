using System.Web.Mvc;
using MioMemberRegistration.Business.Abstract;
using MioMemberRegistration.Entities.Concrete;
using MioMemberRegistration.MvcWebUI.Filters;
using MioMemberRegistration.MvcWebUI.Models;

namespace MioMemberRegistration.MvcWebUI.Controllers
{
    public class MemberController : Controller
    {
        private IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        // GET: Member
        public ActionResult Add()
        {
            return View(new MemberAddViewModel());
        }

        [HttpPost]
        [ExceptionHandler]
        public ActionResult Add(Member member)
        {
            _memberService.Add(member);
            return View();
        }
    }
}