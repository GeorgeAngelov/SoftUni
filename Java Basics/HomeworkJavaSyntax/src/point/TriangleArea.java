package point;

import java.util.Scanner;

public class TriangleArea {	
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		System.out.println("Enter point 1: ");
		int x=in.nextInt();
		int y=in.nextInt();
		Point A = new Point(x, y);
		
		System.out.println("Enter point 2: ");
		x=in.nextInt();
		y=in.nextInt();
		Point B = new Point(x, y);
		
		System.out.println("Enter point 3:");
		x=in.nextInt();
		y=in.nextInt();
		Point C = new Point(x, y);
		
		in.close();
		
		int Area = (A.x*(B.y-C.y)+B.x*(C.y-A.y)+C.x*(A.y-B.y))/2;
		if (Area<0){
			Area=Area*(-1);
		}
		System.out.println(Area);
	}
}
