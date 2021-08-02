
public class Java_ECL_Tasks_14_arr_0 {

	public static void main(String[] args) {

		int[] arr = new int[] { 0, 4, 0, 7, 8, 9, 0, 1 };
		int counter = 0;
		int toMove =0;
		for (int i = 0; i < arr.length-counter;) {
			if (arr[i]==toMove){
                for (int j=i+1; j<arr.length; j++){
                    arr[j-1] = arr[j];
                }
                arr[arr.length-1] = toMove;
                counter++;
            } else {
            	i++;
            }
				}			

		arrPrint(arr);

	}

	public static void arrPrint(int arr[]) {

		System.out.print("[ ");
		for (int i = 0; i < arr.length - 1; i++) {
			System.out.print(arr[i] + ", ");
		}
		System.out.println(arr[arr.length - 1] + " ]");

	}

}
