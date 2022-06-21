using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Molotok34.Models;

namespace Molotok34.Controllers
{
    public class CatalogController : Controller
    {
        private BeautyStoreEntities db = new BeautyStoreEntities();

        // GET: Catalog
        public ActionResult Index()
        {
            var Services = db.Services.Include(p => p.Categoris);
            return View(Services.ToList());
        }

        // GET: Catalog/Details/5
        //public ActionResult Product(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Services Services = db.Services.Find(id);
        //    if (Services == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(Services);
        //}

        public ActionResult Product(int? id, [Bind(Include = "Fullname,Phone,Email")] Clients clients)
        {
            if (String.IsNullOrEmpty(clients.Fullname) == false)
            {

                try
                {
                    var clientsTmp = BeautyStoreEntities.GetContext().Clients.ToList();
                    clientsTmp = clientsTmp.Where(p => p.Email.Contains(clients.Email)).ToList();

                    var client = clientsTmp.LastOrDefault();

                    if (client == null)
                    {
                        clients.Email = clients.Email;
                        clients.Fullname = clients.Fullname;
                        clients.Phone = clients.Phone;
                        db.Clients.Add(clients);
                        db.SaveChanges();

                        var clientsTmp2 = BeautyStoreEntities.GetContext().Clients.ToList();
                        clientsTmp2 = clientsTmp2.Where(p => p.Email.Contains(clients.Email)).ToList();
                        client = clientsTmp2.LastOrDefault();
                    }

                    ClientService ClientService = new ClientService();

                    ClientService.IdClient = client.Id;
                    ClientService.IdService = Convert.ToInt32(id);
                    ClientService.Date = DateTime.Now;

                    db.ClientService.Add(ClientService);
                    db.SaveChanges();

                    TempData["notice"] = "Вы успешно оплатили товар, вся информация отправлена на Вашу электронную почту, которую Вы указали";

                    Services Services = db.Services.Find(ClientService.IdService);
                    if (Services == null)
                    {
                        return HttpNotFound();
                    }
                    return View(Services);
                }
                catch(Exception ex)
                {
                    TempData["notice"] = ex.Message + " | " + clients.Email + " | " + clients.Fullname + " | " + clients.Phone;

                    Services Services = db.Services.Find(id);
                    if (Services == null)
                    {
                        return HttpNotFound();
                    }
                    return View(Services);
                }

                
            }
            else
            {
                Services Services = db.Services.Find(id);
                if (Services == null)
                {
                    return HttpNotFound();
                }
                return View(Services);
            }
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
