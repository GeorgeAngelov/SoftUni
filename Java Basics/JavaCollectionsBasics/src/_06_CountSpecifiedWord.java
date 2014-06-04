import java.util.Scanner;


public class _06_CountSpecifiedWord {
	
	public static void main(String[] args) {
		
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		String[] split = input.split("([().,!?:;\"'-]|\\s)+");
		
		String word = in.nextLine();
		int count=0;
		
		for (int i = 0; i < split.length; i++) {
			if(split[i].equals(word)){
				count++;
			}
		}
		System.out.println(count);
	}
}
