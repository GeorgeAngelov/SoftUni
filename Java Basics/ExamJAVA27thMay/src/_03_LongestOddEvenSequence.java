import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;


public class _03_LongestOddEvenSequence {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		
		Pattern regex = Pattern.compile("\\d+");
		Matcher matcher = regex.matcher(input);
		
		ArrayList<Integer> group = new ArrayList<>();
		while(matcher.find()){
			group.add(Integer.parseInt(matcher.group())) ;
		}
		int biggestSequance = 0;
		int tempSequance =0;
		boolean shouldBeOdd = group.get(0)%2 !=0;
		for (Integer num : group) {
			boolean isOdd = num%2 !=0;
			if(isOdd==shouldBeOdd || num == 0){
				tempSequance++;
			}else{
				shouldBeOdd=isOdd;
				tempSequance = 1;
			}
			shouldBeOdd=!shouldBeOdd;
			if(tempSequance>biggestSequance){
				biggestSequance=tempSequance;
			}
		}
		System.out.println(biggestSequance);
	}

}
