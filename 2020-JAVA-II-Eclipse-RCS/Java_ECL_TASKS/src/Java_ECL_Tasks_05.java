import java.util.Scanner;

public class Java_ECL_Tasks_05 {

	public static void main(String[] args) {
		

		Scanner sc = new Scanner(System.in);

		System.out.print("Ievadi skaitli A   ");
		double A = sc.nextDouble();
		System.out.print("Ievadi skaitli B   ");
		double B = sc.nextDouble();
		System.out.print("Ievadi skaitli C   ");
		double C = sc.nextDouble();
		
		sc.close();

		double summa = 0;

		if (A != B && A != C && B != C) {
			summa = A + B + C;
			System.out.println("Ievadītie skaitļi nav vienādi un to summa ir " + summa);
		} else if (A == B && A == C && B == C) {
			System.out.println("Visi ievadītie skaitļi ir vienādi! Izvade = " + summa);
		} else if (A == B) {
			summa = C;
			System.out.println("Divi skaitļi ir vienādi. Izvade = " + summa);
		} else if (A == C) {
			summa = B;
			System.out.println("Divi skaitļi ir vienādi. Izvade = " + summa);
		} else if (B == C) {
			summa = A;
			System.out.println("Divi skaitļi ir vienādi. Izvade = " + summa);
		}

	}

}
