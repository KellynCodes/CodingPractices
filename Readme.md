# 👓🤷‍♀️🚗Best 15 Coding Practices with illlustration and XML Comments❤💕

## 1. Field OR variable naming👌

**All your field and vairables should be named according to the value it stores** 
***Example***:
```C#
string u = Console.ReadLine();
```
This code above is a bad practice because the field name those not convey the information stored in the field.
**Check This example Bellow**
```C#
string user = Console.ReadLine();
```
This particular example above convey the actual information stored in this field... 
**It always advisable to name your field and variables accordingly, this helps in code maintenance and readability.**

## 2. Class Naming 👓👓👓🕶

**Naming classes depending on what operation it perform or values it stores is a best coding practice as it gives other developers clear knowledge of what you are doing. It does promote code maintenance and readability.**

```C#
///<summary>
/// This cod below gives clear illustration on how you can name classes appropriately.
///</summary>
///<returns>
///This code has a function that takes in two augments person birthday and the current date. 
///</returns>

public static class CalculateAge
///<summary>
///Here the class is named based on which operation it performs
///</summary>
{
    ///<summary>
    ///Here the function is also named based on what action it performs
    ///</summary>
    public int CalculateAge(DateTime birthDate, DateTime TodaysDate)
{
    int age = TodaysDate.Year - birthDate.Year;

    if (TodaysDate.Month < birthDate.Month 
    || 
    (TodaysDate.Month == birthDate.Month 
    && 
    TodaysDate.Day < birthDate.Day))
        age--;

    return age;
}
}
///<summary>
///All the variables in the code is named accordingly on what value it holds. This gives a clear understanding of your code.
```
**BELOW IS THE BAD PRACTICE OF THE ABOVE CODE
```c#
///<summary>
/// This cod below gives clear illustration on how you can name classes appropriately.
///</summary>
///<returns>
///This code has a function that takes in two augments person birthday and the current date. 
///</returns>

public static class ClcA
///<summary>
///Here the class is named ClcA which does not convey any meaningful information about what the classs does. This create ambiguity.
///</summary>
{
    ///<summary>
    ///Here the function is named in a way that cause confusion. User will spent time trying to understand simple logic it at all he/she would.
    ///</summary>
    public int CA(DateTime hbd, DateTime T)
{
    int a = T.Year - hbd.Year;

    if (T.Month < hbd.Month 
    || 
    (T.Month == hbd.Month 
    && 
    T.Day < hbd.Day))
        a--;

    return a;
}
}
///<summary>
///All the variables in the code is not named according to what value it holds.
```