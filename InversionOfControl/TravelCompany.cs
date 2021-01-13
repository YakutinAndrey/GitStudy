using Alword.Buisiness.IoC.Abstractions;
using Alword.Buisiness.IoC.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.IoC
{
  public class TravelCompany
  {
    private readonly ITransportSystem transportSystem;
    
    /// <summary>
    /// Турагенство
    /// </summary>
    /// <param name="transportSystem">Транспортная система</param>
    public TravelCompany(ITransportSystem transportSystem)
    {
      this.transportSystem = transportSystem;
    }

    public void ArrangeVacation(Person person)
    {
      transportSystem.Transport(person);
    }
  }
}
