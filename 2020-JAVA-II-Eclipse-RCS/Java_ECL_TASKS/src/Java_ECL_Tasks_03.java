import java.util.Scanner;

public class Java_ECL_Tasks_03 {

	public static void main(String[] args) {
		

		Scanner sc = new Scanner(System.in);

		System.out.print("Ievadi skaitli A   ");
		double A = sc.nextDouble();
		System.out.print("Ievadi skaitli B   ");
		double B = sc.nextDouble();
		
		sc.close();

		if ((A + B) < 10 || (A + B) > 19) {
			System.out.println("Skaitļu A un B summa ir " + (A + B));
		} else {
			System.out.println("Skaitļu A un B summa ir robežās 10-19 un tā nav atļauta. IZVADE 20!");
		}

	}

}
