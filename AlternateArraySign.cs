public class AlternateArraySign
{
	public static void Main()
	{
		Console.WriteLine(ArraySign(new int[] {-1, -2, -3, -4, 3, 2, 1}));
		Console.WriteLine(ArraySign(new int[] {1, 5, 0, 2, -3}));
		Console.WriteLine(ArraySign(new int[] {-1, 1, -1, 1, -1}));
		Console.WriteLine(ArraySign(new int[] {41, 65, 14, 80, 20, 10, 55, 58, 24, 56, 28, 86, 96, 10, 3, 84, 4, 41, 13, 32, 42, 43, 83, 78, 82, 70, 15, -41}));
		Console.WriteLine(ArraySign(new int[] {9, 72, 34, 29, -49, -22, -77, -17, -66, -75, -44, -30, -24}));
		Console.WriteLine(ArraySign(new int[] {1, 28, -91, -62, -36, -1, -84, -90, -92, 61, 6, -58, -60, 2, 51, -15, -18, -81, 87, 84, 100, -84, -13, -87, -33, 72, -72, -59, -79, 28, -69, -97, -93, 17, 67, 11, -12, 19, 5, 42, -85, 71, -77, -82, 26, -58, -51, -14, 63, -85, -86, 66, 47, 57, -86, -25, -75, 59, -17, -71, 89, -78, -42, 30, 39, 61, -96, -30, -29, -92, -90, 69, 20, 65, 32, 92, 44, -71, -18, 87, -86, 23, -96, -21, -49, -96, -98, 35, -11, -1, 81, -48, 68, 5, 75, 57, -30, -7, 32, 86, -29, -86, -61, 45, -31, -93, -26, -9, 86, 57, -52, 75, 68, -58, 14, 27, -94, 47, -38, -44, 75, -83, 21, -83, 43, 62, 74, 97, 78, 43, 54, 28, 64, -19, -89, 88, 68, 18, -96, -83, -25, -71, 88, -84, -24, -61, 72, -90, -56, 29, 46, 56, 51, 16, 66, -2, 65, -95, 16, 51, 42, 61, 99, 89, -93, 59, -99, 69, 26, -61, 21, 41, 40, -4, -49, 3, -96, 57, 65, 72, -41, -77, -4, 61, 71, -88, 21, -95, 38, 64, 92, 0, -63}));
	}
	
	public static int ArraySign(int[] nums) {
		int product = 1;
		for (int i = 0; i < nums.Length; i++) {
			product *= nums[i];
		}
		if (product == 0) 
			return 0;
		else if (product > 0)
			return 1;
		else 
			return -1;
            
		return product;
	}
}

/**
 * This solution is not so user friendly for data types greater than double.
 * Does not multiply the greater numbers to correct value, even double doesn't work.  When multiplying by 0, returns NaN.  If no 0's, return Infinity.
 */
 
