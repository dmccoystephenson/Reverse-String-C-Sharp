namespace reverse_string_c_sharp {
	class ReverseString {
		static void Main(string[] args) {
			// tell user to input a string
			System.Console.WriteLine("Enter the string you want to reverse.");
			
			// get input
			string input = System.Console.ReadLine();
			
			// split into character array
			char[] array = input.ToCharArray();
			
			// reverse characters in array
			System.Array.Reverse(array);
			
			// create new string from array
			string reversed = new string(array);
			
			// output reversed string
			System.Console.WriteLine("\nReversed String: \n" + reversed);
		}
	}
}