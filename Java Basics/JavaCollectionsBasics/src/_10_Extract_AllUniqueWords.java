import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;


public class _10_Extract_AllUniqueWords {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String[] split = in.nextLine().toLowerCase()
					.split("([().,!?:;'\"-]|\\s)+");
		Set<String> set = new TreeSet<>();
			for (String word : split) {
				set.add(word);
			}
		for (String word : set) {
			System.out.print(word+" ");
		}	
	}

}
