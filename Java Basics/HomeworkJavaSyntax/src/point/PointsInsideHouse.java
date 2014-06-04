package point;

import java.util.Scanner;

public class PointsInsideHouse {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		String arr[] = input.split(" ");
		in.close();
		double x = Double.parseDouble(arr[0]);
		double y = Double.parseDouble(arr[1]);
		double line1 = (5*(y-8.5)+5*(x-12.5));//-(outside)
		double line2 = (-5 * (y - 8.5) +5 * (x - 22.5));//+(outside)
		
		
		if(y>13.5){
			System.out.println("Outside");
		}
		else if (x<12.5 || x>22.5){
			System.out.println("Outside");
		}
		else if(x>17.5 && x<20 && y>8.5){
			System.out.println("Outside");
		}
		else if(line1<=0 && line2>=0){
			System.out.println("Outside");
		}
		else{
			System.out.println("Inside");
		}
	}

}
