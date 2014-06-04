import java.io.*;
import java.util.*;
public class _10_OrderOfProducts {


	public static void main(String[] args) {
		ArrayList<product> Products = new ArrayList<product>();
		double sum=0;
		try{
			String currString;
			
			readProducts(Products);
			
			FileInputStream fstream2 = new FileInputStream("Order.txt");
			DataInputStream in2 = new DataInputStream(fstream2);
			BufferedReader bf2 = new BufferedReader(new InputStreamReader(in2));
			
			sum = calcTotal(Products, sum, bf2);
			
			in2.close();
			exportTotal(sum);
		}catch(IOException ex){
			System.out.println("Error: "+ex);
		}
	}

	private static void exportTotal(double sum)
			throws UnsupportedEncodingException, FileNotFoundException,
			IOException {
		String total = Double.toString(sum);
		Writer writer = null;
		writer = new BufferedWriter(new OutputStreamWriter(
				new FileOutputStream("Output2.txt"),"utf-8"));
		writer.write(total);
		writer.close();
	}

	private static double calcTotal(ArrayList<product> Products, double sum,
			BufferedReader bf2) throws IOException {
		String currString;
		while((currString = bf2.readLine())!=null){
			String[] split = currString.split(" ");
			for(product someProduct : Products){
				if(someProduct.getName().equals(split[1])){
					sum = sum+someProduct.getPrice()*Double.parseDouble(split[0]);
				}
			}
		}
		return sum;
	}

	private static void readProducts(ArrayList<product> Products)
			throws FileNotFoundException, IOException {
		FileInputStream fstream = new FileInputStream("Input_9.txt");
		DataInputStream in = new DataInputStream(fstream);
		BufferedReader bf = new BufferedReader(new InputStreamReader(in));
		String currString=null;
		while((currString = bf.readLine()) != null){
			String[] split =currString.split(" ");
			Products.add(new product(split[0],Double.parseDouble(split[1])));
		}
		in.close();
	}

}