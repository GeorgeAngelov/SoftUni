
public class product implements Comparable<product>{
	private String name;
	private double price;
	
	public product(String name, double price){
		this.price = price;
		this.name = name;
	}
	public String getName(){
		return name;
	}
	public double getPrice(){
		return price;
	}
	
	public int compareTo(product compare){
		double otherPrice = ((product) compare).getPrice();
		
		if(this.price>otherPrice){
			return 1;
		}
			else if(this.price==otherPrice){
				return 0;
			}
		return -1;
	}
}
