using System;
					
public class Rectangle
{
	double width, height;		// תכונות המלבן

	// פעולה בונה
	Rectangle(double Width, double Height)
	{
		width	= Width;
		height	= Height;
	}
	
	// פעולה שמחזירה את שטח המלבן
	double area() 
	{
		return width*height;
	}
		
	// פועלה שמחזירה את היקף המלבן
	double hekef()
	{
		return (width+height)*2;	// היקף מלבן זה פעמיים אורך הצלע ופעמיים רוחב הצלע
	}
	
	// פעולה שמעדכנת את רוחב המלבן
	void setWidth(double Width)
	{
		width	=  Width;		// (שנשלח ע"י מי שקרא לפעולה) Width הרוחב החדש והמעודכן יהיה
	}
	
	// פעולה שמעדכנת את אורך המלבן
	void setHeight(double Height)
	{
		height	=  Height;		// (שנשלח ע"י מי שקרא לפעולה) Height האורך החדש והמעודכן יהיה
	}	
	
	// *****************  Main() כאו מתחילה התכנית בפעולה הראשית  *****************
	public static void Main()
	{
		Console.WriteLine("?מה הרוחב של המלבן");
		double width1	= double.Parse(Console.ReadLine());
		
		Console.WriteLine("?מה האורך של המלבן");
		double height1	= double.Parse(Console.ReadLine());		
		
		// יש לנו מה שאנחנו צריכים כדי לבנות את המלבן
		// אז נפעיל את הפעולה הבונה לבניית מלבן
		Rectangle rect = new Rectangle(width1, height1);
	
		// נדפיס יפה למסך את המימדים של המלבן שלנו
		Console.WriteLine();
		Console.Write("היקף המלבן הוא " + rect.hekef());
		Console.WriteLine();
		Console.WriteLine("שטח המלבן הוא " + rect.area());
		
		// נראה איך נראה מלבן שהאורך שלו 4.5 והרוחב 2
		rect.setHeight(4.5);
		rect.setWidth(2);
		Console.Write("\n" + "אורך המלבן עודכן ל 4.5 והאורך עודכן ל 2");

		// נדפיס יפה את המימדים החדשים של המלבן עם האורך והרוחב המעודכנים
		Console.WriteLine();
		Console.Write("היקף המלבן הוא " + rect.hekef());
		Console.WriteLine();
		Console.WriteLine("שטח המלבן הוא " + rect.area());
	}
}
