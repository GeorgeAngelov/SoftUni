import java.util.Scanner;


public class _02_Sequences_OfEqualStrings {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		String[] split = input.split(" ");
		
		for (int i = 0; i < split.length; i++) {
			if(i == 0){
				System.out.print(split[i]+" ");
			}
			else if(split[i].equals(split[i-1])){
				System.out.print(split[i]+" ");
			}
			else {
				System.out.println();
				System.out.print(split[i]+" ");
			}
		}
		
	}

}
