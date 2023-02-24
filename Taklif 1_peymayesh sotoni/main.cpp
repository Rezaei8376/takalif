//Mohamad Adnan Rezaei
#include <iostream>
using namespace std;
int main(){
	const int ROWS = 3;
const int COLS = 3;
int arr[ROWS][COLS];

for (int j = 0; j < COLS; j++) {
    for (int i = 0; i < ROWS; i++) {
        cin >> arr[i][j];
    }
}

for (int i = 0; i < ROWS; i++) {
    for (int j = 0; j < COLS; j++) {
        cout << arr[i][j] << " ";
    }
    cout << endl;
}
}
