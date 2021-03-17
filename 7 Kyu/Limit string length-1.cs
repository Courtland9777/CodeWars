public static string Limit(string text, int limit) =>
    text.Length <= limit ? text :$"{text.Substring(0, limit)}...";