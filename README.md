# Genki #

Genki est une application permettant de générer une grille de Sudoku réalisable et de la résoudre soi-même.

Ce programme fut réalisé avec Visual Studio 2015.


## Comment utiliser Genki ? ##

Pour utiliser Genki, il suffit de lancer l'application. Ensuite, la génération d'une grille se fait en cliquant sur le menu "_Genki_" > "_New game_" ou en effécutant la combinaison de touches "_Ctrl_ + _N_".

La génération d'une grille peut être assez longue. En effet, le programme calcul dans un premier temps une grille avec trou de façon aléatoire, puis essaye de la résoudre à l'aide d'un algorithme. Si une solution est généré, la grille est donc valide. Sinon, le programme recommence. Une limite de temps a été fixée à 25 secondes. Si le programme dépasse cette limite, il utilisera une grille déjà calculée.

## Le Mode Debug ##

Compilé en mode Débug, le programme founira à l'utilisateur un nouveau menu "_Debug_". A l'intérieur, vous pouvez y trouver les éléments suivants :
- _Break Now_ : Utilise la method `Debugger.Break();` afin de rentrer en mode déboggage. Cette option a été testé uniquement avec Visual Studio 2015.
- _Print Grid_ : Affiche la grille virtuel ou physique dans la console. La grille virtuel est une grille utilisé dans le programme, tandis que la grille physique est la grille du composant graphique `DataGridView`.
- _Force DVG <- grid_ : Force la copy de la grille virtuel vers la grille physique (voir point au dessus)
- _Solve it_ : C'est **le bouton** que vous utiliserez le plus en mode debug ! Il permet de solutionner la grille en cours en remplacant toutes les cellules vides par une valeur correcte. Une seule case est épargné, vous laissant ainsi le plus facile pour la fin !
- _Set Default Grid_ : Permet de lancer une nouvelle partie en utilisant uniquement la grille pré-calculé. Ce bouton est très utilisé dans des cas de déboggage afin d'éviter d'attendre (au pire) 25 secondes de génération d'une grille aléatoire.

## Les Tests ##

Dans le dossier de la solution, vous trouverez le projet "_GenkiTest_". Il contient la classe "_GenkiTests.cs_" qui permet d'effectuer des tests unitaire à l'aide de `Microsoft.VisualStudio.TestTools.UnitTesting`.