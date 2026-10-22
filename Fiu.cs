using System;

class Fiu : Mama
{
    protected string model2 = "GTI 7";

    public override void AfisareModel()
    {
        base.AfisareModel();
        Console.WriteLine("Iar modelul nou este  " + model2);
    }
}