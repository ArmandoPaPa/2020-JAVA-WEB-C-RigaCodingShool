import java.util.Scanner;

public class Java_ECL_Tasks_03_Boolean {

	public static void main(String[] args) {
		

		Scanner sc = new Scanner(System.in);

		System.out.print("Ievadi skaitli!   ");
		double skaitlis = sc.nextDouble();
		
		sc.close();

		System.out.println("Skaitlis ir robežās no 50 līdz 100 " + (skaitlis >= 50 && skaitlis <= 100));
		System.out.println("Skaitlis nav robežās no 50 līdz 100 " + (skaitlis < 50 || skaitlis > 100));
	}

}
