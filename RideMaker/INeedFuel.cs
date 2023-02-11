interface INeedFuel
{
    string FuelType {get; set; }
    int FuelTotal {get; set; }
    int BaseFuel {get; set; }
    void GiveFuel(int n);
}