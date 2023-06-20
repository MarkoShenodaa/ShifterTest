namespace Encryption.CaesarCipher;

public class Shefter
{
    private readonly int _shiftFactor;

    /// <summary>
    /// Set Encryption shiftFactor to defult value = 5
    /// </summary>
    public Shefter()
    {
        _shiftFactor = 5;
    }

    /// <summary>
    /// Set shifFactor to selected value
    /// </summary>
    /// <param name="shiftFactor">Encruption shiftFactor custom value</param>
    public Shefter(int shiftFactor)
    {
        _shiftFactor = shiftFactor;
    }

    /// <summary>
    /// Create new shifted string value form the string A_Z
    /// </summary>
    /// <param name="valueToSheft">The string to shift</param>
    /// <returns>New string after shifted</returns>
    public string SheftedValue(string valueToSheft)
    {
        string sheftedValue = "";

        try
        {
            if (string.IsNullOrEmpty(valueToSheft))
            {
                throw new ArgumentNullException(valueToSheft,
                    "The input must have at least one character and it must be from A-Z only.");
            }
            foreach (char c in valueToSheft.ToCharArray())
            {
                if (c < 65 || c > 90)
                {
                    throw new Exception("Only A-Z supported.");
                }

                sheftedValue += ShiftedChar(c);
            }
        }
        catch (ArgumentNullException x)
        {
            sheftedValue =  x.Message;
        }
        catch (Exception e)
        {
            sheftedValue = e.Message;
        }
        return sheftedValue;
    }

    /// <summary>
    /// Genrate new shifted char value
    /// </summary>
    /// <param name="c">Char value to shift</param>
    /// <returns>New char value after shifted</returns>
    private char ShiftedChar(char c)
    {
        return c + _shiftFactor > 90 ? ((char)(c + _shiftFactor - 26)) : ((char)(c + _shiftFactor));
    }
}