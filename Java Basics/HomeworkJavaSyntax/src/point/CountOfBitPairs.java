package point;
import java.util.Scanner;

public class CountOfBitPairs {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		char[] bitNum =  Integer.toBinaryString(in.nextInt()).toCharArray();
		int count=0;
		int length = bitNum.length;
		for (int i = 0; i < bitNum.length; i++){
				if(bitNum[i]=='1'){
					length = i;
					break;
				}
			}
		for (int i = length; i < bitNum.length; i++) {
			if(i<bitNum.length-1){
				if(bitNum[i]==bitNum[i+1])
					count++;
			}
		}
		 
		System.out.println(count);
	}

}
