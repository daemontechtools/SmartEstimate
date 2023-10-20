using System.Text.RegularExpressions;

namespace Daemon.Components;

public class Utils {
    private static readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
    private static readonly ILogger _logger = _loggerFactory.CreateLogger<Utils>();

public static string GetClass(params string[] classNames) {
    string classString = string.Join(" ", classNames);
    _logger.LogInformation("classString: " + classString);
    string cleanClasses = Regex.Replace(classString, @"\s+", " ");
    _logger.LogInformation("cleanClasses: " + cleanClasses);
    string[] uniqueClasses = cleanClasses.Split(" "); 
    _logger.LogInformation("uniqueClasses: " + string.Join(", ", uniqueClasses));
    // We will filter out duplicates
    // each element of uniqueClasses will be split by "-" character
    // matches will be prioritized by taking the last match in the array
    // two elements match if their last element is different, but the others are the same
    // e.g. "bg-red-500" and "bg-red-600" match, but "bg-red-500" and "bg-blue-500" don't
    var filteredClasses = new List<string>();
    foreach (var className in uniqueClasses) {
        var parts = className.Split("-");
        var matchFound = false;
        for (int i = filteredClasses.Count - 1; i >= 0; i--) {
            var filteredParts = filteredClasses[i].Split("-");
            if (parts.Length == filteredParts.Length && parts.Take(parts.Length - 1).SequenceEqual(filteredParts.Take(parts.Length - 1))) {
                matchFound = true;
                break;
            }
        }
        if (!matchFound) {
            filteredClasses.Add(className);
        }
    }
        string result = string.Join(" ", filteredClasses);
        _logger.LogInformation("result: " + result);
        return result;
        }
}