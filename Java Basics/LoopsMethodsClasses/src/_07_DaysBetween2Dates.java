import java.util.Scanner;

public class _07_DaysBetween2Dates {

	public static void main(String[] args) {
		
		Scanner in = new Scanner(System.in);
		String firstDate = in.nextLine();
		String secDate = in.nextLine();
		String[] split1 = firstDate.split("-");
		String[] split2 = secDate.split("-");
		
		int days1 = Integer.parseInt(split1[0]);
		int months1 = Integer.parseInt(split1[1]);
		int years1 = Integer.parseInt(split1[2]);
		
		int days2 = Integer.parseInt(split2[0]);
		int months2 = Integer.parseInt(split2[1]);
		int years2 = Integer.parseInt(split2[2]);
		
		int yearsDiff = years2 - years1;
		int monthsDiff = months2 - months1;
		int daysDiff = days2 - days1;
		
		int totalDaysDiff = yearsDiff*365 + monthsDiff*31 + daysDiff;
		System.out.println(totalDaysDiff);
	}

}
