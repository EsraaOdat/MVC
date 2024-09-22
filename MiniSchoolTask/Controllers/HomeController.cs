using MiniSchoolTask.Models;
using System.Linq;
using System.Web.Mvc;

namespace MiniSchoolTask.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();




        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Dashboard()
        {
            if (Session["TeacherId"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }

           
            var teacherId = (int)Session["TeacherId"];
            var classes = db.Classs.Where(c => c.TeacherId == teacherId).ToList();
            var subjects = db.Subjects.Where(s => s.Class.TeacherId == teacherId).ToList();

            var dashboardViewModel = new DashboardViewModel
            {
                Classes = classes,
                Subjects = subjects
            };

            return View(dashboardViewModel);
        }

       
        public ActionResult ClassDetails(int id)
        {
            var classDetails = db.Classs.Include("Students").FirstOrDefault(c => c.ClassId == id);
            return View(classDetails);
        }

        
        public ActionResult SubjectDetails(int id)
        {
            var subjectDetails = db.Subjects.Include("Tasks").FirstOrDefault(s => s.SubjectId == id);
            return View(subjectDetails);
        }
    
public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        

       
    }

}
