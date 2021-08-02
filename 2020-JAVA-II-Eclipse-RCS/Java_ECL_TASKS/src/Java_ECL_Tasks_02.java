import java.util.Scanner;

public class Java_ECL_Tasks_02 {

	public static void main(String[] args) {
		

		Scanner sc = new Scanner(System.in);

		System.out.print("Ievadi skaitli A   ");
		double A = sc.nextDouble();
		System.out.print("Ievadi skaitli B   ");
		double B = sc.nextDouble();
		System.out.print("Ievadi skaitli C   ");
		double C = sc.nextDouble();
		
		sc.close();
		
		System.out.println("Skaitļu A, B un C vidējā vērtība ir " + ((A + B + C) / 3));

	}

}
