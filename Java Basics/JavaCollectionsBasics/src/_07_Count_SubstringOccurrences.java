import java.util.ArrayList;
import java.util.Scanner;

public class _07_Count_SubstringOccurrences {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine().toLowerCase();
		String word = in.nextLine().toLowerCase();
		int counter = 0;
		for (int i = 0; i <= input.length()-word.length(); i++) {
			if(input.substring(0+i,word.length()+i).contains(word)){
				counter++;
			}
		}
		System.out.println(counter);
		
	}

}
