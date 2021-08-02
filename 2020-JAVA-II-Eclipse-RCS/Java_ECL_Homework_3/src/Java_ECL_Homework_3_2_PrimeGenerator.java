import java.util.Scanner;

public class Java_ECL_Homework_3_2_PrimeGenerator {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		int n;

		do {
			System.out.print("Ievadi, cik (0-100) pirmskaitļus Tu vēlies ģenerēt!    ");
			n = sc.nextInt();
		} while (n < 0 || n > 100);

		sc.close();

		if (n == 0) {
			System.out.println("Tu ievadīji 0-li, mums nav, ko Tev izvadīt!");
		} else {
			arrPrint(primeGenerator(n));
		}
	}

	public static int[] primeGenerator(int n) {

		int[] primes = new int[n];

		switch (n) {
		case 0:
			return primes;

		case 1:
			primes[0] = 1;
			return primes;

		case 2:
			primes[0] = 1;
			primes[1] = 2;
			return primes;

		case 3:
			primes[0] = 1;
			primes[1] = 2;
			primes[2] = 3;
			return primes;

		default:
			primes[0] = 1;
			primes[1] = 2;
			primes[2] = 3;

			int j = 1;
			for (int i = 3; i < primes.length; i++) {
				if (i % 2 != 0) {
					primes[i] = 6 * j - 1;
				} else {
					primes[i] = 6 * j + 1;
					j++;
				}
			}

			return primes;

		}
	}

	public static void arrPrint(int arr[]) {

		for (int i = 0; i < arr.length - 1; i++) {
			System.out.print(arr[i] + ", ");
		}
		System.out.println(arr[arr.length - 1]);

	}
}
