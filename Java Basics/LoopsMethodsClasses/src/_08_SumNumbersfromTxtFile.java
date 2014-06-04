import java.io.*;

public class _08_SumNumbersfromTxtFile {

	public static void main(String[] args) {
		try{
			FileInputStream fstream = new FileInputStream("Input.txt");
			DataInputStream in = new DataInputStream(fstream);
			BufferedReader bf = new BufferedReader(new InputStreamReader(in));
			String currString;
			int sum =0;
			
			while((currString = bf.readLine()) != null){
				System.out.println(currString);
				sum = sum + Integer.parseInt(currString);
			}
			in.close();
			System.out.println(sum);
		}catch(Exception e){
			System.out.println("Error: "+e.getMessage());
		}

	}

}
