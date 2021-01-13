using Alword.Buisiness.IoC.Abstractions;
using Alword.Buisiness.IoC.Domain;
using Alword.Buisiness.IoC.TransportService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.IoC
{
  public class Startup
  {
    public void ConfigureTravelCompany()
    {
      ITransportSystem transportSystem = new BusTransport();
      TravelCompany travelCompany = new TravelCompany(transportSystem);

      Person person = new Person();
      travelCompany.ArrangeVacation(person);
    }
  }
}
