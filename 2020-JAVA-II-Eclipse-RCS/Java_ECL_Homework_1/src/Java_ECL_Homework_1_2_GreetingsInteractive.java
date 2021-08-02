import java.util.Scanner;

public class Java_ECL_Homework_1_2_GreetingsInteractive {

	public static void main(String[] args) {
		

		Scanner sc = new Scanner(System.in);

		System.out.println("Ievadi savu vārdu!");
		String NAME = sc.nextLine();

		System.out.println("Ievadi savu vecumu pilnos gados!");
		int AGE = sc.nextInt();
		
		sc.close();

		System.out.println("Sveiki, mani sauc " + NAME + " esmu " + AGE + " gadus jauns/jauna!");
	}

}
