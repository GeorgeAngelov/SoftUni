import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;


public class _04_Orders {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = Integer.parseInt(in.nextLine());
		
		String[] ordersArray = new String[n];
		Map<String,TreeMap<String,Integer>> orders = new LinkedHashMap<>(); 

		for (int i = 0; i < ordersArray.length; i++) {
			ordersArray[i]=in.nextLine();
			String[] temp = ordersArray[i].split(" ");
			
			String drink = temp[2];
			String name = temp[0];
			int count = Integer.parseInt(temp[1]);
			
			if(orders.containsKey(drink) && !orders.get(drink).containsKey(name) ){ //If drink already exists and name doesn`t
				orders.get(drink).put(name, count);
			}else if(orders.get(drink).containsKey(name)){ //If drink already exists and Name already exists
				int tempCount = orders.get(drink).get(name);
				orders.get(drink).put(name, tempCount+count);
			}else if(!orders.containsKey(drink)){ //If drink has no record
				orders.put(drink,new TreeMap<String,Integer>());
				orders.get(drink).put(name, count);
			}
		}
		for (String drink : orders.keySet()) {
			System.out.print(drink+": ");
			TreeMap<String,Integer> amounts = orders.get(drink);
			boolean first = true;
			for (Map.Entry<String, Integer> pair : amounts.entrySet()) {
				if (!first) {
					System.out.print(", ");
				}
				first = false;
				String customer = pair.getKey();
				int amount = pair.getValue();
				System.out.print(customer + " " + amount);
			}
			System.out.println();
		}
	}

}
