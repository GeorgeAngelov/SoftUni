package point;
import java.util.Scanner;
import java.lang.Integer;

public class DecimalToHexidecimal {

	public static void main(String[] args) {
		Scanner in= new Scanner(System.in);
		int num = in.nextInt();
		in.close();
		String numHex = Integer.toHexString(num);
		System.out.println(numHex);
		
	}

}
