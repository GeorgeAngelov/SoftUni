import java.util.Scanner;
import java.util.Arrays;

public class SortArrayOfStrings {

	public static void main(String[] args) {
		Scanner in=new Scanner(System.in);
		int n = in.nextInt();
		String[] Gradove = new String[n];
		for (int j = 0; j < Gradove.length; j++) {
			Gradove[j]=in.next();
		}
		Arrays.sort(Gradove);
		for(String str : Gradove){
			System.out.println(str);
		}
		in.close();
	}
}
