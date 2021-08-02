import java.util.Random;
import java.util.Scanner;

public class Java_ECL_Homework_3_1_SortArray {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		int masIzm;
		do {
			System.out.print("Ievadi masīva izmēru robežās no 20 līdz 40!   ");
			masIzm = sc.nextInt();
		} while (masIzm < 20 || masIzm > 40);
		sc.close();

		int[] arr = new int[masIzm];
		Random rnd = new Random();

		for (int i = 0; i < arr.length; i++) {
			arr[i] = rnd.nextInt(90) + 10;
		}

		arrPrint(arr);

		arrPrint(sortArr(arr));

	}

	public static int[] sortArr(int arr[]) {

		
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr.length; j++) {
				if (arr[i] < arr[j]) {
					int temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
				}
			}
		}

		return arr;
	}

	public static void arrPrint(int arr[]) {

		System.out.print("[ ");
		for (int i = 0; i < arr.length - 1; i++) {
			System.out.print(arr[i] + ", ");
		}
		System.out.println(arr[arr.length - 1] + " ]");

	}

}
