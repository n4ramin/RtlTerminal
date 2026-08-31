using System.Windows.Media;

namespace RtlTerminal;

internal static class TerminalFontFallback
{
    /// <summary>
    /// Font families tried, in order, for glyphs missing from the selected
    /// terminal font (emoji, symbols, historic scripts). WPF applies this
    /// chain when the family source is a comma-separated list.
    /// </summary>
    public const string Chain =
        "Segoe UI Emoji, Segoe UI Symbol, Segoe UI Historic";

    public static FontFamily CreateFamily(string baseFamily) =>
        new($"{baseFamily}, {Chain}");
}
