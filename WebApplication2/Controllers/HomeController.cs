using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.IO;
using System.Security.Cryptography;
using System.Text;
using WebApplication2.Models;
using System.Data.Entity;
using System.Threading;
using System.Net;
using System.Net.Mail;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private NamlosEntities1 db = new NamlosEntities1();
        public ActionResult Index()
        {
            var Tnest = db.BOT_Toy_Nest.SqlQuery("SELECT * FROM BOT_Toy_Nest").Count();
            ViewBag.Tnest = Tnest;
            

            var Tlokator = db.BOT_Lokator_Nest.SqlQuery("SELECT * FROM BOT_Lokator_Nest").Count();
            ViewBag.Tlokator = Tlokator;

            var NestU = db.BOT_Toy_Nest.SqlQuery("SELECT * FROM BOT_Toy_Nest WHERE Status = 'Dipinjam'").Count();
            ViewBag.NestU = NestU;

            var tables = new NestModel
            {
                bOT_Toy_Nests = db.BOT_Toy_Nest.ToList(),
                bot_rak_Toys = db.BOT_Rak_Nest.ToList(),
            };


            return View(tables);

            //return View();
        }

        public ActionResult Member()
        {
            var Tmember = db.BOT_Register_Nest.SqlQuery("SELECT * FROM BOT_Register_Nest").Count();
            ViewBag.Tmember = Tmember;

            var tables = new NestModel
            {
                bot_register_Nests = db.BOT_Register_Nest.ToList()
            };


            return View(tables);
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