/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_reizinasana_19_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class JAVA_MD_Reizinasana_19_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        System.out.println("Tevis ievadita skaitla reizinajums ar 2 ir " + Reizinajums());

    }

    static Double Reizinajums() {

        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi jebkuru skaitli, tas tiks sareizinats ar 2");

        Double a = sc.nextDouble();

        return a * 2;

    }

}
