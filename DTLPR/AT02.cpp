#include <iostream>

using namespace std;

int main() {
    int alturaA, alturaB, alturaC;

    cout << "Digite tres alturas entre 150 e 220 cm:\n";
    cin >> alturaA >> alturaB >> alturaC;

    if (alturaA < 150 || alturaA > 220 ||
        alturaB < 150 || alturaB > 220 ||
        alturaC < 150 || alturaC > 220) {

        cout << "Valores invalidos.\n";
        return 1;
    }

    if ((alturaA > alturaB && alturaA < alturaC) || (alturaA < alturaB && alturaA > alturaC)) {
        cout << "A altura intermediaria e: " << alturaA << " cm\n";
    }
    else if ((alturaB > alturaA && alturaB < alturaC) || (alturaB < alturaA && alturaB > alturaC)) {
        cout << "A altura intermediaria e: " << alturaB << " cm\n";
    }
    else {
        cout << "A altura intermediaria e: " << alturaC << " cm\n";
    }

    return 0;
}
