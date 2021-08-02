import java.util.Scanner;

public class Java_ECL_Homework_1_4_ConditionalMath {

	public static void main(String[] args) {
		

		Scanner sc = new Scanner(System.in);

		System.out.print("Ievadi savu vārdu!   ");
		String vards = sc.nextLine();
		System.out.println("Ievadi veselo skaitli A   ");
		int A = sc.nextInt();
		System.out.println("Ievadi veselo skaitli B   ");
		int B = sc.nextInt();
		
		sc.close();

		if (A > B) {
			System.out.println("Skaitlis " + A + " ir lielāks par " + B);
		} else if (B > A) {
			System.out.println("Skaitlis " + B + " ir lielāks par " + A);
		} else {
			System.out.println("Skaitlis " + A + " un " + B + " ir vienādi!");
		}

		System.out.println("Vārdā " + vards + " ir " + vards.length() + " burti!");

		if ((A + B) > vards.length()) {
			System.out.println("Skaitļu A un B summa ir " + (A + B) + " un tā ir lielāka par vārda " + vards
					+ " garumu, " + vards.length() + " burti.");
		}

		else if ((A + B) < vards.length()) {
			System.out.println("Skaitļu A un B summa ir " + (A + B) + " un tā ir mazāka par vārda " + vards
					+ " garumu, " + vards.length() + " burti.");
		} else {
			System.out.println("Skaitļu A un B summa ir " + (A + B) + " un tā ir vienāda ar vārda " + vards
					+ " garumu, " + vards.length() + " burti.");
		}
	}
}
