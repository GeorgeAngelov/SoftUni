import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;


public class _03_SimpleExpression {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		
		Pattern digitRegex = Pattern.compile("[\\d\\.]+");
		Matcher matcher = digitRegex.matcher(input);
		
		ArrayList<String> digits = new ArrayList<>();
		while(matcher.find()){
			digits.add(matcher.group());
		}
		Pattern operatorRegex = Pattern.compile("[+-]+");
		Matcher match = operatorRegex.matcher(input);
		
		ArrayList<String> operator = new ArrayList<String>();
		while (match.find()) {
			operator.add(match.group());
		}
		BigDecimal sum = new BigDecimal(digits.get(0));
		for (int i = 0; i < operator.size(); i++) {
			if (operator.get(i).equals("+")) {
				sum = sum.add(new BigDecimal(digits.get(i+1)));
			}else{
				sum=sum.subtract(new BigDecimal(digits.get(i+1)));
			}
		}
		System.out.println(sum.toPlainString());
	}

}
