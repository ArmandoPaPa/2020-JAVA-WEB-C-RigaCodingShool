import java.util.Scanner;

public class Java_ECL_Tasks_01 {

	public static void main(String[] args) {
		

		Scanner sc = new Scanner(System.in);

		System.out.print("Ievadi veselo skaitli A   ");
		int A = sc.nextInt();
		System.out.print("Ievadi veselo skaitli B   ");
		int B = sc.nextInt();
		
		sc.close();

		System.out.println("Skaitļu A un B summa ir " + (A + B));
	}

}
