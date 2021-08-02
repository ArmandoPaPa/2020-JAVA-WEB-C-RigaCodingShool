import java.util.Scanner;

public class Java_ECL_Tasks_04_hiHellohi {

	public static void main(String[] args) {
		

		Scanner sc = new Scanner(System.in);

		System.out.print("Ievadi 1.Tekstu (1.vārdu)!   ");
		String pirmaisVards = sc.nextLine();
		System.out.print("Ievadi 2.Tekstu (2.vārdu)!   ");
		String otraisVards = sc.nextLine();
		
		sc.close();

		if (pirmaisVards.length() >= otraisVards.length()) {
			System.out.println(otraisVards + pirmaisVards + otraisVards);
		} else {
			System.out.println(pirmaisVards + otraisVards + pirmaisVards);
		}

	}

}
