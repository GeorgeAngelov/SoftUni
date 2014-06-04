
import java.io.*;
import java.util.*;
public class _09_ListOfProducts {


	public static void main(String[] args) {
		Writer writer = null;
		ArrayList<product> Products = new ArrayList<product>();
		try{
			FileInputStream fstream = new FileInputStream("Input_9.txt");
			DataInputStream in = new DataInputStream(fstream);
			BufferedReader bf = new BufferedReader(new InputStreamReader(in));
			String currString=null;
			while((currString = bf.readLine()) != null){
				String[] split =currString.split(" ");
				Products.add(new product(split[0],Double.parseDouble(split[1])));
			}
			Collections.sort(Products);
			
			writer = new BufferedWriter(new OutputStreamWriter(
					new FileOutputStream("Output.txt"),"utf-8"));
			for(product someProduct : Products){
				writer.write(someProduct.getName()+" "+someProduct.getPrice()+"\r\n");
			}
			writer.close();
			in.close();
		}catch(IOException ex){
			System.out.println("Error: "+ex);

		}

	}

}
