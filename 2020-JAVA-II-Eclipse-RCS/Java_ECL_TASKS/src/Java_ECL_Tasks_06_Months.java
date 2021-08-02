import java.util.Scanner;

public class Java_ECL_Tasks_06_Months {

	public static void main(String[] args) {
		

		Scanner sc = new Scanner(System.in);

		System.out.print("Ievadi mēnesi ar skaitli!   ");
		int menesis = sc.nextInt();
		
		sc.close();

		if (menesis == 1 || menesis == 2 || menesis == 3 || menesis == 4 || menesis == 5 || menesis == 6 || menesis == 7
				|| menesis == 8 || menesis == 9 || menesis == 10 || menesis == 11 || menesis == 12) {
			switch (menesis) {
			case 1:
				System.out.println("Tevis ievadītais mēnesis ir JANVĀRIS");
				break;
			case 2:
				System.out.println("Tevis ievadītais mēnesis ir FEBRUĀRIS");
				break;
			case 3:
				System.out.println("Tevis ievadītais mēnesis ir MARTS");
				break;
			case 4:
				System.out.println("Tevis ievadītais mēnesis ir APRĪLIS");
				break;
			case 5:
				System.out.println("Tevis ievadītais mēnesis ir MAIJS");
				break;
			case 6:
				System.out.println("Tevis ievadītais mēnesis ir JŪNIJS");
				break;
			case 7:
				System.out.println("Tevis ievadītais mēnesis ir JŪLIJS");
				break;
			case 8:
				System.out.println("Tevis ievadītais mēnesis ir AUGUSTS");
				break;
			case 9:
				System.out.println("Tevis ievadītais mēnesis ir SEPTEMBRIS");
				break;
			case 10:
				System.out.println("Tevis ievadītais mēnesis ir OKTOBRIS");
				break;
			case 11:
				System.out.println("Tevis ievadītais mēnesis ir NOVEMBRIS");
				break;
			case 12:
				System.out.println("Tevis ievadītais mēnesis ir DECEMBRIS");
				break;
			}

		} else {
			System.out.println("Tu mēnesi ievadīji nepareizi. Tāda " + menesis + " mēneša nav!");
		}

	}

}
