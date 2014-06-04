import java.util.Scanner;


public class _05_CountAllWords {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		String[] split = input.split("([().,!?:;\"'-]|\\s)+");
		System.out.println(split.length);
	}
}
