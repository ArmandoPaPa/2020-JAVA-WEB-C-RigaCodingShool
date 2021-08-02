import java.util.Scanner;

public class Java_ECL_Tasks_09 {

	public static void main(String[] args) {
		

		Scanner sc = new Scanner(System.in);

		System.out.print("Ievadi pirmo veselo skaitli!   ");
		int A = sc.nextInt();
		System.out.print("Ievadi otru veselo skaitli!   ");
		int B = sc.nextInt();
		
		sc.close();

		if (A > B) {
			for (int i = B; i < A; i++) {
				if (i % 2 == 0 && i % 3 == 0 && i % 5 != 0) {
					System.out.print(i + " ");
				}
			}
		} else if (B > A) {
			for (int j = A; j < B; j++) {
				if (j % 2 == 0 && j % 3 == 0 && j % 5 != 0) {
					System.out.print(j + " ");
				}
			}
		} else {
			System.out.println("Abi Tevis ievadītie skaitļi ir vienādi!");
		}

	}

}
