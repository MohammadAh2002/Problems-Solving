/*

    Write a program to fill array with max size 100 with random numbers from 1 to 100,
    then print the count of Odd numbers.

    Input:
    10

    Output:
    Array Elements: 60 78 15 49 56 6 4 3 21 23
    Odd Numbers count is: 5

*/

#include <iostream>
#include <cstdlib>

using namespace std;

int RandomNumber(int From, int To) {

    int randNum = rand() % (To - From + 1) + From;
    return randNum;

}

void print_aray(int arr[], int arrlenth) {

    for (int i = 0; i < arrlenth; i++) {

        cout << arr[i] << " ";
    }
    cout << endl;
}

void give_random_array_elemnts(int arr[], int arrlenth) {

    for (int i = 0; i < arrlenth; i++) {

        arr[i] = RandomNumber(1, 100);
    }
}

int how_many_odd_numbers_is_array(int arr[], int arrlenth) {

    int sum = 0;

    for (int i = 0; i < arrlenth; i++) {

        if (arr[i] % 2 == 1)
            sum += 1;
             
    }

    return sum;

}

int main()
{
    srand((unsigned)time(NULL));

    int arr[10];
    give_random_array_elemnts(arr, 10);
    cout << "array elemnts is: ";
    print_aray(arr, 10);

    cout << "odd numbers count in the array is: ";
    cout << how_many_odd_numbers_is_array(arr, 10);
}
