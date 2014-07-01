import java.math.BigDecimal;
import java.util.Arrays;
import java.util.Locale;
import java.util.Scanner;


public class _02_ThreeLargestNumbers {

	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		in.nextLine();
		
		BigDecimal[] numbersSet = new BigDecimal[n];
		
		for (int i = 0; i < numbersSet.length; i++) {
			String number = in.nextLine();
			numbersSet[i]= new BigDecimal(number);
		}
		Arrays.sort(numbersSet);
		int count = 3;
		for (int i = numbersSet.length-1; i >=0 && count>0 ; i--, count--) {
			System.out.println(numbersSet[i].toPlainString());
		}
	}

}
