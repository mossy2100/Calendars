namespace Galaxon.Calendars;

public interface IEarthDate
{
    public IEarthDate FromJulianDay(double jd);

    public double ToJulianDay();
}
