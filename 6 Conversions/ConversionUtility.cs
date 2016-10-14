namespace _6_Conversions
{
internal class ConversionUtility
{
    public const double KM_PER_MILE = 1.60934;
    public const int INCHES_PER_FEET = 12;
    public const int FEET_PER_MILE = 5280;
    public const int SECONDS_PER_MINUTE = 60;
    public const int HOURS_PER_DAY = 24;
    public const int CENTS_PER_DOLLAR = 100;

    public ConversionUtility()
    {

    }



//Converts miles to kilometers
public double convertMileToKM(float mile)
{
    double result = 0;
    result = mile * KM_PER_MILE;
    return result;
}

//Converts feet to inches
public double convertFeetToInches(float feet)
{
    double result = 0;
    result = feet * INCHES_PER_FEET;
    return result;

}

//Converts Miles to feet
public double convertMilesToFeet(float mile)
{
    double result = 0;
    result = mile * FEET_PER_MILE;
    return result;

}

//Converts minutes to seconds
public double convertMinutesToSeconds(float minutes)
{
    double result = 0;
    result = minutes * SECONDS_PER_MINUTE;
    return result;

}

//Converts days to hours
public double convertHoursPerDay(float days)
{
    double result = 0;
    result =days * HOURS_PER_DAY;
    return result;

}

//Converts dollars to cents
public double convertCentsToDollars(float cent)
{
    double result = 0;
    result = cent / CENTS_PER_DOLLAR;
    return result;

}


}
}
    
