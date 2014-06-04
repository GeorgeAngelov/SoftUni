import java.util.Scanner;


public class _03_Largest_SequenceOfEqualStrings {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		String[] split = input.split(" ");
		
		int counterTemp=1;
		int counter = 1;
		int position = 0;
		
		for (int i = 0; i < split.length-1; i++) {
			if(split[i].equals(split[i+1])){
				counterTemp++;
		 	}
			else{
				counterTemp=1;
			}
			if(counterTemp > counter){
				counter = counterTemp;
				position = i;
			}
		}
		for (int i = 0; i < counter-1; i++) {
			System.out.print(split[position] + " ");
		}
		System.out.println(split[position]);
	}

}
