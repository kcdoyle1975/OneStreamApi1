using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    public class RacingController : Controller
    {
        static HttpClient _client = new HttpClient();

        // GET: GuessNumberCompetitionController
        public async Task<ActionResult> IndexAsync()
        {
            //var numberPicked = await _client.GetFromJsonAsync<NumberPicked>("https://localhost:44365/guesser");
            //HttpResponseMessage response = await _client.PostAsJsonAsync(
            //    "api/products", product);
            //response.EnsureSuccessStatusCode();
            var flashDelay = new Random().Next(10, 30000);
            HttpResponseMessage flashResponse = await _client.PostAsJsonAsync(
                "https://localhost:44365/api/runner", flashDelay);

            var flashTime = await _client.GetFromJsonAsync<int>("https://localhost:44365/api/runner");
            var supermanDelay = new Random().Next(10, 30000);



            return View($"This is the Flash's time {flashTime}");
        }

        // GET: GuessNumberCompetitionController/Details/5
        public ActionResult Details(int id)
        {
            return View("Details");
        }

        //// GET: GuessNumberCompetitionController/Create
        //public ActionResult Create()
        //{
        //    return View("Create");
        //}

        //// POST: GuessNumberCompetitionController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(IndexAsync));
        //    }
        //    catch
        //    {
        //        return View("Create(IFormCollection collection)");
        //    }
        //}

        //// GET: GuessNumberCompetitionController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View("Edit(int id)");
        //}

        //// POST: GuessNumberCompetitionController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(IndexAsync));
        //    }
        //    catch
        //    {
        //        return View("Edit(int id, IFormCollection collection)");
        //    }
        //}

        //// GET: GuessNumberCompetitionController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: GuessNumberCompetitionController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(IndexAsync));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
