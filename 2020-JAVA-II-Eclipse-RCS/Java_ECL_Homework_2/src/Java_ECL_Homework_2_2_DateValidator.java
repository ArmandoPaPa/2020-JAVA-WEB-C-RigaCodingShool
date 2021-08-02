import java.util.Scanner;

enum menesi {
	janvāris, februāris, marts, aprīlis, maijs, jūnijs, jūlijs, augusts, septembris, oktobris, novembris, decembris
}

public class Java_ECL_Homework_2_2_DateValidator {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.print("Ievadi gadu ar cipariem -   ");
		int gads = sc.nextInt();

		int menesis;
		do {
			System.out.print("Ievadi mēnesi ar cipariem formātā - mm -   ");
			menesis = sc.nextInt();
		} while (!monthCheck(menesis));

		int diena;
		do {
			System.out.print("Ievadi dienu (datumu) ar cipariem formātā - dd -   ");
			diena = sc.nextInt();
		} while (!dayCheck(diena, menesis, gads));
		
		sc.close();
		
		System.out.println(); // Vnk, lai būtu rindas atstarpe!
		System.out.println(diena + ". " + menesi.values()[menesis-1] + ", " + gads);
		

	}

	public static boolean monthCheck(int menesis) {

		if (menesis >= 1 && menesis <= 12) {
			return true;
		} else {
			System.out.println("Tu ievadīji mēnesi nepareizi!");
			return false;
		}

	}

	public static boolean dayCheck(int diena, int menesis, int gads) {
		switch (menesis) {
		case 1:
			if (diena >= 1 && diena <= 31) {
				return true;
			} else {
				System.out.println("Tevis ievadītajā mēnesī nav tādas dienas (datuma)!");
				return false;
			}
		case 2:
			if (gads % 4 == 0) {
				if (gads % 100 == 0 && gads % 400 != 0 && (diena >= 1 && diena <= 28)) {
					return true;
				} else if (diena >= 1 && diena <= 29) {
					return true;
				} else {
					System.out.println("Tevis ievadītajā mēnesī nav tādas dienas (datuma)!");
					return false;
				}
			} else if (diena >= 1 && diena <= 28) {
				return true;
			} else {
				System.out.println("Tevis ievadītajā mēnesī nav tādas dienas (datuma)!");
				return false;
			}

		case 3:
			if (diena >= 1 && diena <= 31) {
				return true;
			} else {
				System.out.println("Tevis ievadītajā mēnesī nav tādas dienas (datuma)!");
				return false;
			}

		case 4:
			if (diena >= 1 && diena <= 30) {
				return true;
			} else {
				System.out.println("Tevis ievadītajā mēnesī nav tādas dienas (datuma)!");
				return false;
			}

		case 5:
			if (diena >= 1 && diena <= 31) {
				return true;
			} else {
				System.out.println("Tevis ievadītajā mēnesī nav tādas dienas (datuma)!");
				return false;
			}

		case 6:
			if (diena >= 1 && diena <= 30) {
				return true;
			} else {
				System.out.println("Tevis ievadītajā mēnesī nav tādas dienas (datuma)!");
				return false;
			}

		case 7:
			if (diena >= 1 && diena <= 31) {
				return true;
			} else {
				System.out.println("Tevis ievadītajā mēnesī nav tādas dienas (datuma)!");
				return false;
			}

		case 8:
			if (diena >= 1 && diena <= 31) {
				return true;
			} else {
				System.out.println("Tevis ievadītajā mēnesī nav tādas dienas (datuma)!");
				return false;
			}

		case 9:
			if (diena >= 1 && diena <= 30) {
				return true;
			} else {
				System.out.println("Tevis ievadītajā mēnesī nav tādas dienas (datuma)!");
				return false;
			}

		case 10:
			if (diena >= 1 && diena <= 31) {
				return true;
			} else {
				System.out.println("Tevis ievadītajā mēnesī nav tādas dienas (datuma)!");
				return false;
			}

		case 11:
			if (diena >= 1 && diena <= 30) {
				return true;
			} else {
				System.out.println("Tevis ievadītajā mēnesī nav tādas dienas (datuma)!");
				return false;
			}

		case 12:
			if (diena >= 1 && diena <= 31) {
				return true;
			} else {
				System.out.println("Tevis ievadītajā mēnesī nav tādas dienas (datuma)!");
				return false;
			}

		default:
			return false; // vai šo vispār vajag?
		}
	}
}
