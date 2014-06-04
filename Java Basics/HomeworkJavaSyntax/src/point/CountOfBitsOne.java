package point;

import java.util.Scanner;

public class CountOfBitsOne {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int Num = in.nextInt();
		System.out.println(Integer.bitCount(Num));
	}

}
