namespace Pluralize;

public static class PluralizeTask
{
	public static string PluralizeRubles(int count)
	{
	string str = "рублей";
            if (count % 10 == 1) 
                str = "рубль";
            if (count % 10 >= 2 && count % 10 <= 4) 
                str = "рубля";
            if (count % 100 >= 11 && count % 100 <= 20) 
                str = "рублей";
            return str;
	}
}
