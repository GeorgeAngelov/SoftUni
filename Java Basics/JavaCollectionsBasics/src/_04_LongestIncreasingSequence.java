import java.util.Scanner;

public class _04_LongestIncreasingSequence {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		String[] split = input.split(" ");
		int[] numbers= new int[split.length];
		
		for (int i = 0; i < split.length; i++) {
			numbers[i] = Integer.parseInt(split[i]);
		}
		
		int counterTemp = 1;
		int counter = 1;
		int position = 0;
		
		System.out.print(numbers[0]);
		for (int i = 1; i < numbers.length; i++) {
			if(numbers[i] > numbers[i-1]){
				System.out.print(" " + numbers[i]);
				counterTemp++;
		 	}
			else{
				counterTemp=1;
				System.out.println();
				System.out.print(numbers[i]);
			}
			if(counterTemp > counter){
				counter = counterTemp;
				position = i;
			}
		}
		System.out.println();
		System.out.print("Longest: ");
		for (int j = 0; j < counter-1; j++) {
			System.out.print(numbers[position-counter + 1+j]+" ");
		}
		System.out.println(numbers[position]);
	}

}
