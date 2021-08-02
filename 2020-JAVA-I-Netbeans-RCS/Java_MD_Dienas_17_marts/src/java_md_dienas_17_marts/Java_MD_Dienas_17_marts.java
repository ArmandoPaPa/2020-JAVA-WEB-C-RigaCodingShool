/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_dienas_17_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_Dienas_17_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        System.out.println("DIENAS. Ievadi dienu ar cipariem no 1 lidz 7");

        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();

        System.out.println("Tevis izveleta diena ir - ");
        Dienas(a);

    }

    static int Dienas(int a) {
        switch (a) {
            case 1:
                System.out.println("Pirmdiena");
                break;
            case 2:
                System.out.println("Otrdiena");
                break;
            case 3:
                System.out.println("Tresdiena");
                break;
            case 4:
                System.out.println("Ceturtdiena");
                break;
            case 5:
                System.out.println("Piektdiena");
                break;
            case 6:
                System.out.println("Sestdiena");
                break;
            case 7:
                System.out.println("Svetdiena");
                break;
            default:
                System.out.println("Tevis ievaditais skaitlis nav 1-7. KLUDA!");
                break;
        }
        
        return a;

    }
}
