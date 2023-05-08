using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Template() 
    {
      MadLibsVariable myMadLibs = new MadLibsVariable();
      myMadLibs.Adj1 = "Adjective Here";
      myMadLibs.Noun1 = "Noun Here";
      myMadLibs.Adj2 = "Adjective Here";
      myMadLibs.Noun2 = "Noun Here";
      myMadLibs.Adj3 = "Adjective Here";
      myMadLibs.Noun3 = "Noun Here";
      myMadLibs.Adj4 = "Adjective Here";
      myMadLibs.Noun4 = "Noun Here";
      myMadLibs.Adj5 = "Adjective Here";
      myMadLibs.Noun5 = "Noun Here";
      myMadLibs.Noun6 = "Noun Here";
      myMadLibs.Gerund1 = "Gerund Here";
      return View(myMadLibs);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/completed")]
    public ActionResult Completed(string gerund1, string adj1, string adj2, string adj3, string adj4, string adj5, string noun1, string noun2, string noun3, string noun4, string noun5, string noun6)
    {
      MadLibsVariable myMadLibs = new MadLibsVariable();
      myMadLibs.Adj1 = adj1;
      myMadLibs.Noun1 = noun1;
      myMadLibs.Adj2 = adj2;
      myMadLibs.Noun2 = noun2;
      myMadLibs.Adj3 = adj3;
      myMadLibs.Noun3 = noun3;
      myMadLibs.Adj4 = adj4;
      myMadLibs.Noun4 = noun4;
      myMadLibs.Adj5 = adj5;
      myMadLibs.Noun5 = noun5;
      myMadLibs.Noun6 = noun6;
      myMadLibs.Gerund1 = gerund1;
      return View(myMadLibs);
    }
  }
}