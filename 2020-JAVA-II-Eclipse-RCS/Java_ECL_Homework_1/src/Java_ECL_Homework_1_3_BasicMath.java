import java.util.Scanner;

public class Java_ECL_Homework_1_3_BasicMath {

	public static void main(String[] args) {
	

		Scanner sc = new Scanner(System.in);

		System.out.print("Ievadi veselu skaitli!   ");
		int A = sc.nextInt();
		System.out.print("Ievadi decimālskaitli!   ");
		double B = sc.nextDouble();
		
		sc.close();

		System.out.println("Skaitļu A un B summa ir " + (A + B));
		System.out.println("Skaitļu A un B starpība ir " + (A - B));
		System.out.println("Skaitļu A un B dalījums ir " + (A / B));
		System.out.println("Skaitļu A un B reizinājums ir " + (A * B));
		System.out.println("Skaitļu A un B summas kvadrāts ir " + ((A + B) * (A + B)));

	}

}
