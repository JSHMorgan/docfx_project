using System.Numerics;

namespace DocFxTest;

/// <summary>
/// My Maths class.
/// </summary>
internal class MyMaths
{
    public static int TimesUsed { get; private set;}

    public static T Add<T>(T left, T right) where T : INumber<T>
    {
        SetTimesUsed();
        return left + right;
    }

    /// <summary>
    /// Private function to iterate TimesUsed property.
    /// </summary>
    private static void SetTimesUsed()
    {
        TimesUsed++;
    }
}
