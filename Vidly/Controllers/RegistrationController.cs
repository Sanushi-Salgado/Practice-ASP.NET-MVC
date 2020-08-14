using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        database_access_layer.db dblayer = new database_access_layer.db();
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult get_data()
        {
            DataSet ds = dblayer.Show_Data();
            List<registration> listreg = new List<registration>();
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                listreg.Add(new registration
                {
                    Name = dr["name"].ToString(),
                    Age = Convert.ToInt32(dr["age"])
                });
            }
            return Json(listreg, JsonRequestBehavior.AllowGet);
           
        }


    }

}