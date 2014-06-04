import java.util.Scanner;

public class _01_SymmetricNumbersInRange {
	
	public static boolean checkSymmetricity(int i){
        if (Integer.toString(i).equals(new StringBuilder(Integer.toString(i)).reverse().toString()))
        return true;
    else
        return false;
	}
	
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int firstNum = in.nextInt();
		int secondNum = in.nextInt();
		
		for (int i = firstNum; i <=secondNum; i++) {
			if(checkSymmetricity(i)==true){
				System.out.print(i+" ");
			}
		}
	}
}
