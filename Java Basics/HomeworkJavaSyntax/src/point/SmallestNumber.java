package point;
import java.util.Scanner;

public class SmallestNumber {

	public static void main(String[] args) {
		Scanner in=new Scanner(System.in);
		double smnum=0.0;
		double a = in.nextInt();
		double b = in.nextInt();
		double c= in.nextInt();
		in.close();
		if (a>b){
			smnum = b;
		}
		else if(b>a){
			smnum = a;
		}
		else if (a==b){
			smnum = a;
		}
		if (smnum>c) {
			smnum=c;
		}
		System.out.println(smnum);
	}

}
