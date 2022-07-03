using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SqlInjection.Models;
using SqlInjection.Services;

namespace SqlInjection.Controllers
{
    public class HesaplarController : Controller
    {
        private readonly IHesapService _hesapService;

        public HesaplarController(IHesapService hesapService)
        {
            _hesapService = hesapService;
        }
        // GET: HesaplarController
        public ActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Giris(KullaniciGirisModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _hesapService.Giris(model);

                if (result == "Başarılı")
                {
                    return RedirectToAction("Index", "Home");
                }

                if (result == "Başarısız")
                {
                    return View(model);
                }

            }
            return View(model);
        }

        // GET: HesaplarController/Details/5
        //    public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: HesaplarController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: HesaplarController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: HesaplarController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: HesaplarController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: HesaplarController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: HesaplarController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
