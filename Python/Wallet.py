solde = 200000
historique_transactions = []

while True:
    menu = input("1. Versement 2. Retrait 3. Consultation du solde 4. Historique des transactions 5. Quitter Choisissez une option : ")

    if not menu.isdigit():
        print("Veuillez entrer un numéro valide.")
        continue

    menu = int(menu)

    if menu not in [1, 2, 3, 4, 5]:
        print("Veuillez saisir une option valable.")
        continue

    if menu == 1:
        versement_str = input("Combien souhaitez-vous verser : ")
        if not versement_str.replace('.', '').isdigit() or float(versement_str) <= 0:
            print("Veuillez entrer un montant valide.")
            continue

        versement = float(versement_str)
        solde += versement
        historique_transactions.append(f"Versement de {versement}")
        print("Versement effectué avec succès!")

    if menu == 2:
        retrait_str = input("Combien souhaitez-vous retirer : ")
        if not retrait_str.replace('.', '').isdigit() or float(retrait_str) <= 0:
            print("Veuillez entrer un montant valide.")
            continue

        retrait = float(retrait_str)
        if retrait > solde:
            print("Désolé, votre solde est insuffisant pour ce retrait.")
        else:
            solde -= retrait
            historique_transactions.append(f"Retrait de {retrait}")
            print("Retrait effectué avec succès!")

    if menu == 3:
        print(f"Votre solde est : {solde}")

    if menu == 4:
        print("Historique des transactions :")
        for transaction in historique_transactions:
            print(transaction)

    if menu == 5:
        break
