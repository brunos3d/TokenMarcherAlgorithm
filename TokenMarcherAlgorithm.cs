// (c) 2019 Moonwave Interactive. All rights reserved under MIT License.

/// <summary>
/// Returns a <see cref="System.Collections.Generic.List{T}"/> of tokens from the specified text string.
/// </summary>
/// <param name="text">The text from which to tokenize.</param>
/// <returns>A <see cref="System.Collections.Generic.List{T}"/> of tokens from the specified text string.</returns>
private static List<string> Tokenize(string text)
{
    List<string> tokens = new List<string>();
    List<char> chars = text.ToList();
    StringBuilder buffer = new StringBuilder();
    for (int i = 0; i < chars.Count; i++)
    {
        if (char.IsLetterOrDigit(chars[i])) { buffer.Append(chars[i]); }
        else
        {
            if (buffer.Length != 0) { tokens.Add(buffer.ToString()); buffer.Clear(); }
            // Here you can define a custom pattern using a character array.
            if (chars[i] != ' ') { tokens.Add(chars[i].ToString()); }
        }
    }
    if (buffer.Length != 0) { tokens.Add(buffer.ToString()); }
    return tokens;
}