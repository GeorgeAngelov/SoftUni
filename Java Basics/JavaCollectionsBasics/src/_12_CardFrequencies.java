import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;


public class _12_CardFrequencies {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String[] cards = in.nextLine().split("[ ♥♣♦♠]+");
		Map<String, Integer> cardMap = new LinkedHashMap<String, Integer>();
		for (String card : cards) {
			Integer count = cardMap.get(card);
			if(count == null){
				count = 0;
			}
			cardMap.put(card, count+1);
		}
		for (Map.Entry<String, Integer> entry : cardMap.entrySet()) {
			double frequency = (double) entry.getValue() * 100 / cards.length;
			System.out.printf("%s -> %.2f%%\n",entry.getKey(),frequency);
		}

	}

}
