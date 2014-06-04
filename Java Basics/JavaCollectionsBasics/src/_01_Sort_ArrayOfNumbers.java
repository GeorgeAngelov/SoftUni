import java.util.Arrays;
import java.util.Scanner;

public class _01_Sort_ArrayOfNumbers {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int count = in.nextInt();
		int[] numbers = new int[count];
		for (int i = 0; i < count; i++) {
			numbers[i] = in.nextInt();  
		}
		Arrays.sort(numbers);
		for (int i = 0; i < numbers.length; i++) {
			System.out.println(numbers[i]+" ");
		}
	}

}
