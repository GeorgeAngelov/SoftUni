import java.util.Scanner;

public class _05_AngleUnitConverter {
	
	public static void main(String[] args) {
		
		String mesure;
		double value;
		
		Scanner in = new Scanner(System.in);
		int numbQueries = in.nextInt();
		for(int i=0;i<numbQueries;i++){
			value = in.nextDouble();
			mesure = in.next();
			switch(mesure){
				case "deg":calcToRad(value);break;
				case "rad": calcToDeg(value);break;
			}
		}
		
	}

	private static void calcToDeg(double value) {
		double converted = Math.toDegrees(value);
		System.out.printf("%.6f"+"deg\n",converted);
	}

	private static void calcToRad(double value) {
		double converted = Math.toRadians(value);
		System.out.printf("%.6f"+"rad\n",converted);
	}	
}
