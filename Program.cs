﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    async static Task Main(string[] args)
    {
      List<Employee> employees = new List<Employee>();
      employees = await PeopleFetcher.GetFromApi();
      // employees = PeopleFetcher.GetEmployees();
      Util.PrintEmployees(employees);
      Util.MakeCSV(employees);
      await Util.MakeBadges(employees);
    }
  }
}