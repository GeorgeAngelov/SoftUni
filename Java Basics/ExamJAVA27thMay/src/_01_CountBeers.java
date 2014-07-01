import java.util.Scanner;

public class _01_CountBeers {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int totalBeers = 0;
		
		while(true){
			String input = in.nextLine();
			if(input.equals("End")){
				break;
			}
			String[] order = input.split(" ");
			int beers = Integer.parseInt(order[0]);
			if (order[1].equals("stacks")) {
				beers *= 20;
			}
			totalBeers+=beers;
		}
		System.out.printf("%d stacks + %d beers",totalBeers/20,totalBeers%20);
	}
}
