import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;


public class _06_RandomHandsOf5Cards {
	
	private static void printCard(int number) {
		if(number<11){
			System.out.print(number);
		}
		else{
			switch(number){
				case 11:System.out.print("J");break;
				case 12:System.out.print("Q");break;
				case 13:System.out.print("K");break;
				case 14:System.out.print("A");break;
			}
		}
	}

	public static void main(String[] args) {
		ArrayList<String> cardSuit = new ArrayList<String>();
		cardSuit.add('♥'+" ");
		cardSuit.add('♦'+" ");
		cardSuit.add('♠'+" ");
		cardSuit.add('♣'+" ");
		
		int card;
		int suit;
		Random random = new Random();
		Scanner in = new Scanner(System.in);
		int numbOfHands = in.nextInt();
		for (int i = 0; i < numbOfHands; i++) {
			for (int j = 0; j < 5; j++) {
				card = 2+(int)(Math.random()*((14 -5) +1));
				suit = random.nextInt(cardSuit.size());
				printCard(card);
				System.out.print(cardSuit.get(suit)+" ");
			}
		System.out.println();
		}
	}
}
