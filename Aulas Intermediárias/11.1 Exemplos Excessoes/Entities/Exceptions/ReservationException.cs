[System.Serializable]
public class ReservationException : System.Exception
{
    public ReservationException(string message) : base(message) { }
    public ReservationException(string message, System.Exception inner) : base(message, inner) { }
    protected ReservationException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}