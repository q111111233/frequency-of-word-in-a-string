using Nancy;
using System;
using Frequency.Objects;

namespace Frequency
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        return View["index.cshtml"];
      };
      Post["/enter"] = _ => {
        RepeatCounter word = new RepeatCounter(Request.Form["word"], Request.Form["sentence"]);
        return View["result.cshtml", word.CountRepeats()];
      };
    }
  }
}
