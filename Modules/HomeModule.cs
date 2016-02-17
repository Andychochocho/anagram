using Nancy;
using System.Collections.Generic;
using Anagrams;
using System;

namespace Anagrams
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
    Get["/"] = _ => View["index.cshtml"];
    Post["/printout"] = _ =>
      {
        Anagram AnagramObject = new Anagram(Request.Form["inputNumberOne"], Request.Form["inputNumberTwo"]);
        string newString = AnagramObject.CompareInputs();
        return View["printout.cshtml", newString];
      };
    }
  }
}
