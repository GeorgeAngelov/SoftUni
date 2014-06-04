package point;
import java.util.Scanner;
import java.lang.*;

public class FormatingNumbers {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int a = in.nextInt();
		float b = in.nextFloat();
		float c = in.nextFloat();
		in.close();
		String aHex = Integer.toHexString(a).toUpperCase();
		String aBin = String.format("%10s",Integer.toBinaryString(a)).replace(' ','0');
		if (c%1==0) {
			System.out.printf("|%-10s|%s|%10.2f|%-10.0f|",aHex,aBin,b,c);
		}
		else{
			System.out.printf("|%-10s|%s|%10.2f|%-10.3f|",aHex,aBin,b,c);
		}
		
	}

}
