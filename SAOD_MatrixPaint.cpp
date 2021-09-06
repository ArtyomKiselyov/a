#include <iostream>
#include <stack>
#include <utility>
#include <map>  
#include <ctime>
#include <cstdlib>
#include <vector>

using namespace std;
int matrix[100][100];

static void DrawMatrix()
{
    for (int i = 0; i < 100; i++)
    {
        for (int j = 0; j < 100; j++)
        {
            
            cout << matrix[i][j];
        }
        cout << endl;
    }
}

int main()
{
    int x, y;
    stack <pair<int, int>> s;
    int r;
    for (int i = 0; i < 100; i++) 
    {
        for (int j = 0; j < 100; j++)
        {
            r = rand() % 4 +1;
            if (r == 1) 
            {
                matrix[i][j] = 1;
            }
            else
            {
                matrix[i][j] = 0;
            }
        }
    }
    DrawMatrix();
    cout << "Enter X: ";
    cin >> x;
    cout << "Enter Y: ";
    cin >> y;
    pair<int, int> coordinates;
    coordinates.first = x;
    coordinates.second = y;
    s.push(coordinates);
    cout << endl;
    while (s.size() != 0)
    {
        pair<int, int> t = s.top();
        s.pop();
        matrix[t.first][t.second] = 2;
        if (t.first + 1 < 10 && matrix[t.first + 1][t.second] == 0)
        {
            coordinates.first = t.first + 1;
            coordinates.second = t.second;
            s.push(coordinates);
        }
        if (t.second - 1 >= 0 && matrix[t.first][t.second - 1] == 0)
        {
            coordinates.first = t.first;
            coordinates.second = t.second-1;
            s.push(coordinates);
        }
        if (t.first - 1 >= 0 && matrix[t.first - 1][t.second] == 0)
        {
            coordinates.first = t.first - 1;
            coordinates.second = t.second;
            s.push(coordinates);
        }
        if (t.second + 1 < 10 && matrix[t.first][t.second + 1] == 0)
        {
            coordinates.first = t.first;
            coordinates.second = t.second + 1;
            s.push(coordinates);
        }
    }
    DrawMatrix();
}