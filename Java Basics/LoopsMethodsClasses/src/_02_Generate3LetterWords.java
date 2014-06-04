
import java.util.Scanner;

public class _02_Generate3LetterWords {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		char arr[] = input.toCharArray();
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr.length; j++) {
				for (int m = 0; m < arr.length; m++) {
					System.out.printf("%c%c%c ",arr[i],arr[j],arr[m]);
				}
			}
		}
	}

}
