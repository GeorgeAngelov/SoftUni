package point;
import java.util.Scanner;

public class RectangleArea {

	public static void main(String[] args) {
		int a=0,b=0;
		Scanner in = new Scanner(System.in);
		a = in.nextInt();
		b = in.nextInt();
		in.close();
		int area = a*b;
		System.out.println(area);
	}
}
