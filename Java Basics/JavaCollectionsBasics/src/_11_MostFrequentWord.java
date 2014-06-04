import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;


public class _11_MostFrequentWord {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String[] input = in.nextLine().toLowerCase()
				.split("([().,!?:;'\"-]|\\s)+");
		Map<String, Integer> wordCount = new TreeMap<>();
		int maxCount = 0;
		for (String word : input) {
			Integer count = wordCount.get(word);
			if(count == null){
				count=0;
			}
			if(count+1>maxCount){
				maxCount = count+1;
			}
			wordCount.put(word, count+1);
		}
		
		for (Map.Entry<String, Integer>max : wordCount.entrySet()) {
			if(max.getValue()== maxCount){
				System.out.printf("%s -> %d times\n", max.getKey(),
						max.getValue());
			}
			
		}
	}

}
