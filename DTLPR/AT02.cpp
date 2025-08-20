#include <iostream>   // Biblioteca para entrada e saída (cout, cin, etc.)
#include <string.h>   // Biblioteca para manipulação de strings (não é usada aqui, pode remover)
#include <iomanip>    // Biblioteca para formatação (corrigido, estava escrito errado "<inmanip>")
using namespace std;  // Permite usar cout, cin, endl sem precisar escrever std:: antes

int main(){
    // Mensagem inicial
    cout << "Digite as alturas entre 150 e 220 cm." << endl;

    // Aqui falta declarar as variáveis altura1, altura2, altura3
    // Além disso, o operador de entrada correto é separado (>>), não por vírgula
    int altura1, altura2, altura3;
    cin >> altura1 >> altura2 >> altura3;

    // Verifica se altura1 está entre as duas outras (valor intermediário)
    if ( (altura1 > altura2 && altura1 < altura3) || (altura1 < altura2 && altura1 > altura3) ){
        cout << "A altura do gatti é: " << altura1;
    }
    // Verifica se altura2 é o valor intermediário
    else if ( (altura2 > altura1 && altura2 < altura3) || (altura2 < altura1 && altura2 > altura3) ){
        cout << "A altura do gatti é: " << altura2;
    }
    // Se não for nenhum dos dois, então altura3 é o intermediário
    else {
        cout << "A altura do gatti é: " << altura3;
    }
}
