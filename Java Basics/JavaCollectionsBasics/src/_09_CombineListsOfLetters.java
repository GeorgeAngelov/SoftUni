import java.util.ArrayList;
import java.util.Scanner;


public class _09_CombineListsOfLetters {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		ArrayList<Character> firstLine = new ArrayList<>();
		ArrayList<Character> secLine = new ArrayList<>();
		
		for (char  character : in.nextLine().toCharArray()) {
			firstLine.add(character);
		}
		for (Character character : in.nextLine().toCharArray()) {
			secLine.add(character);
		}
		ArrayList<Character> output =new ArrayList<>();
		output.addAll(firstLine);
		for (int i = 0; i < secLine.size(); i++) {
			if(!firstLine.contains(secLine.get(i))){
				output.add(' ');
				output.add(secLine.get(i));
			}
		}
		
		for (char character : output) {
			System.out.print(character);
		}
	}

}
