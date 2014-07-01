import java.util.Scanner;
import java.util.TreeMap;


public class _04_LogsAggregator {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = Integer.parseInt(in.nextLine());
		
		TreeMap<String,TreeMap<String,Integer>> user = new TreeMap<>();
		
		 for (int i = 0; i < n; i++) {
			String[] userInput = in.nextLine().split(" ");
			
			String ip = userInput[0];
			String name = userInput[1];
			int time = Integer.parseInt(userInput[2]);
			
			if (!user.containsKey(name)) { // If user does not exist
				user.put(name, new TreeMap<String,Integer>());
				user.get(name).put(ip, time);
			} else if(user.get(name).containsKey(ip)) { //If Ip already exists
				int tempMinutes = user.get(name).get(ip);
				user.get(name).put(ip, time+tempMinutes);
			}else{ // if User exists but Ip has no record
				user.get(name).put(ip, time);
			}
		}
		 for (String name : user.keySet()) {
			System.out.print(name+": ");
			int totalTime=0;
			for (String ip : user.get(name).keySet()) {
				totalTime += user.get(name).get(ip);
			}
			System.out.print(totalTime+" ");
			System.out.print(user.get(name).keySet());
			System.out.println();
		}
	}

}
