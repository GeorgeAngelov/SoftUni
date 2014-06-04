import java.util.Scanner;
import java.util.regex.Pattern;
import java.util.regex.Matcher;

public class _08_ExtractEmails {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String text = in.nextLine();
		Pattern email = Pattern 
				.compile("[\\w-+]+(?:\\.[\\w-+]+)*@(?:[\\w-]+\\.)+[a-zA-Z]{2,7}");
		Matcher matcher = email.matcher(text);
		while(matcher.find()){
			System.out.println(matcher.group());
		}
	}

}
