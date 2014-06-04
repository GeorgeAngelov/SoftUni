
public class _03_FullHouse {
	private static void printSuit(int number) {
		switch(number){
		case 1: System.out.print('♣');break;
		case 2: System.out.print('♦');break;
		case 3: System.out.print('♥');break;
		case 4: System.out.print('♠');break;
		}
		
	}

	private static void printCard(int number) {
		if(number<11){
			System.out.println(number);
		}
		else{
			switch(number){
			case 11: System.out.print("J");break;
			case 12: System.out.print("Q");break;
			case 13: System.out.print("K");break;
			case 14: System.out.print("A");break;
			}
		}
	}

	public static void main(String[] args) {
		int Counter = 0;
		
		for (int threeEqual = 2; threeEqual < 15; threeEqual++) {
			for(int twoEqual = 2; twoEqual<15; twoEqual++ ){
				if(threeEqual != twoEqual){
					for(int firstSuit=1;firstSuit<5;firstSuit++){
						for(int secSuit=firstSuit+1;secSuit<5;secSuit++){
							for(int thirdSuit=secSuit+1;thirdSuit<5;thirdSuit++){
								for(int fourthSuit=1;fourthSuit<5;fourthSuit++){
									for(int fifthSuit=fourthSuit+1;fifthSuit<5;fifthSuit++){
										Counter++;
										printCard(threeEqual);
										printSuit(firstSuit);
										printCard(threeEqual);
										printSuit(secSuit);
										printCard(threeEqual);
										printSuit(thirdSuit);
										printCard(twoEqual);
										printSuit(fourthSuit);
										printCard(twoEqual);
										printSuit(fifthSuit);
										System.out.println();
									}
								}
							}
						}
					}
				}
			}
		}
		System.out.println(Counter);
	}
}
