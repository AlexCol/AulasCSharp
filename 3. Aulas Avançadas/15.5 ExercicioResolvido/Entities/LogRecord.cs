class LogRecord : IComparable
{
    public string UserName { get; set; }
    public DateTime Instant { get; set; }

    public LogRecord(string userName, DateTime instant)
    {
        UserName = userName;
        Instant = instant;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        if (!(obj is LogRecord))
        {
            return false;
        }
        LogRecord other = obj as LogRecord;
        return UserName.Equals(other.UserName) && Instant.Equals(other.Instant);
    }

    public override int GetHashCode()
    {
        return UserName.GetHashCode() + Instant.GetHashCode();
    }

    public int CompareTo(object obj)
    {
        if (obj == null)
        {
            throw new InvalidCastException("Object is not LogRecord");
        }
        if (!(obj is LogRecord))
        {
            throw new InvalidCastException("Object is not LogRecord");
        }
        LogRecord other = obj as LogRecord;
        int result = 0;
        result = UserName.CompareTo(other.UserName);
        if (result == 0)
        {
            result = Instant.CompareTo(other.Instant);
        }
        return result;
    }

    public override string ToString()
    {
        return $"{UserName}, {Instant}";
    }
}