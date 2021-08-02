import java.util.Scanner;

public class Java_ECL_Tasks_07_Burti {

	public static void main(String[] args) {
	

		Scanner sc = new Scanner(System.in);

		System.out.print("Ievadi kādu burtu no latviešu alfabēta!   ");
		String burts = sc.nextLine();
		burts = burts.toLowerCase();
		
		sc.close();

		if (burts.length() == 1) {
			if (burts.equals("a") || burts.equals("ā") || burts.equals("e") || burts.equals("ē") 
					|| burts.equals("i") || burts.equals("ī") || burts.equals("u") || burts.equals("ū")) {
				System.out.println("Tevis ievadītais burts " + burts + " ir patskanis!");
			} else if (burts.equals("b") || burts.equals("c") || burts.equals("č") 
					|| burts.equals("d") || burts.equals("f") || burts.equals("g")
					|| burts.equals("ģ") || burts.equals("h") || burts.equals("j") 
					|| burts.equals("k") || burts.equals("ķ") || burts.equals("l")
					|| burts.equals("ļ") || burts.equals("m") || burts.equals("n") 
					|| burts.equals("ņ") || burts.equals("p") || burts.equals("r")
					|| burts.equals("s") || burts.equals("š") || burts.equals("t") 
					|| burts.equals("v") || burts.equals("z") || burts.equals("ž")) {
				System.out.println("Tevis ievadītais burts " + burts + " ir līdzskanis!");
			} else if (burts.equals("o")) {
				System.out.println("Tevis ievadītais burts " + burts + " ir patskanis un divskanis!");
			} else {
				System.out.println("Tevis ievadītais burts " + burts + " nav burts vai nav no latviešu alfabēta!");
			}

		} else {
			System.out.println("Tu esi ievadījis vairāk kā vienu burtu/zīmi!");
		}

	}

}
