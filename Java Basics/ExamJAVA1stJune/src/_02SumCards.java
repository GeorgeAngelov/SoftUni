import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;


public class _02SumCards {

	private static void addNumbers(Matcher match, ArrayList<Integer> cards) {
		while(match.find()){
			if(match.group().equals("J")){
				cards.add(12);
			}else if (match.group().equals("Q")) {
				cards.add(13);
			}else if (match.group().equals("K")) {
				cards.add(14);
			}else if(match.group().equals("A")){
				cards.add(15);
			}else{
				cards.add(Integer.parseInt(match.group()));
			}
		}
	}

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();

		Pattern regex = Pattern.compile("[\\dJQKA]+");
		Matcher match = regex.matcher(input);
		
		ArrayList<Integer> cards = new ArrayList<>();
		addNumbers(match, cards);
		
		int weigth = 0;
		int counter = 1;
		for (int i = 0; i < cards.size(); i+= counter) {
			int tempWeigth = 0;
			counter = 1;
			for (int j = i+1; j < cards.size(); j++) {
				if (cards.get(i) == cards.get(j)) {
					counter++;
				}else{
					break;
				}
			}
			tempWeigth = cards.get(i)*counter;
			if (counter !=1) {
				tempWeigth *=2;
			}
			weigth += tempWeigth;
		}
		System.out.println(weigth);
	}

}
