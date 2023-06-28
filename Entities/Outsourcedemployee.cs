using System;

namespace Funcionarios.Entities;

class Outsourcedemployee : Employee
{
  public double AdditionalCharge { get; set; }
  public Outsourcedemployee()
  {

  }
  public Outsourcedemployee(string name, int hours, double valuePerHour, double additionalcharge) : base(name, hours, valuePerHour)

  {
    this.AdditionalCharge = additionalcharge;

  }

  public override double Payment (){
    return base.Payment()+ (1.1 * AdditionalCharge);
  }

}
