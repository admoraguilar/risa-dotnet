using System;
using System.Globalization;

CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
foreach(CultureInfo culture in cultures) {
	Console.WriteLine($"{culture.DisplayName} - {culture.Name}");
}