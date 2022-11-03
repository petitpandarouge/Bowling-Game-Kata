# Bowling game Kata

## Règles du bowling
* Le jeu se déroule en 10 tours.
* A chaque tour, le joueur a 2 lancés pour faire tomber jusqu'à 10 quilles
* Le score d'un tour est le nombre total de quilles renversées, plus des bonus pour les spares et les strikes.
* Un spare est quand le joueur renverse les 10 quilles en 2 lancés lors d'un tour => Le bonus pour un spare est le nombre de quilles renversées par le prochain lancé.
* Un strike est quand le joueur renverse les 10 quilles lors du premier lancé de son tour => Le bonus pour un strike est le nombre de quilles renversées par les deux prochains lancés
* En cas de strike, le tour est terminé
* Dans le dixième tour, un joueur qui réalise un spare ou 2 strikes est autorisé à effectuer un troisième lancé. Cependant aucun bonus de spare ou de strike n'est accordé au dixième tour.

## Exemples de parties
* La partie à vide (aucune quille tombée) a un score total de 0 points
* La partie full spare (spare à tous les carreaux + 5 quilles au 21ème lancé) à un score de 150 points
* La partie parfaite (12 strikes) a un score total de 300 points

## Objectifs
Ecrire une classe Bowling possédant à minima 1 méthode :
* score() qui retourne le score de la partie

## Outils d'aide au calcul de score
[bowling-score-calculator](https://www.sportcalculators.com/bowling-score-calculator)
