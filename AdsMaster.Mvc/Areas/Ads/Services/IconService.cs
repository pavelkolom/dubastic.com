using System;
using System.Collections.Generic;
using System.Text;

namespace AdsMaster.Mvc.Areas.Ads.Services
{
  public static class IconService
  {
    public static string GetIcon(string category)
    {
      switch(category)
      {
        case "EVENT":
          return "lnr-gift";
        case "COURIER SERVICES":
          return "lnr-location";
        case "ANIMALS & PETS":
          return "lnr-paw";
        case "EDUCATION":
          return "lnr-graduation-hat";
        case "BUSINESS SERVICES":
          return "lnr-briefcase";
        case "ADS & MARKETING":
          return "lnr-bullhorn";
        case "DESIGN":
          return "lnr-magic-wand";
        case "TRANSLATION":
          return "lnr-spell-check";
        case "CLEANING SERVICES":
          return "lnr-smile";
        case "TRANSPORTATION":
          return "lnr-earth";
        case "HEALTH & BEAUTY":
          return "lnr-heart";
        case "INSTALL & REPAIR":
          return "lnr-cog";
        case "RENOVATION WORKS":
          return "lnr-sync";
        case "FURNITURE WORKS":
          return "lnr-pushpin";
        case "PHOTO & VIDEO":
          return "lnr-camera";
        case "COMPUTER HELP":
          return "lnr-laptop-phone";
        case "REMOTE ASSISTANCE":
          return "lnr-phone";
        case "SOFTWARE & WEB DEV":
          return "lnr-calendar-full";
        case "DOMESTIC SERVICES":
          return "lnr-home";
        case "AUTO SERVICES":
          return "lnr-car";
        default:
          return "lnr-file-empty";
      }
        

      return "lnr-file-empty";
    }
  }
}
