import java.util.Random;
import java.util.Scanner;

public class Java_ECL_Homework_3_3_SortArray2D {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		int masIzm;
		do {
			System.out.print("Ievadi masīva izmēru robežās no 10 līdz 20!   ");
			masIzm = sc.nextInt();
		} while (masIzm < 10 || masIzm > 20);
		sc.close();

		Random rnd = new Random();

		int[][] arr2D = new int[masIzm][];

		for (int i = 0; i < arr2D.length; i++) {
			int r = rnd.nextInt(41) + 10;
			arr2D[i] = new int[r];
		}

		for (int i = 0; i < arr2D.length; i++) {
			for (int j = 0; j < arr2D[i].length; j++) {
				int r = rnd.nextInt(900) + 100;
				arr2D[i][j] = r;
			}
		}

		arr2DPrint(arr2D);
		
		System.out.println();
		System.out.println();
		System.out.println("Sakārtotie masīvi!");
		System.out.println();

		arr2DPrint(sortArr2D(arr2D));
		
		System.out.println();
		
		

	}
	
	public static double averageArr2D(int arr2D[][], int arrNumber) {
		
		int sum = 0;
		double average = 0;
			for (int i = 0; i<arr2D[arrNumber].length; i++) {
				sum = sum + arr2D[arrNumber][i];
			average = sum / (double) arr2D[arrNumber].length;
			
		}
			return average;
		
	}

	public static int[][] sortArr2D(int arr2D[][]) {

		for (int i = 0; i < arr2D.length; i++) {
			for (int j = 0; j < arr2D[i].length; j++) {
				for (int k = 0; k < arr2D[i].length; k++) {
					if (arr2D[i][j] > arr2D[i][k]) {
						int temp = arr2D[i][j];
						arr2D[i][j] = arr2D[i][k];
						arr2D[i][k] = temp;
					}
				}
			}
		}

		return arr2D;
	}
	
	
	public static int[][] sortArr2DbyAverage(int arr2D[][]) { //pabeigt kārtot pēc vidējās vērtības

		for (int i = 0; i < arr2D.length; i++) {
			for (int j = 0; j < arr2D[i].length; j++) {
				if (averageArr2D(arr2D, i) < averageArr2D(arr2D, j)) {
						int[] temp = arr2D[i];
						arr2D[i] = arr2D[j];
						arr2D[j] = temp;
				
				}
			}
		}
		/*
		 * for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr.length; j++) {
				if (arr[i] < arr[j]) {
					int temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
				}
			}
		}
		*/

		return arr2D;
	}
	

	public static void arr2DPrint(int arr2D[][]) {

		for (int i = 0; i < arr2D.length; i++) {
			System.out.print("[ ");
			for (int j = 0; j < arr2D[i].length - 1; j++) {
				System.out.print(arr2D[i][j] + ", ");
			}
			System.out.println(arr2D[i][arr2D[i].length - 1] + " ]");
			System.out.println("Masīva "+ i + " average = " +averageArr2D(arr2D, i));
			System.out.println();

		}
	}
}
