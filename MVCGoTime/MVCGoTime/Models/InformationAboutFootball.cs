using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGoTime.Models
{
    public class InformationAboutFootball
    {
         public string HeadCoach { get; set; }                                     //
         public string BowlRecord { get; set; }                                    //
         public string YearNationalTitle { get; set; }                             //

        public InformationAboutFootball()                                          //
        {                                                                          //
            HeadCoach = "Lincoln Riley";                                           // 
            BowlRecord = "29-22-1(.567)";                                          //
            YearNationalTitle = "7 (1950, 1955, 1956, 1974, 1975, 1985, 2000)";    //
        }                                                                          //
    }
}