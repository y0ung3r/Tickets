namespace Tickets.Extensions
{
    public static class FloatExtensions
    {
        public static float ToCentimeters(this float value)
        {
            return value * 28.346f;
        }
    }
}
