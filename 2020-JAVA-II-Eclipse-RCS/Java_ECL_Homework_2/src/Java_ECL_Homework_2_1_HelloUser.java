import java.util.ArrayList;
import java.util.Scanner;

public class Java_ECL_Homework_2_1_HelloUser {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.print("Ievadi, kā Tevi sauc?   ");
		String name = sc.nextLine();
		sc.close();
		name = name.toUpperCase() + " ";

		ArrayList<String> nameList = new ArrayList<String>();
		String tempName = "";

		for (int i = 0; i < name.length(); i++) {
			if (name.substring(i, i + 1).equals(" ")) {
				if (!tempName.isEmpty()) {
					// continue; - vai vajag šo continue? vai ir komanda isNotEmpty?
					nameList.add(tempName);
				} 
				tempName = "";
			} else {
				tempName = tempName + name.substring(i, i + 1);
			}
		}

		if (nameList.size() > 0) {
			tempName = nameList.get(0).substring(0, 1) + nameList.get(0).substring(1).toLowerCase();
			nameList.set(0, tempName);
		}

		for (int i = 0; i < nameList.size(); i++) {
			System.out.println("'" + nameList.get(i) + "'");
		}

	}

}
