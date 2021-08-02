import java.util.Scanner;

public class Java_ECL_Tasks_08 {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.print("Ievadi veselu skaitli - pozitīvu vai negatīvu, bet VESELU!   ");
		int skaitlis = sc.nextInt();

		sc.close();

		for (int i = Math.min(skaitlis, 0); i < Math.max(skaitlis, 0); i++) {
			System.out.print(i + ", ");
		}

		System.out.println(Math.max(skaitlis, 0));

		caurIF(skaitlis);

	}

	public static void caurIF(int skaitlis) {

		if (skaitlis > 0) {
			for (int i = 0; i <= skaitlis; i++) {
				System.out.print(i + " ");
			}
		} else if (skaitlis < 0) {
			for (int i = skaitlis; i <= 0; i++) {
				System.out.print(i + " ");
			}
		} else {
			System.out.print("Tu ievadīji 0!");
		}

	}

}
