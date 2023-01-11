class Reservation
{
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; } 
    public DateTime CheckOut { get; set; }

    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    {    
        RoomNumber = roomNumber;
        UpdateDates(checkIn, checkOut);
    }

    public int Duration() {
        TimeSpan time = CheckOut.Subtract(CheckIn);
        return time.Days;
    }

    public void UpdateDates(DateTime checkIn, DateTime checkOut) {
        if (checkOut < checkIn) {
            throw new ReservationException("Check-out date must be after check-in date");
        }
        DateTime today = DateTime.Today;
        if (checkIn < today || checkOut < today) {
            throw new ReservationException("Reservation dates must be present or future dates");
        }

        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public override string ToString()
    {
        return $"Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
    }
}