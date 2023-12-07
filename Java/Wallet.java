import java.util.ArrayList;
import java.util.InputMismatchException;
import java.util.Scanner;

public class Wallet {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double solde = 200000;
        ArrayList<String> historiqueTransactions = new ArrayList<>();

        while (true) {
            try {
                System.out.print("1. Versement 2. Retrait 3. Consultation du solde 4. Historique des transactions 5. Quitter Choisissez une option : ");
                int menu = scanner.nextInt();

                if (!(menu >= 1 && menu <= 5)) {
                    System.out.println("Veuillez saisir une option valable");
                    continue;
                }

                if (menu == 1) {
                    System.out.print("Combien souhaitez-vous verser : ");
                    double versement = scanner.nextDouble();
                    if (isPositiveNumeric(versement)) {
                        solde += versement;
                        historiqueTransactions.add("Versement de " + versement);
                        System.out.println("Versement effectué avec succès !");
                    } else {
                        System.out.println("Veuillez entrer un montant valide.");
                    }
                } else if (menu == 2) {
                    System.out.print("Combien souhaitez-vous retirer : ");
                    double retrait = scanner.nextDouble();
                    if (isPositiveNumeric(retrait)) {
                        if (retrait > solde) {
                            System.out.println("Désolé, votre solde est insuffisant pour ce retrait");
                        } else {
                            solde -= retrait;
                            historiqueTransactions.add("Retrait de " + retrait);
                            System.out.println("Retrait effectué avec succès !");
                        }
                    } else {
                        System.out.println("Veuillez entrer un montant valide.");
                    }
                } else if (menu == 3) {
                    System.out.println("Votre solde est : " + solde);
                } else if (menu == 4) {
                    System.out.println("Historique des transactions :");
                    for (String transaction : historiqueTransactions) {
                        System.out.println(transaction);
                    }
                } else if (menu == 5) {
                    break;
                }
            } catch (InputMismatchException e) {
                System.out.println("Veuillez entrer un numéro valide.");
                scanner.nextLine(); // consume the invalid input
            }
        }
    }

    private static boolean isPositiveNumeric(double value) {
        return value > 0;
    }
}
