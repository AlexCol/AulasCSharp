class RentalService {
    public double PricePerHour { get; private set; }
    public double PricePerDay { get; private set; }

    private BrazilTaxService BrazilTaxService = new BrazilTaxService();

    public RentalService(double pricePerHour, double pricePerDay) {
        PricePerHour = pricePerHour;
        PricePerDay = pricePerDay;
    }

    public void ProcessInvoice (CarRental carRental) {
        TimeSpan timeSpan = carRental.Finish.Subtract(carRental.Start);
        double basicPayment = 0.0;
        if (timeSpan.TotalHours <= 12) {
            basicPayment = PricePerDay * Math.Ceiling(timeSpan.TotalHours);
        } else {
            basicPayment = PricePerDay * Math.Ceiling(timeSpan.TotalDays);
        }
        double tax = BrazilTaxService.Tax(basicPayment);

        carRental.Invoice = new Invoice(basicPayment, tax);
    }
}